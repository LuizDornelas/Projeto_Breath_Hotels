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
    public partial class Frm_CadastroCartao : Form
    {
        public Frm_CadastroCartao()
        {
            InitializeComponent();

            cmb_bandeira.Items.Clear();
            cmb_bandeira.Items.Add("MasterCard");
            cmb_bandeira.Items.Add("Visa");
            cmb_bandeira.SelectedItem = "MasterCard";

            attComboBox();
        }
        public void attComboBox()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "SELECT usuarioid FROM usuario order by usuarioid;";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_pesquisa_cartao.DisplayMember = "usuarioid";

                cmb_pesquisa_cartao.DataSource = dt;
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {            
            if (msk_numero_cartao.Text == "    -    -    -")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_numero_cartao.Focus();
            }
            else if (txt_nome_cartao.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome_cartao.Focus();
            }
            else if (msk_validade.Text == "  /")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_validade.Focus();
            }
            else if (msk_codigo.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_codigo.Focus();
            }
            else
            {
                Cls_Cadastro cartao = new Cls_Cadastro();

                cartao.Numero = msk_numero_cartao.Text;
                cartao.Nome = txt_nome_cartao.Text.ToUpper();
                cartao.Validiade = msk_validade.Text;
                cartao.Codigo = msk_codigo.Text;
                cartao.Bandeira = cmb_bandeira.Text;

                if (cartao.cadastroCartao(cmb_pesquisa_cartao.Text))
                {
                    MessageBox.Show("Cartão cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Frm_CadastroCartao_Load(object sender, EventArgs e)
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

        private void cmb_pesquisa_cartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            pesquisa.Criterio = cmb_pesquisa_cartao.Text;

            if (pesquisa.pesquisar())
            {
                txt_nome.Text = pesquisa.Nome;
                msk_rg.Text = pesquisa.Rg;
            }
        }
    }
}
