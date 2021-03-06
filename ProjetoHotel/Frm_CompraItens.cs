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
    public partial class Frm_CompraItens : Form
    {
        public Frm_CompraItens()
        {
            InitializeComponent();

            atualizaComboBox();

            atualizaComboBox2();

            atualizadgv();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                string combobox = "select quartofk from reservas where status = 'Em andamento';";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

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

        private void cmb_quarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select nome from usuario, reservas where usuariofk = usuarioid and status = 'Em andamento' and quartofk = '" + cmb_quarto.Text + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                comboboxshow.Read();

                txt_nome.Text = comboboxshow["nome"].ToString();
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            atualizadgv();
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

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (cmb_quarto.Text == "")
            {
                MessageBox.Show("Não há reservas em andamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (msk_quantidade.Text == "" || msk_quantidade.Text == "0")
            {
                MessageBox.Show("Quantidade de itens inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msk_quantidade.Focus();
            }
            else
            {
                Cls_Checkin_Checkout compra = new Cls_Checkin_Checkout();

                compra.Criterio = cmb_quarto.Text;
                compra.Nome = cmb_itens.Text;
                compra.Quantidade = Convert.ToInt16(msk_quantidade.Text);
                compra.Total = Convert.ToDouble(txt_valor.Text);

                DialogResult compraCheck = new DialogResult();

                compraCheck = MessageBox.Show($"Comprar {compra.Quantidade} do item ({compra.Nome}) do valor de R${compra.Total} totalizando R${(compra.Quantidade* compra.Total):f2} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void Frm_CompraItens_Load(object sender, EventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
    }
}
