
namespace ProjetoHotel
{
    partial class Frm_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historico));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.cmb_historico = new System.Windows.Forms.ComboBox();
            this.lbl_historico = new System.Windows.Forms.Label();
            this.cmb_criterio = new System.Windows.Forms.ComboBox();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_atualiza_reserva = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(331, 490);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(184, 62);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_historico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Location = new System.Drawing.Point(31, 195);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.ReadOnly = true;
            this.dgv_historico.Size = new System.Drawing.Size(880, 256);
            this.dgv_historico.TabIndex = 65;
            // 
            // cmb_historico
            // 
            this.cmb_historico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_historico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_historico.FormattingEnabled = true;
            this.cmb_historico.Location = new System.Drawing.Point(224, 122);
            this.cmb_historico.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_historico.Name = "cmb_historico";
            this.cmb_historico.Size = new System.Drawing.Size(201, 36);
            this.cmb_historico.TabIndex = 107;
            this.cmb_historico.SelectedIndexChanged += new System.EventHandler(this.cmb_historico_SelectedIndexChanged);
            // 
            // lbl_historico
            // 
            this.lbl_historico.AutoSize = true;
            this.lbl_historico.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historico.Location = new System.Drawing.Point(219, 90);
            this.lbl_historico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_historico.Name = "lbl_historico";
            this.lbl_historico.Size = new System.Drawing.Size(179, 28);
            this.lbl_historico.TabIndex = 106;
            this.lbl_historico.Text = "Selecione o Histórico";
            // 
            // cmb_criterio
            // 
            this.cmb_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_criterio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_criterio.FormattingEnabled = true;
            this.cmb_criterio.Location = new System.Drawing.Point(478, 122);
            this.cmb_criterio.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_criterio.Name = "cmb_criterio";
            this.cmb_criterio.Size = new System.Drawing.Size(106, 36);
            this.cmb_criterio.TabIndex = 109;
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa.Location = new System.Drawing.Point(458, 90);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(172, 28);
            this.lbl_pesquisa.TabIndex = 108;
            this.lbl_pesquisa.Text = "Pesquisa ID Usuário";
            // 
            // btn_atualiza_reserva
            // 
            this.btn_atualiza_reserva.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualiza_reserva.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_reserva.Location = new System.Drawing.Point(646, 122);
            this.btn_atualiza_reserva.Name = "btn_atualiza_reserva";
            this.btn_atualiza_reserva.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_reserva.TabIndex = 110;
            this.btn_atualiza_reserva.UseVisualStyleBackColor = true;
            this.btn_atualiza_reserva.Click += new System.EventHandler(this.btn_atualiza_reserva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 648);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_atualiza_reserva);
            this.Controls.Add(this.cmb_criterio);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.cmb_historico);
            this.Controls.Add(this.lbl_historico);
            this.Controls.Add(this.dgv_historico);
            this.Controls.Add(this.btn_voltar);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Cartao";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.ComboBox cmb_historico;
        private System.Windows.Forms.Label lbl_historico;
        private System.Windows.Forms.ComboBox cmb_criterio;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Button btn_atualiza_reserva;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}