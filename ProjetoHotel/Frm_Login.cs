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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cls_Login objusuario = new Cls_Login();

            objusuario.Login = txtUsuario.Text;
            objusuario.Senha = txtSenha.Text;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                if ((objusuario.logar()))
                {
                    this.Hide();
                    Frm_Dashboard form = new Frm_Dashboard(objusuario.Nome, objusuario.Tipo);
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
