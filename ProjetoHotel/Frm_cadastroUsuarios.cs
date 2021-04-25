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
    public partial class Frm_cadastroUsuarios : Form
    {
        public Frm_cadastroUsuarios(string tipo)
        {
            InitializeComponent();

            cmb_cadastro_fun.Items.Clear();

            if (tipo == "Cargo: Admin")
            {                
                cmb_cadastro_fun.Items.Add("Func");
                cmb_cadastro_fun.Items.Add("Admin");
                cmb_cadastro_fun.Items.Add("Cliente");
            }
            else
            {
                cmb_cadastro_fun.Items.Add("Cliente");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmb_cadastro_fun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_cadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pesquisar_fun_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {

            Cls_Cadastro usuario = new Cls_Cadastro();

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
            else if (cmb_cadastro_fun.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_cadastro_fun.Focus();
            }
            else
            {
                usuario.Nome = txt_nome.Text;
                usuario.Rg = msk_rg.Text;
                usuario.Telefone = msk_telefone.Text;
                usuario.Rua = txt_rua.Text;
                usuario.Numero = msk_numero.Text;
                usuario.Bairro = txt_bairro.Text;
                usuario.Cidade = txt_cidade.Text;
                usuario.Estado = txt_estado.Text;
                usuario.Cep = msk_cep.Text;
                usuario.Login = txt_usuario.Text;
                usuario.Senha = txt_senha.Text;
                usuario.Tipo = cmb_cadastro_fun.Text;

                if (usuario.cadastro())
                {
                    MessageBox.Show("Usuário criado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }
    }
}