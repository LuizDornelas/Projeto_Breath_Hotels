using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoHotel
{
    public partial class Frm_CadastroItensFornecedor : Form
    {
        public Frm_CadastroItensFornecedor()
        {
            InitializeComponent();
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

                string querry = "select itemid, item, valor, quantidade, status, nome_fornecedor, valor_item from itens, fornecedor where itemfk = itemid order by itemid;";

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
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_atualiza_dgv_Click(object sender, EventArgs e)
        {
            atualizadgv();
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
            else if (msk_quantidade_itens.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_quantidade_itens.Focus();
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

                item.Nome = txt_nome_item.Text;
                item.Nome2 = txt_nome_fornecedor.Text;
                item.Valor = txt_valor_item.Text.Replace(",", ".").Trim();
                item.Valor2 = txt_valor_fornecedor.Text.Replace(",", ".").Trim();
                item.Quantidade = Convert.ToInt16(msk_quantidade_itens.Text);

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
                    if (item.cadastroItens())
                    {
                        MessageBox.Show("Item cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizadgv();
                        txt_nome_item.Text = "";
                        txt_nome_fornecedor.Text = "";
                        txt_valor_item.Text = "";
                        txt_valor_fornecedor.Text = "";
                        msk_quantidade_itens.Text = "";
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

        private void Frm_CadastroItensFornecedor_Load(object sender, EventArgs e)
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
