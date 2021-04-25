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
            lbl_nome.Text = name;
            lbl_usuario.Text = "Cargo: " + tipo;
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
            this.lbl_data.Text = DateTime.Now.ToString("DATA: dd-MM-yyyy");
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

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atualizaCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AtualizaUsuarios Atualiza = new Frm_AtualizaUsuarios();
            Atualiza.StartPosition = FormStartPosition.CenterParent;
            Atualiza.MdiParent = this;
            Atualiza.Show();
        }
    }
}