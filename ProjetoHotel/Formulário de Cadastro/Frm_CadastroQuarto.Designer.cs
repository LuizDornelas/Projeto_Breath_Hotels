
namespace ProjetoHotel
{
    partial class Frm_CadastroQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroQuarto));
            this.msk_camasolteiro = new System.Windows.Forms.MaskedTextBox();
            this.txt_quarto = new System.Windows.Forms.TextBox();
            this.lbl_quarto = new System.Windows.Forms.Label();
            this.lbl_camasolteiro = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_campos_obrigatorios = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.msk_camacasal = new System.Windows.Forms.MaskedTextBox();
            this.lbl_camacasal = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.msk_diaria = new System.Windows.Forms.MaskedTextBox();
            this.dgv_quartos = new System.Windows.Forms.DataGridView();
            this.btn_atualiza_dgv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_camasolteiro
            // 
            this.msk_camasolteiro.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_camasolteiro.Location = new System.Drawing.Point(112, 245);
            this.msk_camasolteiro.Margin = new System.Windows.Forms.Padding(4);
            this.msk_camasolteiro.Mask = "9";
            this.msk_camasolteiro.Name = "msk_camasolteiro";
            this.msk_camasolteiro.Size = new System.Drawing.Size(31, 37);
            this.msk_camasolteiro.TabIndex = 26;
            // 
            // txt_quarto
            // 
            this.txt_quarto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quarto.Location = new System.Drawing.Point(110, 151);
            this.txt_quarto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quarto.MaxLength = 4;
            this.txt_quarto.Multiline = true;
            this.txt_quarto.Name = "txt_quarto";
            this.txt_quarto.Size = new System.Drawing.Size(174, 31);
            this.txt_quarto.TabIndex = 24;
            // 
            // lbl_quarto
            // 
            this.lbl_quarto.AutoSize = true;
            this.lbl_quarto.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quarto.Location = new System.Drawing.Point(104, 111);
            this.lbl_quarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quarto.Name = "lbl_quarto";
            this.lbl_quarto.Size = new System.Drawing.Size(92, 36);
            this.lbl_quarto.TabIndex = 21;
            this.lbl_quarto.Text = "Quarto:";
            // 
            // lbl_camasolteiro
            // 
            this.lbl_camasolteiro.AutoSize = true;
            this.lbl_camasolteiro.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camasolteiro.Location = new System.Drawing.Point(106, 205);
            this.lbl_camasolteiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_camasolteiro.Name = "lbl_camasolteiro";
            this.lbl_camasolteiro.Size = new System.Drawing.Size(178, 36);
            this.lbl_camasolteiro.TabIndex = 20;
            this.lbl_camasolteiro.Text = "Camas Solteiro:";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(380, 111);
            this.lbl_cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(65, 36);
            this.lbl_cargo.TabIndex = 37;
            this.lbl_cargo.Text = "Tipo:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(386, 151);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(124, 44);
            this.cmb_tipo.TabIndex = 43;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.lbl_titulo.Location = new System.Drawing.Point(315, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(436, 70);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Cadastro de Quarto";
            // 
            // lbl_campos_obrigatorios
            // 
            this.lbl_campos_obrigatorios.AutoSize = true;
            this.lbl_campos_obrigatorios.Font = new System.Drawing.Font("Poppins ExtraLight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos_obrigatorios.Location = new System.Drawing.Point(492, 684);
            this.lbl_campos_obrigatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_campos_obrigatorios.Name = "lbl_campos_obrigatorios";
            this.lbl_campos_obrigatorios.Size = new System.Drawing.Size(522, 34);
            this.lbl_campos_obrigatorios.TabIndex = 45;
            this.lbl_campos_obrigatorios.Text = "* Todos os campos são de preenchimento obrigatório";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(307, 601);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(164, 63);
            this.btn_voltar.TabIndex = 58;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(571, 601);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(167, 63);
            this.btn_salvar.TabIndex = 59;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // msk_camacasal
            // 
            this.msk_camacasal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_camacasal.Location = new System.Drawing.Point(307, 245);
            this.msk_camacasal.Margin = new System.Windows.Forms.Padding(4);
            this.msk_camacasal.Mask = "9";
            this.msk_camacasal.Name = "msk_camacasal";
            this.msk_camacasal.Size = new System.Drawing.Size(31, 37);
            this.msk_camacasal.TabIndex = 61;
            // 
            // lbl_camacasal
            // 
            this.lbl_camacasal.AutoSize = true;
            this.lbl_camacasal.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camacasal.Location = new System.Drawing.Point(301, 205);
            this.lbl_camacasal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_camacasal.Name = "lbl_camacasal";
            this.lbl_camacasal.Size = new System.Drawing.Size(160, 36);
            this.lbl_camacasal.TabIndex = 60;
            this.lbl_camacasal.Text = "Camas Casal:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(492, 205);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(142, 36);
            this.lbl_valor.TabIndex = 62;
            this.lbl_valor.Text = "Valor Diária:";
            // 
            // msk_diaria
            // 
            this.msk_diaria.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_diaria.Location = new System.Drawing.Point(498, 245);
            this.msk_diaria.Margin = new System.Windows.Forms.Padding(4);
            this.msk_diaria.Mask = "999,99";
            this.msk_diaria.Name = "msk_diaria";
            this.msk_diaria.Size = new System.Drawing.Size(104, 37);
            this.msk_diaria.TabIndex = 64;
            // 
            // dgv_quartos
            // 
            this.dgv_quartos.AllowUserToAddRows = false;
            this.dgv_quartos.AllowUserToDeleteRows = false;
            this.dgv_quartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_quartos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_quartos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_quartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quartos.Location = new System.Drawing.Point(110, 322);
            this.dgv_quartos.Name = "dgv_quartos";
            this.dgv_quartos.ReadOnly = true;
            this.dgv_quartos.RowHeadersWidth = 51;
            this.dgv_quartos.Size = new System.Drawing.Size(734, 248);
            this.dgv_quartos.TabIndex = 65;
            // 
            // btn_atualiza_dgv
            // 
            this.btn_atualiza_dgv.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualiza_dgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualiza_dgv.ForeColor = System.Drawing.Color.Transparent;
            this.btn_atualiza_dgv.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualiza_dgv.Image")));
            this.btn_atualiza_dgv.Location = new System.Drawing.Point(795, 273);
            this.btn_atualiza_dgv.Name = "btn_atualiza_dgv";
            this.btn_atualiza_dgv.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_dgv.TabIndex = 82;
            this.btn_atualiza_dgv.UseVisualStyleBackColor = false;
            this.btn_atualiza_dgv.Click += new System.EventHandler(this.btn_atualiza_dgv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_CadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 743);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_atualiza_dgv);
            this.Controls.Add(this.dgv_quartos);
            this.Controls.Add(this.msk_diaria);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.msk_camacasal);
            this.Controls.Add(this.lbl_camacasal);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_campos_obrigatorios);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.msk_camasolteiro);
            this.Controls.Add(this.txt_quarto);
            this.Controls.Add(this.lbl_quarto);
            this.Controls.Add(this.lbl_camasolteiro);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_CadastroQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Quarto";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_CadastroQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_camasolteiro;
        public System.Windows.Forms.TextBox txt_quarto;
        private System.Windows.Forms.Label lbl_quarto;
        private System.Windows.Forms.Label lbl_camasolteiro;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_campos_obrigatorios;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvar;
        public System.Windows.Forms.MaskedTextBox msk_camacasal;
        private System.Windows.Forms.Label lbl_camacasal;
        private System.Windows.Forms.Label lbl_valor;
        public System.Windows.Forms.MaskedTextBox msk_diaria;
        private System.Windows.Forms.DataGridView dgv_quartos;
        private System.Windows.Forms.Button btn_atualiza_dgv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}