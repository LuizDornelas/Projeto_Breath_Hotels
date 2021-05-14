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
    public partial class Frm_Cliente : Form
    {
        string login;
        public Frm_Cliente(string name, string loginn)
        {
            InitializeComponent();

            login = loginn;

            string[] nome = name.Split(' ');

            lbl_nome.Text = $"Usuário: {nome[0]}";

            attDashboard();

            ReservasEmAndamento();
        }
        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login form = new Frm_Login();
            form.ShowDialog();
            this.Close();
        }

        private void tmr_horas_Tick_1(object sender, EventArgs e)
        {
            this.lbl_horas.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tmr_data_Tick_1(object sender, EventArgs e)
        {
            this.lbl_data.Text = DateTime.Now.ToString("DATA: dd/MM/yyyy");
        }
        public void attDashboard()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select fk_usuario from login where login = '" + login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader Searchid = cmd.ExecuteReader();

                Searchid.Read();

                string id = Searchid["fk_usuario"].ToString();

                Searchid.Close();

                querry = "select count(quartofk) from reservas where status = 'Encerrado' and usuariofk = '" + id + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader ReservaEnc = cmd.ExecuteReader();

                ReservaEnc.Read();

                lbl_reservas_encerradas.Text = $"Reservas encerradas: {ReservaEnc["count"].ToString()}";

                ReservaEnc.Close();

                querry = "select count(quartofk) from reservas where status = 'Em andamento' and usuariofk = '" + id + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader ReservaAnd = cmd.ExecuteReader();

                ReservaAnd.Read();

                lbl_reservas_andamento.Text = $"Reservas encerradas: {ReservaAnd["count"].ToString()}";
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            attDashboard();
        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            Frm_CompraCliente CompraItens = new Frm_CompraCliente(login);
            CompraItens.StartPosition = FormStartPosition.CenterParent;           
            CompraItens.Show();
            CompraItens.BringToFront();
        }
        private void btn_encerrados_Click_1(object sender, EventArgs e)
        {
            ReservasEncerradas();
        }

        private void btn_andamento_Click_1(object sender, EventArgs e)
        {
            ReservasEmAndamento();
        }
        public void ReservasEmAndamento()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select fk_usuario from login where login = '" + login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader Searchid = cmd.ExecuteReader();

                Searchid.Read();

                string id = Searchid["fk_usuario"].ToString();

                Searchid.Close();

                querry = "select nomefunc, nomecli, entrada, saida, valor, quartofk from reservas where status = 'Em andamento' and usuariofk = '" + id + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_reservas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Você não possui reservas em andamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void ReservasEncerradas()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select fk_usuario from login where login = '" + login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader Searchid = cmd.ExecuteReader();

                Searchid.Read();

                string id = Searchid["fk_usuario"].ToString();

                Searchid.Close();

                querry = "select nomefunc, nomecli, entrada, saida, valor, quartofk from reservas where status = 'Encerrado' and usuariofk = '" + id + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_reservas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Você não possui reservas encerradas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasEmAndamento();
        }

        private void reservasEncerradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasEncerradas();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CompraCliente CompraItens = new Frm_CompraCliente(login);
            CompraItens.StartPosition = FormStartPosition.CenterParent;         
            CompraItens.Show();
            CompraItens.BringToFront();
        }
    }
}
