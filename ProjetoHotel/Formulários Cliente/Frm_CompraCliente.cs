using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Frm_CompraCliente : Form
    {
        string login;
        public Frm_CompraCliente(string loginn)
        {
            InitializeComponent();

            login = loginn;

            cmb_quantidade.Items.Clear();
            cmb_quantidade.Items.Add("1");
            cmb_quantidade.Items.Add("2");
            cmb_quantidade.Items.Add("3");
            cmb_quantidade.Items.Add("4");
            cmb_quantidade.Items.Add("5");
            cmb_quantidade.Items.Add("6");
            cmb_quantidade.Items.Add("7");
            cmb_quantidade.Items.Add("8");
            cmb_quantidade.Items.Add("9");
            cmb_quantidade.Items.Add("10");
            cmb_quantidade.Items.Add("11");
            cmb_quantidade.Items.Add("12");
            cmb_quantidade.Items.Add("13");
            cmb_quantidade.Items.Add("14");
            cmb_quantidade.Items.Add("15");
            cmb_quantidade.Items.Add("16");
            cmb_quantidade.Items.Add("17");
            cmb_quantidade.Items.Add("18");
            cmb_quantidade.Items.Add("19");
            cmb_quantidade.Items.Add("20");
            cmb_quantidade.SelectedItem = "1";

            atualizadgv();

            atualizaComboBox();

            atualizaComboBox2();
        }
        public void atualizaComboBox()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select item from itens where status = 'Disponivel' order by item;";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_itens.DisplayMember = "item";

                cmb_itens.DataSource = dt;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void atualizaComboBox2()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select fk_usuario from login where login = '" + login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader Searchid = cmd.ExecuteReader();

                Searchid.Read();

                string id = Searchid["fk_usuario"].ToString();

                Searchid.Close();

                querry = "select quartofk from reservas where status = 'Em andamento' and usuariofk = '"+ id +"';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_quarto.DisplayMember = "quartofk";

                cmb_quarto.DataSource = dt;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void atualizadgv()
        {
            NpgsqlConnection pgsqlconnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();
                pgsqlconnection = objconexao.getConexao();

                pgsqlconnection.Open();

                string querry = "select item, nome_fornecedor, valor, quantidade, status from itens, fornecedor where status = 'Disponivel' and itemfk = itemid order by itemid;";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlconnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_itens.DataSource = dt;
                }
            }
            finally
            {
                pgsqlconnection.Close();
            }
        }
        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            atualizadgv();
        }

        private void cmb_itens_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select valor from itens where item = '" + cmb_itens.Text + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                comboboxshow.Read();

                txt_valor.Text = comboboxshow["valor"].ToString();
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (cmb_quarto.Text == "")
            {
                MessageBox.Show("Não há reservas em andamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            else
            {
                Cls_Checkin_Checkout compra = new Cls_Checkin_Checkout();

                compra.Criterio = cmb_quarto.Text;
                compra.Nome = cmb_itens.Text;
                compra.Quantidade = Convert.ToInt16(cmb_quantidade.Text);
                compra.Total = Convert.ToDouble(txt_valor.Text);

                DialogResult compraCheck = new DialogResult();

                compraCheck = MessageBox.Show($"Comprar {compra.Quantidade} do item ({compra.Nome}) do valor de R${compra.Total} totalizando R${(compra.Quantidade * compra.Total):f2} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (compraCheck == DialogResult.Yes)
                {
                    if (compra.compra())
                    {
                        MessageBox.Show("Item comprado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizadgv();
                        atualizaComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("O item não foi comprado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }        
    }
}
