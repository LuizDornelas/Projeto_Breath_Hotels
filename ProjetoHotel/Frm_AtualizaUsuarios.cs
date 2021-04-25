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
    public partial class Frm_AtualizaUsuarios : Form
    {
        public Frm_AtualizaUsuarios()
        {
            InitializeComponent();

            cmb_tipo.Items.Clear();
            cmb_tipo.Items.Add("Func");
            cmb_tipo.Items.Add("Admin");
            cmb_tipo.Items.Add("Cliente");

            cmb_ativo.Items.Clear();
            cmb_ativo.Items.Add("SIM");
            cmb_ativo.Items.Add("NAO");

            cmb_criterio.Items.Clear();
            cmb_criterio.Items.Add("Id");
            cmb_criterio.Items.Add("Nome");
            cmb_criterio.Items.Add("RG");
            cmb_criterio.Items.Add("Telefone");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
