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
    public partial class Frm_Pgto_Dinheiro : Form
    {
        double total;
        double recebido;
        string id;
        string quarto;
        public Frm_Pgto_Dinheiro(string idd, string total, string quartoo)
        {
            InitializeComponent();
            txt_total.Text = $"R${total}";
            id = idd;
            quarto = quartoo;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_valor_pago_TextChanged(object sender, EventArgs e)
        {
            total = Convert.ToDouble(txt_total.Text.Replace("R$", "").Trim());

            recebido = Convert.ToDouble(txt_valor_pago.Text.Replace(".", ","));

            if (recebido > total)
            {
                double troco = recebido - total;

                txt_troco.Text = Convert.ToString($"{troco:f2}");
            }
            else
            {
                txt_troco.Text = "0";
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (txt_valor_pago.Text == "")
            {
                MessageBox.Show("Insira o valor a ser pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                total = Convert.ToDouble(txt_total.Text.Replace("R$", "").Trim());

                recebido = Convert.ToDouble(txt_valor_pago.Text);

                if (recebido < total)
                {
                    MessageBox.Show("Valor menor do que total!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cls_Checkin_Checkout pagamento = new Cls_Checkin_Checkout();                           
                    pagamento.pgto_dinheiro_cartao(id, txt_total.Text.Replace("R$", "").Replace(",", ".").Trim(), quarto);   
                    if (txt_troco.Text == "0")
                    {
                        MessageBox.Show($"Pagamento realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Pagamento realizado com sucesso, seu troco é R${txt_troco.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }                                        
                }
            }
        }

        private void Frm_Pgto_Dinheiro_Load(object sender, EventArgs e)
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

        private void txt_valor_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_valor_pago.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}