
namespace ProjetoHotel
{
    partial class Frm_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estoque));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_itens = new System.Windows.Forms.Label();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.msk_quantidade = new System.Windows.Forms.MaskedTextBox();
            this.cmb_itens = new System.Windows.Forms.ComboBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_atualiza_reserva = new System.Windows.Forms.Button();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_qnt_disponivel = new System.Windows.Forms.TextBox();
            this.lbl_qnt_itens = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.lbl_titulo.Location = new System.Drawing.Point(371, 9);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(194, 70);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Estoque";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(384, 102);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(136, 36);
            this.lbl_fornecedor.TabIndex = 59;
            this.lbl_fornecedor.Text = "Fornecedor:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(219, 624);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 67);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.Color.White;
            this.btn_comprar.Location = new System.Drawing.Point(497, 624);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(204, 67);
            this.btn_comprar.TabIndex = 78;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_itens
            // 
            this.lbl_itens.AutoSize = true;
            this.lbl_itens.Location = new System.Drawing.Point(63, 323);
            this.lbl_itens.Name = "lbl_itens";
            this.lbl_itens.Size = new System.Drawing.Size(188, 36);
            this.lbl_itens.TabIndex = 88;
            this.lbl_itens.Text = "Itens Disponíveis";
            // 
            // dgv_itens
            // 
            this.dgv_itens.AllowUserToAddRows = false;
            this.dgv_itens.AllowUserToDeleteRows = false;
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(69, 362);
            this.dgv_itens.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.ReadOnly = true;
            this.dgv_itens.RowHeadersWidth = 51;
            this.dgv_itens.Size = new System.Drawing.Size(764, 239);
            this.dgv_itens.TabIndex = 87;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(240, 147);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_valor.MaxLength = 50;
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(90, 36);
            this.txt_valor.TabIndex = 89;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(234, 102);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(127, 36);
            this.lbl_valor.TabIndex = 90;
            this.lbl_valor.Text = "Valor Item:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(63, 221);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(231, 36);
            this.lbl_quantidade.TabIndex = 91;
            this.lbl_quantidade.Text = "Quantidade compra:";
            // 
            // msk_quantidade
            // 
            this.msk_quantidade.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_quantidade.Location = new System.Drawing.Point(69, 259);
            this.msk_quantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msk_quantidade.Mask = "999";
            this.msk_quantidade.Name = "msk_quantidade";
            this.msk_quantidade.Size = new System.Drawing.Size(41, 37);
            this.msk_quantidade.TabIndex = 93;
            // 
            // cmb_itens
            // 
            this.cmb_itens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_itens.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itens.FormattingEnabled = true;
            this.cmb_itens.Location = new System.Drawing.Point(69, 147);
            this.cmb_itens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_itens.Name = "cmb_itens";
            this.cmb_itens.Size = new System.Drawing.Size(145, 44);
            this.cmb_itens.TabIndex = 94;
            this.cmb_itens.SelectedIndexChanged += new System.EventHandler(this.cmb_itens_SelectedIndexChanged);
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(63, 102);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(67, 36);
            this.lbl_item.TabIndex = 95;
            this.lbl_item.Text = "Item:";
            // 
            // btn_atualiza_reserva
            // 
            this.btn_atualiza_reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualiza_reserva.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualiza_reserva.Image")));
            this.btn_atualiza_reserva.Location = new System.Drawing.Point(783, 305);
            this.btn_atualiza_reserva.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_atualiza_reserva.Name = "btn_atualiza_reserva";
            this.btn_atualiza_reserva.Size = new System.Drawing.Size(50, 51);
            this.btn_atualiza_reserva.TabIndex = 81;
            this.btn_atualiza_reserva.UseVisualStyleBackColor = true;
            this.btn_atualiza_reserva.Click += new System.EventHandler(this.btn_atualiza_reserva_Click);
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fornecedor.Location = new System.Drawing.Point(390, 147);
            this.txt_fornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_fornecedor.MaxLength = 50;
            this.txt_fornecedor.Multiline = true;
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.ReadOnly = true;
            this.txt_fornecedor.Size = new System.Drawing.Size(284, 36);
            this.txt_fornecedor.TabIndex = 96;
            // 
            // txt_qnt_disponivel
            // 
            this.txt_qnt_disponivel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qnt_disponivel.Location = new System.Drawing.Point(352, 259);
            this.txt_qnt_disponivel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_qnt_disponivel.MaxLength = 50;
            this.txt_qnt_disponivel.Multiline = true;
            this.txt_qnt_disponivel.Name = "txt_qnt_disponivel";
            this.txt_qnt_disponivel.ReadOnly = true;
            this.txt_qnt_disponivel.Size = new System.Drawing.Size(59, 36);
            this.txt_qnt_disponivel.TabIndex = 97;
            // 
            // lbl_qnt_itens
            // 
            this.lbl_qnt_itens.AutoSize = true;
            this.lbl_qnt_itens.Location = new System.Drawing.Point(346, 221);
            this.lbl_qnt_itens.Name = "lbl_qnt_itens";
            this.lbl_qnt_itens.Size = new System.Drawing.Size(204, 36);
            this.lbl_qnt_itens.TabIndex = 98;
            this.lbl_qnt_itens.Text = "Quantidade atual:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 726);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_qnt_itens);
            this.Controls.Add(this.txt_qnt_disponivel);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.cmb_itens);
            this.Controls.Add(this.msk_quantidade);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_itens);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.btn_atualiza_reserva);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estoque";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_atualiza_reserva;
        private System.Windows.Forms.Label lbl_itens;
        private System.Windows.Forms.DataGridView dgv_itens;
        public System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_quantidade;
        public System.Windows.Forms.MaskedTextBox msk_quantidade;
        private System.Windows.Forms.ComboBox cmb_itens;
        private System.Windows.Forms.Label lbl_item;
        public System.Windows.Forms.TextBox txt_fornecedor;
        public System.Windows.Forms.TextBox txt_qnt_disponivel;
        private System.Windows.Forms.Label lbl_qnt_itens;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}