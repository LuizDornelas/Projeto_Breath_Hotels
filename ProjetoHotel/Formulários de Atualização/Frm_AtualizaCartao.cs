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
    public partial class Frm_AtualizaCartao : Form
    {
        public Frm_AtualizaCartao()
        {
            InitializeComponent();

            cmb_bandeira.Items.Clear();
            cmb_bandeira.Items.Add("MasterCard");
            cmb_bandeira.Items.Add("Visa");

            atualizadtg();
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

                string combobox = "SELECT usuariofk FROM cartao order by usuariofk;";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_pesquisa_cartao.DisplayMember = "usuariofk";

                cmb_pesquisa_cartao.DataSource = dt;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void atualizadtg()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "SELECT usuariofk, numerocartao, nome, validade, codigo, bandeira FROM cartao order by usuariofk;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_cartoes.DataSource = dt;
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

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (cmb_pesquisa_cartao.Text == "")
            {
                MessageBox.Show("Não há nenhum cartão registrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Cls_Cadastro atualizaCartao = new Cls_Cadastro();

                atualizaCartao.Criterio = cmb_pesquisa_cartao.Text;

                atualizaCartao.Numero = msk_numero_cartao.Text;
                atualizaCartao.Nome = txt_nome_cartao.Text.ToUpper();
                atualizaCartao.Validiade = msk_validade.Text;
                atualizaCartao.Codigo = msk_codigo.Text;
                atualizaCartao.Bandeira = cmb_bandeira.Text;

                if (atualizaCartao.atualizaCartao())
                {
                    MessageBox.Show("Cartão atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizadtg();
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (cmb_pesquisa_cartao.Text == "")
            {
                MessageBox.Show("Não há nenhum cartão registrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
            else
            {
                Cls_Cadastro excluir = new Cls_Cadastro();

                excluir.Criterio = cmb_pesquisa_cartao.Text;

                if (excluir.excluiCartao())
                {
                    attComboBox();
                    MessageBox.Show("Cartão excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizadtg();
                }
            }
        }

        private void cmb_pesquisa_cartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            pesquisa.Criterio = cmb_pesquisa_cartao.Text;

            if (pesquisa.pesquisarCartao())
            {
                msk_numero_cartao.Text = pesquisa.Numero;
                txt_nome_cartao.Text = pesquisa.Nome;
                msk_validade.Text = pesquisa.Validiade;
                msk_codigo.Text = pesquisa.Codigo;
                cmb_bandeira.Text = pesquisa.Bandeira;
                txt_nome.Text = pesquisa.Nome2;
            }
        }
    }
}
