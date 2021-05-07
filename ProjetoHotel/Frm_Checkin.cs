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
    public partial class Frm_Checkin : Form
    {
        public string nomefunc;
        private NpgsqlConnection pgsqlConnection;

        public Frm_Checkin(string nome)
        {
            InitializeComponent();

            nomefunc = nome;

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select quarto from quartos where status = 'Disponível' order by quarto;";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_quarto.DisplayMember = "quarto";

                cmb_quarto.DataSource = dt;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            dgv_pesquisa();
        }
        public void dgv_pesquisa()
        {
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "select reservaid, nomefunc, nomecli, entrada, valor, quartofk, status from reservas where status = 'Em andamento' order by reservaid;";

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

                if (pesquisa.pesquisar())
                {
                    txt_nome.Text = pesquisa.Nome;
                    msk_rg.Text = pesquisa.Rg;
                    msk_telefone.Text = pesquisa.Telefone;
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

        private void cmb_quarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Checkin_Checkout quartos = new Cls_Checkin_Checkout();

            quartos.Criterio = cmb_quarto.Text;

            if (quartos.camas())
            {
                txt_cama_solteiro.Text = quartos.Cama_solteiro;
                txt_solteiro_casal.Text = quartos.Cama_casal;
            }
        }

        private void cmb_quarto_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string diaria = "select diaria from quartos where quarto = '" + cmb_quarto.Text + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(diaria, pgsqlConnection);

                NpgsqlDataReader diariashow = cmd.ExecuteReader();

                diariashow.Read();

                msk_valor.Text = diariashow["diaria"].ToString();

                diariashow.Close();
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(msk_valor.Text);

            DateTime dataInicial = dtp_entrada.Value;

            DateTime dataFinal = dtp_saida.Value;

            if (dataInicial.ToString("dd-MM-yyyy") != DateTime.Now.ToString("dd-MM-yyyy"))
            {
                MessageBox.Show("Data inicial divergente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataFinal.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                MessageBox.Show("Data final não pode ser hoje!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimeSpan date = dataFinal - dataInicial;

                int totalDias = 1;

                totalDias += date.Days;

                if (totalDias < 1)
                {
                    MessageBox.Show("Data final divergente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    valor *= totalDias;

                    msk_total.Text = Convert.ToString(valor);
                }
            }
        }

        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            dgv_pesquisa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cls_Checkin_Checkout reserva = new Cls_Checkin_Checkout();

            if (msk_pesquisa.Text == "")
            {
                MessageBox.Show("Há campos vazios, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valor = Convert.ToDouble(msk_valor.Text);

                DateTime dataInicial = dtp_entrada.Value;

                DateTime dataFinal = dtp_saida.Value;

                if (dataInicial.ToString("dd-MM-yyyy") != DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    MessageBox.Show("Data inicial divergente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dataFinal.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    MessageBox.Show("Data final não pode ser hoje!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TimeSpan date = dataFinal - dataInicial;

                    int totalDias = 1;

                    totalDias += date.Days;

                    if (totalDias < 1)
                    {
                        MessageBox.Show("Data final divergente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        valor *= totalDias;

                        reserva.Valor = valor;

                        if (txt_nome.Text == "")
                        {
                            MessageBox.Show("Favor pesquisar ID para confirmar nome do cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_pesquisa.Focus();
                        }
                        else
                        {
                            string cliente = txt_nome.Text;
                            string[] nome_cliente = cliente.Split(' ');
                            reserva.Nome = nome_cliente[0];
                            reserva.Nomefunc = nomefunc;
                            reserva.Entrada = dtp_entrada.Value;
                            reserva.Saida = dtp_saida.Value;
                            reserva.Quarto = cmb_quarto.Text;                            
                            string id;
                            id = msk_pesquisa.Text;

                            if (reserva.checkin(id))
                            {
                                MessageBox.Show("Reserva realizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
            }
        }
    }
}
