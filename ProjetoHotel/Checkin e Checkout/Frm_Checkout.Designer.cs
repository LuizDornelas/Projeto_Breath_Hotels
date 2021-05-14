
namespace ProjetoHotel
{
    partial class Frm_Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Checkout));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_reservas = new System.Windows.Forms.DataGridView();
            this.lbl_reservas = new System.Windows.Forms.Label();
            this.lbl_quarto = new System.Windows.Forms.Label();
            this.lbl_saida = new System.Windows.Forms.Label();
            this.lbl_entrada = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.msk_total = new System.Windows.Forms.MaskedTextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_atualiza_reserva = new System.Windows.Forms.Button();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.txt_saida = new System.Windows.Forms.TextBox();
            this.txt_quarto = new System.Windows.Forms.TextBox();
            this.cmb_quarto = new System.Windows.Forms.ComboBox();
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.lbl_itens = new System.Windows.Forms.Label();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.cmb_pagamento = new System.Windows.Forms.ComboBox();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(101, 183);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(438, 31);
            this.txt_nome.TabIndex = 24;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(96, 154);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(162, 25);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome do cliente";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(475, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(172, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Checkout";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(448, 764);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_reservas
            // 
            this.dgv_reservas.AllowUserToAddRows = false;
            this.dgv_reservas.AllowUserToDeleteRows = false;
            this.dgv_reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_reservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservas.Location = new System.Drawing.Point(101, 559);
            this.dgv_reservas.Name = "dgv_reservas";
            this.dgv_reservas.ReadOnly = true;
            this.dgv_reservas.Size = new System.Drawing.Size(880, 176);
            this.dgv_reservas.TabIndex = 64;
            // 
            // lbl_reservas
            // 
            this.lbl_reservas.AutoSize = true;
            this.lbl_reservas.Location = new System.Drawing.Point(104, 531);
            this.lbl_reservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reservas.Name = "lbl_reservas";
            this.lbl_reservas.Size = new System.Drawing.Size(239, 25);
            this.lbl_reservas.TabIndex = 70;
            this.lbl_reservas.Text = "Reservas em andamento";
            // 
            // lbl_quarto
            // 
            this.lbl_quarto.AutoSize = true;
            this.lbl_quarto.Location = new System.Drawing.Point(867, 154);
            this.lbl_quarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quarto.Name = "lbl_quarto";
            this.lbl_quarto.Size = new System.Drawing.Size(78, 25);
            this.lbl_quarto.TabIndex = 72;
            this.lbl_quarto.Text = "Quarto";
            // 
            // lbl_saida
            // 
            this.lbl_saida.AutoSize = true;
            this.lbl_saida.Location = new System.Drawing.Point(713, 154);
            this.lbl_saida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saida.Name = "lbl_saida";
            this.lbl_saida.Size = new System.Drawing.Size(64, 25);
            this.lbl_saida.TabIndex = 75;
            this.lbl_saida.Text = "Saida";
            // 
            // lbl_entrada
            // 
            this.lbl_entrada.AutoSize = true;
            this.lbl_entrada.Location = new System.Drawing.Point(559, 154);
            this.lbl_entrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entrada.Name = "lbl_entrada";
            this.lbl_entrada.Size = new System.Drawing.Size(88, 25);
            this.lbl_entrada.TabIndex = 76;
            this.lbl_entrada.Text = "Entrada";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(472, 249);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(204, 55);
            this.btn_finalizar.TabIndex = 78;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // msk_total
            // 
            this.msk_total.Location = new System.Drawing.Point(101, 261);
            this.msk_total.Margin = new System.Windows.Forms.Padding(4);
            this.msk_total.Name = "msk_total";
            this.msk_total.ReadOnly = true;
            this.msk_total.Size = new System.Drawing.Size(148, 31);
            this.msk_total.TabIndex = 79;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(96, 232);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 25);
            this.lbl_total.TabIndex = 80;
            this.lbl_total.Text = "Total";
            // 
            // btn_atualiza_reserva
            // 
            this.btn_atualiza_reserva.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_reserva.Location = new System.Drawing.Point(987, 559);
            this.btn_atualiza_reserva.Name = "btn_atualiza_reserva";
            this.btn_atualiza_reserva.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_reserva.TabIndex = 81;
            this.btn_atualiza_reserva.UseVisualStyleBackColor = true;
            this.btn_atualiza_reserva.Click += new System.EventHandler(this.btn_atualiza_reserva_Click);
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(564, 183);
            this.txt_entrada.Margin = new System.Windows.Forms.Padding(4);
            this.txt_entrada.MaxLength = 50;
            this.txt_entrada.Multiline = true;
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.ReadOnly = true;
            this.txt_entrada.Size = new System.Drawing.Size(129, 31);
            this.txt_entrada.TabIndex = 82;
            // 
            // txt_saida
            // 
            this.txt_saida.Location = new System.Drawing.Point(718, 183);
            this.txt_saida.Margin = new System.Windows.Forms.Padding(4);
            this.txt_saida.MaxLength = 50;
            this.txt_saida.Multiline = true;
            this.txt_saida.Name = "txt_saida";
            this.txt_saida.ReadOnly = true;
            this.txt_saida.Size = new System.Drawing.Size(129, 31);
            this.txt_saida.TabIndex = 83;
            // 
            // txt_quarto
            // 
            this.txt_quarto.Location = new System.Drawing.Point(872, 183);
            this.txt_quarto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quarto.MaxLength = 50;
            this.txt_quarto.Multiline = true;
            this.txt_quarto.Name = "txt_quarto";
            this.txt_quarto.ReadOnly = true;
            this.txt_quarto.Size = new System.Drawing.Size(129, 31);
            this.txt_quarto.TabIndex = 84;
            // 
            // cmb_quarto
            // 
            this.cmb_quarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quarto.FormattingEnabled = true;
            this.cmb_quarto.Location = new System.Drawing.Point(265, 104);
            this.cmb_quarto.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_quarto.Name = "cmb_quarto";
            this.cmb_quarto.Size = new System.Drawing.Size(124, 33);
            this.cmb_quarto.TabIndex = 85;
            this.cmb_quarto.SelectedIndexChanged += new System.EventHandler(this.cmb_criterio_SelectedIndexChanged);
            // 
            // lbl_criterio
            // 
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Location = new System.Drawing.Point(96, 107);
            this.lbl_criterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(171, 25);
            this.lbl_criterio.TabIndex = 86;
            this.lbl_criterio.Text = "Seleciona Quarto";
            // 
            // lbl_itens
            // 
            this.lbl_itens.AutoSize = true;
            this.lbl_itens.Location = new System.Drawing.Point(104, 324);
            this.lbl_itens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itens.Name = "lbl_itens";
            this.lbl_itens.Size = new System.Drawing.Size(177, 25);
            this.lbl_itens.TabIndex = 88;
            this.lbl_itens.Text = "Itens Consumidos";
            // 
            // dgv_itens
            // 
            this.dgv_itens.AllowUserToAddRows = false;
            this.dgv_itens.AllowUserToDeleteRows = false;
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(101, 352);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.ReadOnly = true;
            this.dgv_itens.Size = new System.Drawing.Size(880, 176);
            this.dgv_itens.TabIndex = 87;
            // 
            // cmb_pagamento
            // 
            this.cmb_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pagamento.FormattingEnabled = true;
            this.cmb_pagamento.Location = new System.Drawing.Point(275, 261);
            this.cmb_pagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pagamento.Name = "cmb_pagamento";
            this.cmb_pagamento.Size = new System.Drawing.Size(180, 33);
            this.cmb_pagamento.TabIndex = 89;
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Location = new System.Drawing.Point(271, 232);
            this.lbl_pagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(194, 25);
            this.lbl_pagamento.TabIndex = 90;
            this.lbl_pagamento.Text = "Meio de pagamento";
            // 
            // Frm_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 834);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_pagamento);
            this.Controls.Add(this.cmb_pagamento);
            this.Controls.Add(this.lbl_itens);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.lbl_criterio);
            this.Controls.Add(this.cmb_quarto);
            this.Controls.Add(this.txt_quarto);
            this.Controls.Add(this.txt_saida);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.btn_atualiza_reserva);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.msk_total);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lbl_entrada);
            this.Controls.Add(this.lbl_saida);
            this.Controls.Add(this.lbl_quarto);
            this.Controls.Add(this.lbl_reservas);
            this.Controls.Add(this.dgv_reservas);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Checkout";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_reservas;
        private System.Windows.Forms.Label lbl_reservas;
        private System.Windows.Forms.Label lbl_quarto;
        private System.Windows.Forms.Label lbl_saida;
        private System.Windows.Forms.Label lbl_entrada;
        private System.Windows.Forms.Button btn_finalizar;
        public System.Windows.Forms.MaskedTextBox msk_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_atualiza_reserva;
        public System.Windows.Forms.TextBox txt_entrada;
        public System.Windows.Forms.TextBox txt_saida;
        public System.Windows.Forms.TextBox txt_quarto;
        private System.Windows.Forms.ComboBox cmb_quarto;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.Label lbl_itens;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.ComboBox cmb_pagamento;
        private System.Windows.Forms.Label lbl_pagamento;
    }
}