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
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard(string name, string tipo)
        {
            InitializeComponent();

            string[] nome = name.Split(' ');

            lbl_nome.Text = nome[0];
            lbl_usuario.Text = "Cargo: " + tipo;

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select count (status) from reservas where status = 'Em andamento';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader reserva = cmd.ExecuteReader();

                reserva.Read();

                lbl_reservas.Text = $"Reservas: {reserva["count"].ToString()}";

                reserva.Close();

                querry = "select count (quarto) from quartos;";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader total_quartos = cmd.ExecuteReader();

                total_quartos.Read();

                lbl_quartostotal.Text = $"Total Quartos: {total_quartos["count"].ToString()}";

                total_quartos.Close();

                querry = "select count (quarto) from quartos where status = 'Disponível';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartos_disponivel = cmd.ExecuteReader();

                quartos_disponivel.Read();

                lbl_quartosdisponiveis.Text = $"Quartos disponíveis: {quartos_disponivel["count"].ToString()}";

                quartos_disponivel.Close();
            }
            finally
            {
                pgsqlConnection.Close();
            }

        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tipo = lbl_usuario.Text;
            Frm_CadastroUsuarios Cadastro = new Frm_CadastroUsuarios(tipo);
            Cadastro.StartPosition = FormStartPosition.CenterParent;
            Cadastro.MdiParent = this;
            Cadastro.Show();
            Cadastro.txt_nome.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_horas.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void lbl_horas_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pg_1_Load(object sender, EventArgs e)
        {

        }
        private void tmr_data_Tick(object sender, EventArgs e)
        {
            this.lbl_data.Text = DateTime.Now.ToString("DATA: dd/MM/yyyy");
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
        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hospedadoscheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Checkin Checkin = new Frm_Checkin(lbl_nome.Text);
            Checkin.StartPosition = FormStartPosition.CenterParent;
            Checkin.MdiParent = this;
            Checkin.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Checkout Checkout = new Frm_Checkout();
            Checkout.StartPosition = FormStartPosition.CenterParent;
            Checkout.MdiParent = this;
            Checkout.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atualizaCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select count (status) from reservas where status = 'Em andamento';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader reserva = cmd.ExecuteReader();

                reserva.Read();

                lbl_reservas.Text = $"Reservas: {reserva["count"].ToString()}";

                reserva.Close();

                querry = "select count (quarto) from quartos;";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader total_quartos = cmd.ExecuteReader();

                total_quartos.Read();

                lbl_quartostotal.Text = $"Total Quartos: {total_quartos["count"].ToString()}";

                total_quartos.Close();

                querry = "select count (quarto) from quartos where status = 'Disponível';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartos_disponivel = cmd.ExecuteReader();

                quartos_disponivel.Read();

                lbl_quartosdisponiveis.Text = $"Quartos disponíveis: {quartos_disponivel["count"].ToString()}";

                quartos_disponivel.Close();
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void atualizaCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string tipo = lbl_usuario.Text;
            Frm_AtualizaUsuarios Atualiza = new Frm_AtualizaUsuarios(tipo);
            Atualiza.StartPosition = FormStartPosition.CenterParent;
            Atualiza.MdiParent = this;
            Atualiza.Show();
        }

        private void cadastroDeCartõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroCartao Cartao = new Frm_CadastroCartao();
            Cartao.StartPosition = FormStartPosition.CenterParent;
            Cartao.MdiParent = this;
            Cartao.Show();
        }

        private void atualizarCartãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AtualizaCartao atualizaCartao = new Frm_AtualizaCartao();
            atualizaCartao.StartPosition = FormStartPosition.CenterParent;
            atualizaCartao.MdiParent = this;
            atualizaCartao.Show();
        }

        private void cadastroDeQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroQuarto CadQuarto = new Frm_CadastroQuarto();
            CadQuarto.StartPosition = FormStartPosition.CenterParent;
            CadQuarto.MdiParent = this;
            CadQuarto.Show();
        }

        private void atualizarQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AtualizaQuarto AttQuarto = new Frm_AtualizaQuarto();
            AttQuarto.StartPosition = FormStartPosition.CenterParent;
            AttQuarto.MdiParent = this;
            AttQuarto.Show();
        }
    }
}