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
    public partial class Frm_CadastroQuarto : Form
    {
        public Frm_CadastroQuarto()
        {
            InitializeComponent();

            cmb_tipo.Items.Clear();
            cmb_tipo.Items.Add("Simples");
            cmb_tipo.Items.Add("Luxo");
            cmb_tipo.SelectedItem = "Simples";
            atualizadtg();
        }
        public void atualizadtg()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "SELECT quarto, tipo, camasolteiro, camacasal, status, diaria from quartos order by quarto;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_quartos.DataSource = dt;
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

        private void btn_atualiza_dgv_Click(object sender, EventArgs e)
        {
            atualizadtg();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_quarto.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quarto.Focus();
            }
            else if (msk_camasolteiro.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_camasolteiro.Focus();
            }
            else if (msk_camacasal.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_camacasal.Focus();
            }
            else if (msk_diaria.Text == "   .")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_diaria.Focus();
            }
            else
            {
                Cls_Cadastro quarto = new Cls_Cadastro();

                quarto.Nome = txt_quarto.Text.ToUpper();
                quarto.Tipo = cmb_tipo.Text;
                quarto.Camasolteiro = Convert.ToInt16(msk_camasolteiro.Text);
                quarto.Camacasal = Convert.ToInt16(msk_camacasal.Text);
                quarto.Valor = (msk_diaria.Text);

                if (quarto.cadastroQuarto())
                {
                    MessageBox.Show("Quarto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
