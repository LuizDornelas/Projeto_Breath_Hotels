namespace ProjetoHotel
{
    partial class Frm_cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cargo));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_cargos = new System.Windows.Forms.TextBox();
            this.lbl_cargos = new System.Windows.Forms.Label();
            this.dgv_cargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.Location = new System.Drawing.Point(188, 415);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(70, 75);
            this.btn_adicionar.TabIndex = 68;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_sair.Location = new System.Drawing.Point(555, 419);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 71);
            this.btn_sair.TabIndex = 67;
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(426, 419);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 71);
            this.btn_salvar.TabIndex = 66;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editar.Location = new System.Drawing.Point(303, 417);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 71);
            this.btn_editar.TabIndex = 65;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // txt_cargos
            // 
            this.txt_cargos.Location = new System.Drawing.Point(303, 42);
            this.txt_cargos.Name = "txt_cargos";
            this.txt_cargos.Size = new System.Drawing.Size(178, 22);
            this.txt_cargos.TabIndex = 64;
            // 
            // lbl_cargos
            // 
            this.lbl_cargos.AutoSize = true;
            this.lbl_cargos.Location = new System.Drawing.Point(230, 45);
            this.lbl_cargos.Name = "lbl_cargos";
            this.lbl_cargos.Size = new System.Drawing.Size(61, 17);
            this.lbl_cargos.TabIndex = 63;
            this.lbl_cargos.Text = "Cargos: ";
            // 
            // dgv_cargos
            // 
            this.dgv_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargos.Location = new System.Drawing.Point(73, 149);
            this.dgv_cargos.Name = "dgv_cargos";
            this.dgv_cargos.RowHeadersWidth = 51;
            this.dgv_cargos.RowTemplate.Height = 24;
            this.dgv_cargos.Size = new System.Drawing.Size(654, 229);
            this.dgv_cargos.TabIndex = 62;
            // 
            // Frm_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_cargos);
            this.Controls.Add(this.lbl_cargos);
            this.Controls.Add(this.dgv_cargos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_cargo";
            this.Text = "Cadastro dos Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        public System.Windows.Forms.TextBox txt_cargos;
        private System.Windows.Forms.Label lbl_cargos;
        private System.Windows.Forms.DataGridView dgv_cargos;
    }
}