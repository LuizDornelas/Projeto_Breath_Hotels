﻿
namespace ProjetoHotel
{
    partial class Frm_Pgto_Dinheiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_valor_pago = new System.Windows.Forms.TextBox();
            this.lbl_valor_pago = new System.Windows.Forms.Label();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(142, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(423, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Pagamento por Dinheiro";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(69, 338);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(460, 338);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(204, 55);
            this.btn_pagar.TabIndex = 78;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(286, 86);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 25);
            this.lbl_total.TabIndex = 80;
            this.lbl_total.Text = "Total";
            // 
            // txt_valor_pago
            // 
            this.txt_valor_pago.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_valor_pago.Location = new System.Drawing.Point(291, 195);
            this.txt_valor_pago.Name = "txt_valor_pago";
            this.txt_valor_pago.Size = new System.Drawing.Size(148, 31);
            this.txt_valor_pago.TabIndex = 81;
            this.txt_valor_pago.TextChanged += new System.EventHandler(this.txt_valor_pago_TextChanged);
            // 
            // lbl_valor_pago
            // 
            this.lbl_valor_pago.AutoSize = true;
            this.lbl_valor_pago.Location = new System.Drawing.Point(286, 167);
            this.lbl_valor_pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor_pago.Name = "lbl_valor_pago";
            this.lbl_valor_pago.Size = new System.Drawing.Size(113, 25);
            this.lbl_valor_pago.TabIndex = 82;
            this.lbl_valor_pago.Text = "Valor pago";
            // 
            // txt_troco
            // 
            this.txt_troco.Location = new System.Drawing.Point(291, 277);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.ReadOnly = true;
            this.txt_troco.Size = new System.Drawing.Size(148, 31);
            this.txt_troco.TabIndex = 83;
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.Location = new System.Drawing.Point(286, 249);
            this.lbl_troco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(66, 25);
            this.lbl_troco.TabIndex = 84;
            this.lbl_troco.Text = "Troco";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(291, 114);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(148, 31);
            this.txt_total.TabIndex = 85;
            // 
            // Frm_Pgto_Dinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 423);
            this.ControlBox = false;
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_troco);
            this.Controls.Add(this.txt_troco);
            this.Controls.Add(this.lbl_valor_pago);
            this.Controls.Add(this.txt_valor_pago);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Pgto_Dinheiro";
            this.Text = "Pagamento";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_valor_pago;
        private System.Windows.Forms.Label lbl_valor_pago;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.TextBox txt_total;
    }
}