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
    public partial class Frm_AtualizaUsuarios : Form
    {
        public string tipo;
        public Frm_AtualizaUsuarios(string tipoo)
        {
            tipo = tipoo;

            InitializeComponent();

            cmb_tipo.Items.Clear();
            cmb_ativo.Items.Clear();

            if (tipoo == "Cargo: Admin")
            {
                cmb_tipo.Items.Add("Func");
                cmb_tipo.Items.Add("Admin");
                cmb_tipo.Items.Add("Cliente");
            }
            else
            {
                cmb_tipo.Items.Add("Cliente");
                cmb_tipo.SelectedItem = "Cliente";
            }

            cmb_ativo.Items.Add("SIM");
            cmb_ativo.Items.Add("NAO");

            atualizadgv();
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

                string combobox;
                NpgsqlCommand cmd;

                if (tipo == "Cargo: Admin")
                {
                    combobox = "select usuarioid from usuario order by usuarioid;";

                    cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                    NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(comboboxshow);

                    cmb_pesquisacad.DisplayMember = "usuarioid";

                    cmb_pesquisacad.DataSource = dt;
                }
                else
                {
                    combobox = "select usuarioid from usuario, login where usuarioid = fk_usuario and tipo = 'Cliente' order by usuarioid;";

                    cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                    NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(comboboxshow);

                    cmb_pesquisacad.DisplayMember = "usuarioid";

                    cmb_pesquisacad.DataSource = dt;
                }                
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void atualizadgv()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "select usuarioid, nome, rg, telefone, rua, numero, bairro, cidade, estado, cep, login.ativo, login, senha, tipo from usuario, login where usuarioid = fk_usuario order by usuarioid;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_usuarios.DataSource = dt;
                }
                else
                {
                    dgv_usuarios.DataSource = null;
                }
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
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
            }
            else if (msk_rg.Text == "  .   .   -")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_rg.Focus();
            }
            else if (msk_telefone.Text == "(  )     -")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_telefone.Focus();
            }
            else if (txt_rua.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rua.Focus();
            }
            else if (msk_numero.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_numero.Focus();
            }
            else if (txt_bairro.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_bairro.Focus();
            }
            else if (txt_cidade.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cidade.Focus();
            }
            else if (txt_estado.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_estado.Focus();
            }
            else if (msk_cep.Text == "     -")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_cep.Focus();
            }
            else if (txt_usuario.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
            }
            else if (txt_senha.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_senha.Focus();
            }
            else if (cmb_tipo.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipo.Focus();
            }
            else if (cmb_ativo.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_ativo.Focus();
            }
            else
            {
                Cls_Cadastro atualizar = new Cls_Cadastro();

                atualizar.Pesquisa = cmb_pesquisacad.Text;
                atualizar.Nome = txt_nome.Text;
                atualizar.Rg = msk_rg.Text;
                atualizar.Telefone = msk_telefone.Text;
                atualizar.Rua = txt_rua.Text;
                atualizar.Numero = msk_numero.Text;
                atualizar.Bairro = txt_bairro.Text;
                atualizar.Cidade = txt_cidade.Text;
                atualizar.Ativo = cmb_ativo.Text;
                atualizar.Estado = txt_estado.Text;
                atualizar.Cep = msk_cep.Text;
                atualizar.Login = txt_usuario.Text;
                atualizar.Senha = txt_senha.Text;
                atualizar.Tipo = cmb_tipo.Text;

                if (atualizar.atualiza())
                {
                    MessageBox.Show("Usuário atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizadgv();
                }
            }
        }
        private void cmb_pesquisacad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            atualizadgv();
            
            pesquisa.Pesquisa = cmb_pesquisacad.Text;

            if (pesquisa.pesquisar(tipo))
            {
                txt_nome.Text = pesquisa.Nome;
                msk_rg.Text = pesquisa.Rg;
                msk_telefone.Text = pesquisa.Telefone;
                txt_rua.Text = pesquisa.Rua;
                msk_numero.Text = pesquisa.Numero;
                txt_bairro.Text = pesquisa.Bairro;
                txt_cidade.Text = pesquisa.Cidade;
                txt_estado.Text = pesquisa.Estado;
                msk_cep.Text = pesquisa.Cep;
                cmb_ativo.Text = pesquisa.Ativo;
                txt_usuario.Text = pesquisa.Login;
                txt_senha.Text = pesquisa.Senha;
                cmb_tipo.Text = pesquisa.Tipo;
            }
        }

        private void Frm_AtualizaUsuarios_Load(object sender, EventArgs e)
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