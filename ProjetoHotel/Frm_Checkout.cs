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
    public partial class Frm_Checkout : Form
    {
        private NpgsqlConnection pgsqlConnection;

        public Frm_Checkout()
        {
            InitializeComponent();

            cmb_criterio.Items.Clear();
            cmb_criterio.Items.Add("Id");
            cmb_criterio.Items.Add("Quarto");
            cmb_criterio.SelectedItem = "Id";

            dgv_pesquisa();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void dgv_pesquisa()
        {
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "select reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status from reservas where status = 'Em andamento' order by reservaid;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_reservas.DataSource = dt;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void limpa_campos()
        {
            txt_nome.Text = "";
            txt_entrada.Text = "";
            txt_saida.Text = "";
            txt_quarto.Text = "";
            msk_total.Text = "";
        }
        public void itens(string criterio)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                int pesquisa = Convert.ToInt16(criterio);

                pesquisar = "select item, valor, quantidade, data from consumos where reservafk = '" + pesquisa + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

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
                pgsqlConnection.Close();
            }
        }
        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Cls_Checkin_Checkout pesquisa = new Cls_Checkin_Checkout();

            if (msk_pesquisa.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pesquisa.Criterio = msk_pesquisa.Text;

                if (cmb_criterio.Text == "Id")
                {
                    if (pesquisa.pesquisaid())
                    {
                        txt_nome.Text = pesquisa.Nome;
                        txt_entrada.Text = pesquisa.Entradaout;
                        txt_saida.Text = pesquisa.Saidaout;
                        txt_quarto.Text = pesquisa.Quarto;
                        itens(msk_pesquisa.Text);
                        pesquisa.Id = msk_pesquisa.Text;
                        if (pesquisa.valortotal())
                        {
                            msk_total.Text = Convert.ToString($"{pesquisa.Total:f2}");
                        }                                              
                    }
                    else
                    {
                        MessageBox.Show("Reserva não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpa_campos();
                    }
                }
                else
                {
                    if (pesquisa.pesquisaquarto())
                    {
                        txt_nome.Text = pesquisa.Nome;
                        txt_entrada.Text = pesquisa.Entradaout;
                        txt_saida.Text = pesquisa.Saidaout;
                        txt_quarto.Text = pesquisa.Quarto;
                        itens(pesquisa.Id);
                        pesquisa.valortotal();
                        msk_total.Text = Convert.ToString($"{pesquisa.Total:f2}");
                    }
                    else
                    {
                        MessageBox.Show("Reserva não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpa_campos();
                    }
                }

            }
        }

        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            dgv_pesquisa();
        }

        private void cmb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_criterio.Text == "Id")
            {
                msk_pesquisa.Mask = "9999";
                msk_pesquisa.Text = "";
            }
            else
            {
                msk_pesquisa.Mask = "";
                msk_pesquisa.Text = "";
            }
        }
    }
}
