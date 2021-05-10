﻿using System;
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
    public partial class Frm_Pgto_Dinheiro : Form
    {
        double total;
        double recebido;
        string id;
        public Frm_Pgto_Dinheiro(string idd, string total)
        {
            InitializeComponent();
            txt_total.Text = $"R${total}";
            id = idd;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_valor_pago_TextChanged(object sender, EventArgs e)
        {
            total = Convert.ToDouble(txt_total.Text.Replace("R$", "").Trim());

            recebido = Convert.ToDouble(txt_valor_pago.Text);

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
                    pagamento.pgto_dinheiro_cartao(id);
                    MessageBox.Show($"Pagamento realizado com sucesso, seu troco é R${txt_troco.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}