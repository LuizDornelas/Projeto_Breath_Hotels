
namespace ProjetoHotel
{
    partial class Frm_Checkin
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
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_reservas = new System.Windows.Forms.DataGridView();
            this.msk_pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.msk_valor = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_reservas = new System.Windows.Forms.Label();
            this.cmb_quarto = new System.Windows.Forms.ComboBox();
            this.lbl_quarto = new System.Windows.Forms.Label();
            this.dtp_entrada = new System.Windows.Forms.DateTimePicker();
            this.dtp_saida = new System.Windows.Forms.DateTimePicker();
            this.lbl_saida = new System.Windows.Forms.Label();
            this.lbl_entrada = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.msk_total = new System.Windows.Forms.MaskedTextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_atualiza_reserva = new System.Windows.Forms.Button();
            this.txt_cama_solteiro = new System.Windows.Forms.TextBox();
            this.txt_solteiro_casal = new System.Windows.Forms.TextBox();
            this.lbl_solteiro = new System.Windows.Forms.Label();
            this.lbl_casal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(797, 183);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.msk_telefone.Mask = "(99)00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.ReadOnly = true;
            this.msk_telefone.Size = new System.Drawing.Size(184, 31);
            this.msk_telefone.TabIndex = 26;
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
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(588, 183);
            this.msk_rg.Margin = new System.Windows.Forms.Padding(4);
            this.msk_rg.Mask = "99,999,999-9";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.ReadOnly = true;
            this.msk_rg.Size = new System.Drawing.Size(148, 31);
            this.msk_rg.TabIndex = 23;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(583, 154);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(42, 25);
            this.lbl_cpf.TabIndex = 22;
            this.lbl_cpf.Text = "RG";
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
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(792, 154);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(91, 25);
            this.lbl_telefone.TabIndex = 20;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(475, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(150, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Checkin";
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(104, 107);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(132, 25);
            this.lbl_pesquisa.TabIndex = 59;
            this.lbl_pesquisa.Text = "Pesquisar ID";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(448, 645);
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
            this.dgv_reservas.Location = new System.Drawing.Point(101, 447);
            this.dgv_reservas.Name = "dgv_reservas";
            this.dgv_reservas.ReadOnly = true;
            this.dgv_reservas.Size = new System.Drawing.Size(880, 176);
            this.dgv_reservas.TabIndex = 64;
            // 
            // msk_pesquisa
            // 
            this.msk_pesquisa.Location = new System.Drawing.Point(233, 103);
            this.msk_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.msk_pesquisa.Mask = "99999";
            this.msk_pesquisa.Name = "msk_pesquisa";
            this.msk_pesquisa.Size = new System.Drawing.Size(84, 31);
            this.msk_pesquisa.TabIndex = 67;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_pesquisa.Location = new System.Drawing.Point(324, 98);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(41, 43);
            this.btn_pesquisa.TabIndex = 66;
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // msk_valor
            // 
            this.msk_valor.Location = new System.Drawing.Point(797, 263);
            this.msk_valor.Margin = new System.Windows.Forms.Padding(4);
            this.msk_valor.Name = "msk_valor";
            this.msk_valor.ReadOnly = true;
            this.msk_valor.Size = new System.Drawing.Size(148, 31);
            this.msk_valor.TabIndex = 68;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(792, 234);
            this.lbl_Valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(127, 25);
            this.lbl_Valor.TabIndex = 69;
            this.lbl_Valor.Text = "Valor Diária";
            // 
            // lbl_reservas
            // 
            this.lbl_reservas.AutoSize = true;
            this.lbl_reservas.Location = new System.Drawing.Point(104, 419);
            this.lbl_reservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reservas.Name = "lbl_reservas";
            this.lbl_reservas.Size = new System.Drawing.Size(239, 25);
            this.lbl_reservas.TabIndex = 70;
            this.lbl_reservas.Text = "Reservas em andamento";
            // 
            // cmb_quarto
            // 
            this.cmb_quarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quarto.FormattingEnabled = true;
            this.cmb_quarto.Location = new System.Drawing.Point(588, 261);
            this.cmb_quarto.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_quarto.Name = "cmb_quarto";
            this.cmb_quarto.Size = new System.Drawing.Size(124, 33);
            this.cmb_quarto.TabIndex = 71;
            this.cmb_quarto.SelectedIndexChanged += new System.EventHandler(this.cmb_quarto_SelectedIndexChanged);
            this.cmb_quarto.TextChanged += new System.EventHandler(this.cmb_quarto_TextChanged);
            // 
            // lbl_quarto
            // 
            this.lbl_quarto.AutoSize = true;
            this.lbl_quarto.Location = new System.Drawing.Point(583, 234);
            this.lbl_quarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quarto.Name = "lbl_quarto";
            this.lbl_quarto.Size = new System.Drawing.Size(78, 25);
            this.lbl_quarto.TabIndex = 72;
            this.lbl_quarto.Text = "Quarto";
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_entrada.Location = new System.Drawing.Point(101, 259);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(157, 21);
            this.dtp_entrada.TabIndex = 73;
            // 
            // dtp_saida
            // 
            this.dtp_saida.Font = new System.Drawing.Font("Arial", 9F);
            this.dtp_saida.Location = new System.Drawing.Point(308, 259);
            this.dtp_saida.Name = "dtp_saida";
            this.dtp_saida.Size = new System.Drawing.Size(157, 21);
            this.dtp_saida.TabIndex = 74;
            // 
            // lbl_saida
            // 
            this.lbl_saida.AutoSize = true;
            this.lbl_saida.Location = new System.Drawing.Point(303, 234);
            this.lbl_saida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saida.Name = "lbl_saida";
            this.lbl_saida.Size = new System.Drawing.Size(64, 25);
            this.lbl_saida.TabIndex = 75;
            this.lbl_saida.Text = "Saida";
            // 
            // lbl_entrada
            // 
            this.lbl_entrada.AutoSize = true;
            this.lbl_entrada.Location = new System.Drawing.Point(96, 234);
            this.lbl_entrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entrada.Name = "lbl_entrada";
            this.lbl_entrada.Size = new System.Drawing.Size(88, 25);
            this.lbl_entrada.TabIndex = 76;
            this.lbl_entrada.Text = "Entrada";
            // 
            // btn_total
            // 
            this.btn_total.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_total.Location = new System.Drawing.Point(266, 317);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(41, 43);
            this.btn_total.TabIndex = 77;
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_reserva
            // 
            this.btn_reserva.Location = new System.Drawing.Point(335, 311);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(204, 55);
            this.btn_reserva.TabIndex = 78;
            this.btn_reserva.Text = "Reservar";
            this.btn_reserva.UseVisualStyleBackColor = true;
            this.btn_reserva.Click += new System.EventHandler(this.button2_Click);
            // 
            // msk_total
            // 
            this.msk_total.Location = new System.Drawing.Point(101, 323);
            this.msk_total.Margin = new System.Windows.Forms.Padding(4);
            this.msk_total.Name = "msk_total";
            this.msk_total.ReadOnly = true;
            this.msk_total.Size = new System.Drawing.Size(148, 31);
            this.msk_total.TabIndex = 79;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(96, 294);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(134, 25);
            this.lbl_total.TabIndex = 80;
            this.lbl_total.Text = "Calcula Total";
            // 
            // btn_atualiza_reserva
            // 
            this.btn_atualiza_reserva.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_reserva.Location = new System.Drawing.Point(987, 447);
            this.btn_atualiza_reserva.Name = "btn_atualiza_reserva";
            this.btn_atualiza_reserva.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_reserva.TabIndex = 81;
            this.btn_atualiza_reserva.UseVisualStyleBackColor = true;
            this.btn_atualiza_reserva.Click += new System.EventHandler(this.btn_atualiza_reserva_Click);
            // 
            // txt_cama_solteiro
            // 
            this.txt_cama_solteiro.Location = new System.Drawing.Point(588, 329);
            this.txt_cama_solteiro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cama_solteiro.MaxLength = 50;
            this.txt_cama_solteiro.Multiline = true;
            this.txt_cama_solteiro.Name = "txt_cama_solteiro";
            this.txt_cama_solteiro.ReadOnly = true;
            this.txt_cama_solteiro.Size = new System.Drawing.Size(129, 31);
            this.txt_cama_solteiro.TabIndex = 82;
            // 
            // txt_solteiro_casal
            // 
            this.txt_solteiro_casal.Location = new System.Drawing.Point(797, 329);
            this.txt_solteiro_casal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_solteiro_casal.MaxLength = 50;
            this.txt_solteiro_casal.Multiline = true;
            this.txt_solteiro_casal.Name = "txt_solteiro_casal";
            this.txt_solteiro_casal.ReadOnly = true;
            this.txt_solteiro_casal.Size = new System.Drawing.Size(129, 31);
            this.txt_solteiro_casal.TabIndex = 83;
            // 
            // lbl_solteiro
            // 
            this.lbl_solteiro.AutoSize = true;
            this.lbl_solteiro.Location = new System.Drawing.Point(583, 300);
            this.lbl_solteiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_solteiro.Name = "lbl_solteiro";
            this.lbl_solteiro.Size = new System.Drawing.Size(149, 25);
            this.lbl_solteiro.TabIndex = 84;
            this.lbl_solteiro.Text = "Camas solteiro";
            // 
            // lbl_casal
            // 
            this.lbl_casal.AutoSize = true;
            this.lbl_casal.Location = new System.Drawing.Point(792, 300);
            this.lbl_casal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_casal.Name = "lbl_casal";
            this.lbl_casal.Size = new System.Drawing.Size(127, 25);
            this.lbl_casal.TabIndex = 85;
            this.lbl_casal.Text = "Camas casal";
            // 
            // Frm_Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 708);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_casal);
            this.Controls.Add(this.lbl_solteiro);
            this.Controls.Add(this.txt_solteiro_casal);
            this.Controls.Add(this.txt_cama_solteiro);
            this.Controls.Add(this.btn_atualiza_reserva);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.msk_total);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.lbl_entrada);
            this.Controls.Add(this.lbl_saida);
            this.Controls.Add(this.dtp_saida);
            this.Controls.Add(this.dtp_entrada);
            this.Controls.Add(this.lbl_quarto);
            this.Controls.Add(this.cmb_quarto);
            this.Controls.Add(this.lbl_reservas);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.msk_valor);
            this.Controls.Add(this.msk_pesquisa);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.dgv_reservas);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Checkin";
            this.Text = "Checkin";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_telefone;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_reservas;
        private System.Windows.Forms.Button btn_pesquisa;
        public System.Windows.Forms.MaskedTextBox msk_pesquisa;
        public System.Windows.Forms.MaskedTextBox msk_valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_reservas;
        private System.Windows.Forms.ComboBox cmb_quarto;
        private System.Windows.Forms.Label lbl_quarto;
        private System.Windows.Forms.DateTimePicker dtp_entrada;
        private System.Windows.Forms.DateTimePicker dtp_saida;
        private System.Windows.Forms.Label lbl_saida;
        private System.Windows.Forms.Label lbl_entrada;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_reserva;
        public System.Windows.Forms.MaskedTextBox msk_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_atualiza_reserva;
        public System.Windows.Forms.TextBox txt_cama_solteiro;
        public System.Windows.Forms.TextBox txt_solteiro_casal;
        private System.Windows.Forms.Label lbl_solteiro;
        private System.Windows.Forms.Label lbl_casal;
    }
}