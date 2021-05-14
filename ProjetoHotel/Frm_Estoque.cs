using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Frm_Estoque : Form
    {
        public Frm_Estoque()
        {
            InitializeComponent();
            
            atualizaComboBox();

            atualizadgv();
        }
        public void atualizaComboBox()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select item from itens order by item;";

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
        public void atualizadgv()
        {
            NpgsqlConnection pgsqlconnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();
                pgsqlconnection = objconexao.getConexao();

                pgsqlconnection.Open();

                string querry = "select item, nome_fornecedor, valor_item, quantidade, status from itens, fornecedor where itemfk = itemid order by itemid;";

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
        private void cmb_itens_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select nome_fornecedor, quantidade, valor_item from itens, fornecedor where itemfk = itemid and item = '" + cmb_itens.Text +"';";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                comboboxshow.Read();

                txt_fornecedor.Text = comboboxshow["nome_fornecedor"].ToString();
                txt_qnt_disponivel.Text = comboboxshow["quantidade"].ToString();
                txt_valor.Text = comboboxshow["valor_item"].ToString();
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

        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            atualizadgv();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (msk_quantidade.Text == "" || msk_quantidade.Text == "0")
            {
                MessageBox.Show("Quantidade de itens inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_quantidade.Focus();
            }
            else
            {
                Cls_Checkin_Checkout compra = new Cls_Checkin_Checkout();
                
                compra.Nome = cmb_itens.Text;
                compra.Quantidade = Convert.ToInt16(msk_quantidade.Text);
                compra.Quantidade2 = Convert.ToInt16(txt_qnt_disponivel.Text);
                double valor = Convert.ToDouble(txt_valor.Text);

                DialogResult compraCheck = new DialogResult();

                compraCheck = MessageBox.Show($"Comprar {compra.Quantidade} do item ({compra.Nome}) do valor de R${valor} totalizando R${(compra.Quantidade * valor):f2} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (compraCheck == DialogResult.Yes)
                {
                    if (compra.compraEstoque())
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
