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
    public partial class Frm_CadastroCartao : Form
    {
        public Frm_CadastroCartao()
        {
            InitializeComponent();

            cmb_bandeira.Items.Clear();
            cmb_bandeira.Items.Add("MasterCard");
            cmb_bandeira.Items.Add("Visa");
            cmb_bandeira.SelectedItem = "MasterCard";
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            if (msk_pesquisa.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pesquisa.Criterio = msk_pesquisa.Text;

                if (pesquisa.pesquisar())
                {
                    txt_nome.Text = pesquisa.Nome;
                    msk_rg.Text = pesquisa.Rg;                    
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado, ou desativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (msk_pesquisa.Text == "" || txt_nome.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_pesquisa.Focus();
            }
            else if (msk_numero_cartao.Text == "    -    -    -")
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

                if (cartao.cadastroCartao(msk_pesquisa.Text))
                {
                    MessageBox.Show("Cartão cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário já tem cartão cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
