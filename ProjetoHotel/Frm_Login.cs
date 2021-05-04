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

            if (objusuario.logar())
            {
                this.Hide();
                Frm_Dashboard form = new Frm_Dashboard(objusuario.Login, objusuario.Tipo);
                form.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Usuário e senha divergentes, ou desativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
