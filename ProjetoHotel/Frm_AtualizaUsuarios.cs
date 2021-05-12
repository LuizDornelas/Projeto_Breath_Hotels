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
    public partial class Frm_AtualizaUsuarios : Form
    {
        public string tipo;
        public Frm_AtualizaUsuarios(string tipoo)
        {
            tipo = tipoo;

            InitializeComponent();            

            cmb_tipo.Items.Clear();
            cmb_ativo.Items.Clear();
            cmb_criterio.Items.Clear();

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
            
            cmb_criterio.Items.Add("Id");
            cmb_criterio.Items.Add("RG");
            cmb_criterio.Items.Add("Telefone");
            cmb_criterio.SelectedItem = "Id";

            atualizadgv();
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
            else if (cmb_criterio.Text == "")
            {
                MessageBox.Show("Selecione o critério para que seja atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_criterio.Focus();
            }
            else
            {
                Cls_Cadastro atualizar = new Cls_Cadastro();

                atualizar.Pesquisa = msk_pesquisa.Text;
                atualizar.Criterio = cmb_criterio.Text;
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

                    msk_pesquisa.Text = "";                    
                    txt_nome.Text = "";
                    msk_rg.Text = "";
                    msk_telefone.Text = "";
                    txt_rua.Text = "";
                    msk_numero.Text = "";
                    txt_bairro.Text = "";
                    txt_cidade.Text = "";
                    txt_estado.Text = "";
                    msk_cep.Text = "";
                    txt_usuario.Text = "";
                    txt_senha.Text = "";                    
                }
            }
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "select usuarioid, nome, rg, telefone, rua, numero, bairro, cidade, estado, cep, login.ativo, login, senha, tipo from usuario, login where usuarioid = fk_usuario;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_usuarios.DataSource = dt;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }

            if (cmb_criterio.Text == "")
            {
                MessageBox.Show("Selecione um critério para pesquisa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_criterio.Focus();

                txt_nome.Text = "";
                msk_rg.Text = "";
                msk_telefone.Text = "";
                txt_rua.Text = "";
                msk_numero.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_estado.Text = "";
                msk_cep.Text = "";
                cmb_ativo.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                cmb_tipo.Text = "";
            }
            else if (msk_pesquisa.Text == "")
            {
                MessageBox.Show("Preencha o campo de pesquisa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_pesquisa.Focus();

                txt_nome.Text = "";
                msk_rg.Text = "";
                msk_telefone.Text = "";
                txt_rua.Text = "";
                msk_numero.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_estado.Text = "";
                msk_cep.Text = "";
                cmb_ativo.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                cmb_tipo.Text = "";
            }
            else if (msk_pesquisa.Text == "(  )     -")
            {
                MessageBox.Show("Preencha o campo de pesquisa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_pesquisa.Focus();

                txt_nome.Text = "";
                msk_rg.Text = "";
                msk_telefone.Text = "";
                txt_rua.Text = "";
                msk_numero.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_estado.Text = "";
                msk_cep.Text = "";
                cmb_ativo.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                cmb_tipo.Text = "";
            }
            else if (msk_pesquisa.Text == "  .   .   -")
            {
                MessageBox.Show("Preencha o campo de pesquisa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_pesquisa.Focus();

                txt_nome.Text = "";
                msk_rg.Text = "";
                msk_telefone.Text = "";
                txt_rua.Text = "";
                msk_numero.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_estado.Text = "";
                msk_cep.Text = "";
                cmb_ativo.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                cmb_tipo.Text = "";
            }
            else
            {
                pesquisa.Criterio = cmb_criterio.Text;
                pesquisa.Pesquisa = msk_pesquisa.Text;

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
        }

        private void cmb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_criterio.Text == "Id")
            {
                msk_pesquisa.Mask = "9999";
                msk_pesquisa.Text = "";
            }
            else if (cmb_criterio.Text == "RG")
            {
                msk_pesquisa.Mask = "99,999,999-9";
                msk_pesquisa.Text = "";
            }
            else
            {
                msk_pesquisa.Mask = "(99)00000-0000";
                msk_pesquisa.Text = "";
            }
        }
    }
}