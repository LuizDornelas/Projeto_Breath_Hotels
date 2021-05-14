using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel.Formulários_de_Atualização
{
    public partial class Frm_AtualizaItensFornecedor : Form
    {
        public Frm_AtualizaItensFornecedor()
        {
            InitializeComponent();

            atualizadgv();

            atualizaComboBox();
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

                cmb_item.DisplayMember = "item";

                cmb_item.DataSource = dt;
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

                string querry = "select itemid, item, valor, status, nome_fornecedor, valor_item from itens, fornecedor where itemfk = itemid order by itemid;";

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

        private void btn_atualiza_dgv_Click(object sender, EventArgs e)
        {
            atualizadgv();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome_item.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome_item.Focus();
            }
            else if (txt_valor_item.Text == "   ,")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor_item.Focus();
            }
            else if (txt_nome_fornecedor.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome_fornecedor.Focus();
            }
            else if (txt_valor_fornecedor.Text == "   ,")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor_fornecedor.Focus();
            }
            else
            {
                Cls_Cadastro item = new Cls_Cadastro();

                item.Criterio = cmb_item.Text;
                item.Nome = txt_nome_item.Text;
                item.Nome2 = txt_nome_fornecedor.Text;
                item.Valor = txt_valor_item.Text.Replace(",", ".").Trim();
                item.Valor2 = txt_valor_fornecedor.Text.Replace(",", ".").Trim();

                bool caractereSearch = Regex.IsMatch(item.Nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));

                bool caractereSearch2 = Regex.IsMatch(item.Nome2, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));

                if (caractereSearch)
                {
                    MessageBox.Show("Revisar nome, pois há caracteres especiais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nome_item.Text = "";
                    txt_nome_item.Focus();
                }
                else if (caractereSearch2)
                {
                    MessageBox.Show("Revisar nome, pois há caracteres especiais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nome_fornecedor.Text = "";
                    txt_nome_fornecedor.Focus();
                }
                else
                {
                    DialogResult atualiza = new DialogResult();

                    atualiza = MessageBox.Show($"Certeza que ira atualizar o item {cmb_item.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (atualiza == DialogResult.Yes)
                    {
                        if (item.atualizaItens())
                        {
                            MessageBox.Show("Item atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            atualizadgv();
                            atualizaComboBox();
                            txt_nome_item.Text = "";
                            txt_nome_fornecedor.Text = "";
                            txt_valor_item.Text = "";
                            txt_valor_fornecedor.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show($"O item não foi atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void txt_valor_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_valor_item.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_valor_fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_valor_fornecedor.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Cls_Cadastro item = new Cls_Cadastro();

            item.Criterio = cmb_item.Text;

            DialogResult excluir = new DialogResult();

            excluir = MessageBox.Show($"Certeza que ira excluir o item {cmb_item.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (excluir == DialogResult.Yes)
            {
                if (item.excluiItem())
                {
                    MessageBox.Show("Item excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizadgv();
                    atualizaComboBox();
                    txt_nome_item.Text = "";
                    txt_nome_fornecedor.Text = "";
                    txt_valor_item.Text = "";
                    txt_valor_fornecedor.Text = "";
                }
            }
            else
            {
                MessageBox.Show($"O item não foi excluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            pesquisa.Criterio = cmb_item.Text;

            if (pesquisa.pesquisaItem())
            {
                txt_nome_item.Text = pesquisa.Nome;
                txt_nome_fornecedor.Text = pesquisa.Nome2;
                txt_valor_item.Text = pesquisa.Valor;
                txt_valor_fornecedor.Text = pesquisa.Valor2;
            }
        }
    }
}
