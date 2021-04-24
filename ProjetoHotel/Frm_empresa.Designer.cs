namespace ProjetoHotel
{
    partial class Frm_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_empresa));
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dvg_quartos = new System.Windows.Forms.DataGridView();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_quartos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(183, 168);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(280, 22);
            this.txt_tipo.TabIndex = 82;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(132, 168);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(40, 17);
            this.lbl_tipo.TabIndex = 81;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.Location = new System.Drawing.Point(218, 500);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(70, 75);
            this.btn_adicionar.TabIndex = 79;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_sair.Location = new System.Drawing.Point(592, 502);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 71);
            this.btn_sair.TabIndex = 78;
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(472, 500);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 71);
            this.btn_salvar.TabIndex = 77;
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
            this.btn_editar.Location = new System.Drawing.Point(343, 502);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 71);
            this.btn_editar.TabIndex = 76;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(183, 45);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(280, 22);
            this.txt_pesquisar.TabIndex = 72;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(132, 48);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 17);
            this.lbl_nome.TabIndex = 71;
            this.lbl_nome.Text = "Nome: ";
            // 
            // dvg_quartos
            // 
            this.dvg_quartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_quartos.Location = new System.Drawing.Point(122, 262);
            this.dvg_quartos.Name = "dvg_quartos";
            this.dvg_quartos.RowHeadersWidth = 51;
            this.dvg_quartos.RowTemplate.Height = 24;
            this.dvg_quartos.Size = new System.Drawing.Size(654, 183);
            this.dvg_quartos.TabIndex = 70;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(183, 105);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(280, 22);
            this.txt_numero.TabIndex = 68;
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Location = new System.Drawing.Point(132, 105);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(47, 17);
            this.lbl_cnpj.TabIndex = 67;
            this.lbl_cnpj.Text = "CNPJ:";
            // 
            // Frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 611);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.dvg_quartos);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_cnpj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_empresa";
            this.Text = "Cadastro de empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_quartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        public System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dvg_quartos;
        public System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_cnpj;
    }
}