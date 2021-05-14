using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Frm_Historico : Form
    {
        public Frm_Historico()
        {
            InitializeComponent();

            cmb_historico.Items.Clear();
            cmb_historico.Items.Add("Reservas");
            cmb_historico.Items.Add("Consumo");
            cmb_historico.SelectedItem = "Reservas";            
        }
        public void attComboBox()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox;
                NpgsqlCommand cmd;

                cmb_criterio.DataSource = null;

                if (cmb_historico.Text == "Consumo")
                {
                    combobox = "SELECT DISTINCT reservafk FROM consumos order by reservafk;";

                    cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                    NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                    lbl_pesquisa.Text = "Pesquisa ID Reserva";

                    if (comboboxshow.HasRows)
                    {
                        DataTable dt = new DataTable();

                        dt.Load(comboboxshow);

                        cmb_criterio.DisplayMember = "reservafk";

                        cmb_criterio.DataSource = dt;
                    }                    
                }
                else
                {
                    combobox = "SELECT DISTINCT usuariofk FROM reservas order by usuariofk;";

                    cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                    NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                    lbl_pesquisa.Text = "Pesquisa ID Usuário";

                    if (comboboxshow.HasRows)
                    {
                        DataTable dt = new DataTable();

                        dt.Load(comboboxshow);

                        cmb_criterio.DisplayMember = "usuariofk";

                        cmb_criterio.DataSource = dt;
                    }                                      
                }                                          
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void Frm_Historico_Load(object sender, EventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_historico_SelectedIndexChanged(object sender, EventArgs e)
        {
            attComboBox();
        }
        private void btn_atualiza_reserva_Click(object sender, EventArgs e)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();
                string datagrid;
                NpgsqlCommand cmd;

                if (cmb_historico.Text == "Consumo")
                {
                    datagrid = "select item, valor, quantidade, data from consumos where reservafk = '" + cmb_criterio.Text + "';";               
                    cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                    NpgsqlDataReader dgv = cmd.ExecuteReader();

                    if (dgv.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dgv);
                        dgv_historico.DataSource = dt;
                    }
                    else
                    {
                        dgv_historico.DataSource = null;
                    }
                }
                else
                {
                    datagrid = "select reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status from reservas where usuariofk = '" + cmb_criterio.Text + "';";                
                    cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                    NpgsqlDataReader dgv = cmd.ExecuteReader();

                    if (dgv.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dgv);
                        dgv_historico.DataSource = dt;
                    }
                    else
                    {
                        dgv_historico.DataSource = null;
                    }
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }        
    }
}
