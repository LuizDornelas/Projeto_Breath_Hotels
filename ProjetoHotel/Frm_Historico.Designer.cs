
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(431, 423);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_historico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Location = new System.Drawing.Point(106, 138);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.ReadOnly = true;
            this.dgv_historico.Size = new System.Drawing.Size(880, 256);
            this.dgv_historico.TabIndex = 65;
            // 
            // cmb_historico
            // 
            this.cmb_historico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_historico.FormattingEnabled = true;
            this.cmb_historico.Location = new System.Drawing.Point(106, 87);
            this.cmb_historico.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_historico.Name = "cmb_historico";
            this.cmb_historico.Size = new System.Drawing.Size(201, 33);
            this.cmb_historico.TabIndex = 107;
            this.cmb_historico.SelectedIndexChanged += new System.EventHandler(this.cmb_historico_SelectedIndexChanged);
            // 
            // lbl_historico
            // 
            this.lbl_historico.AutoSize = true;
            this.lbl_historico.Location = new System.Drawing.Point(101, 58);
            this.lbl_historico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_historico.Name = "lbl_historico";
            this.lbl_historico.Size = new System.Drawing.Size(206, 25);
            this.lbl_historico.TabIndex = 106;
            this.lbl_historico.Text = "Selecione o Histórico";
            // 
            // cmb_criterio
            // 
            this.cmb_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_criterio.FormattingEnabled = true;
            this.cmb_criterio.Location = new System.Drawing.Point(353, 87);
            this.cmb_criterio.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_criterio.Name = "cmb_criterio";
            this.cmb_criterio.Size = new System.Drawing.Size(106, 33);
            this.cmb_criterio.TabIndex = 109;
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(336, 58);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(202, 25);
            this.lbl_pesquisa.TabIndex = 108;
            this.lbl_pesquisa.Text = "Pesquisa ID Usuário";
            // 
            // btn_atualiza_reserva
            // 
            this.btn_atualiza_reserva.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_reserva.Location = new System.Drawing.Point(488, 81);
            this.btn_atualiza_reserva.Name = "btn_atualiza_reserva";
            this.btn_atualiza_reserva.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_reserva.TabIndex = 110;
            this.btn_atualiza_reserva.UseVisualStyleBackColor = true;
            this.btn_atualiza_reserva.Click += new System.EventHandler(this.btn_atualiza_reserva_Click);
            // 
            // Frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 520);
            this.ControlBox = false;
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
    }
}