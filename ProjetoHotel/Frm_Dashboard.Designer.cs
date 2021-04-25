namespace ProjetoHotel
{
    partial class Frm_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedadoscheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.pnl_pg_lateral = new System.Windows.Forms.Panel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_separador_2 = new System.Windows.Forms.Label();
            this.ptr_usuario = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_separador_1 = new System.Windows.Forms.Label();
            this.ptr_relogio = new System.Windows.Forms.PictureBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.tmr_horas = new System.Windows.Forms.Timer(this.components);
            this.tmr_data = new System.Windows.Forms.Timer(this.components);
            this.ptr_hotel = new System.Windows.Forms.PictureBox();
            this.ptr_quarto = new System.Windows.Forms.PictureBox();
            this.ptr_atras_hotel = new System.Windows.Forms.PictureBox();
            this.ptr_piscina = new System.Windows.Forms.PictureBox();
            this.mnu_principal.SuspendLayout();
            this.pnl_pg_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_atras_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_piscina)).BeginInit();
            this.SuspendLayout();
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.sairToolStripMenuItem.Text = "Login";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.funcionariosToolStripMenuItem.Text = "Cadastro de Usuário";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem1,
            this.hospedadoscheckInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.reservasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            this.reservasToolStripMenuItem1.Click += new System.EventHandler(this.reservasToolStripMenuItem1_Click);
            // 
            // hospedadoscheckInToolStripMenuItem
            // 
            this.hospedadoscheckInToolStripMenuItem.Name = "hospedadoscheckInToolStripMenuItem";
            this.hospedadoscheckInToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.hospedadoscheckInToolStripMenuItem.Text = "Hospedados(check-In";
            this.hospedadoscheckInToolStripMenuItem.Click += new System.EventHandler(this.hospedadoscheckInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem});
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // mnu_principal
            // 
            this.mnu_principal.BackColor = System.Drawing.Color.White;
            this.mnu_principal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_principal.Name = "mnu_principal";
            this.mnu_principal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnu_principal.Size = new System.Drawing.Size(1109, 25);
            this.mnu_principal.TabIndex = 0;
            this.mnu_principal.Text = "menu_pg1";
            this.mnu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pnl_pg_lateral
            // 
            this.pnl_pg_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pg_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.pnl_pg_lateral.Controls.Add(this.lbl_nome);
            this.pnl_pg_lateral.Controls.Add(this.lbl_separador_2);
            this.pnl_pg_lateral.Controls.Add(this.ptr_usuario);
            this.pnl_pg_lateral.Controls.Add(this.lbl_usuario);
            this.pnl_pg_lateral.Controls.Add(this.lbl_separador_1);
            this.pnl_pg_lateral.Controls.Add(this.ptr_relogio);
            this.pnl_pg_lateral.Controls.Add(this.lbl_data);
            this.pnl_pg_lateral.Controls.Add(this.lbl_horas);
            this.pnl_pg_lateral.Location = new System.Drawing.Point(884, 23);
            this.pnl_pg_lateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_pg_lateral.Name = "pnl_pg_lateral";
            this.pnl_pg_lateral.Size = new System.Drawing.Size(234, 727);
            this.pnl_pg_lateral.TabIndex = 3;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(90, 161);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 22);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "Luiz";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // lbl_separador_2
            // 
            this.lbl_separador_2.AutoSize = true;
            this.lbl_separador_2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separador_2.ForeColor = System.Drawing.Color.White;
            this.lbl_separador_2.Location = new System.Drawing.Point(-25, 234);
            this.lbl_separador_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_separador_2.Name = "lbl_separador_2";
            this.lbl_separador_2.Size = new System.Drawing.Size(362, 22);
            this.lbl_separador_2.TabIndex = 10;
            this.lbl_separador_2.Text = "________________________________";
            // 
            // ptr_usuario
            // 
            this.ptr_usuario.Image = ((System.Drawing.Image)(resources.GetObject("ptr_usuario.Image")));
            this.ptr_usuario.Location = new System.Drawing.Point(21, 144);
            this.ptr_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_usuario.Name = "ptr_usuario";
            this.ptr_usuario.Size = new System.Drawing.Size(50, 50);
            this.ptr_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_usuario.TabIndex = 8;
            this.ptr_usuario.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(17, 212);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(205, 22);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Cargo: Administrador";
            // 
            // lbl_separador_1
            // 
            this.lbl_separador_1.AutoSize = true;
            this.lbl_separador_1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separador_1.ForeColor = System.Drawing.Color.White;
            this.lbl_separador_1.Location = new System.Drawing.Point(-25, 112);
            this.lbl_separador_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_separador_1.Name = "lbl_separador_1";
            this.lbl_separador_1.Size = new System.Drawing.Size(362, 22);
            this.lbl_separador_1.TabIndex = 7;
            this.lbl_separador_1.Text = "________________________________";
            // 
            // ptr_relogio
            // 
            this.ptr_relogio.Image = ((System.Drawing.Image)(resources.GetObject("ptr_relogio.Image")));
            this.ptr_relogio.Location = new System.Drawing.Point(21, 22);
            this.ptr_relogio.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_relogio.Name = "ptr_relogio";
            this.ptr_relogio.Size = new System.Drawing.Size(50, 50);
            this.ptr_relogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_relogio.TabIndex = 6;
            this.ptr_relogio.TabStop = false;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(17, 90);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(181, 22);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "DATA:  25/03/2021";
            this.lbl_data.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.White;
            this.lbl_horas.Location = new System.Drawing.Point(90, 36);
            this.lbl_horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(92, 22);
            this.lbl_horas.TabIndex = 6;
            this.lbl_horas.Text = "20:16:15";
            this.lbl_horas.Click += new System.EventHandler(this.lbl_horas_Click);
            // 
            // tmr_horas
            // 
            this.tmr_horas.Enabled = true;
            this.tmr_horas.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_data
            // 
            this.tmr_data.Enabled = true;
            this.tmr_data.Tick += new System.EventHandler(this.tmr_data_Tick);
            // 
            // ptr_hotel
            // 
            this.ptr_hotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_hotel.Image = ((System.Drawing.Image)(resources.GetObject("ptr_hotel.Image")));
            this.ptr_hotel.Location = new System.Drawing.Point(655, 25);
            this.ptr_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_hotel.Name = "ptr_hotel";
            this.ptr_hotel.Size = new System.Drawing.Size(224, 192);
            this.ptr_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_hotel.TabIndex = 6;
            this.ptr_hotel.TabStop = false;
            // 
            // ptr_quarto
            // 
            this.ptr_quarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_quarto.Image = ((System.Drawing.Image)(resources.GetObject("ptr_quarto.Image")));
            this.ptr_quarto.Location = new System.Drawing.Point(655, 222);
            this.ptr_quarto.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_quarto.Name = "ptr_quarto";
            this.ptr_quarto.Size = new System.Drawing.Size(224, 192);
            this.ptr_quarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_quarto.TabIndex = 7;
            this.ptr_quarto.TabStop = false;
            // 
            // ptr_atras_hotel
            // 
            this.ptr_atras_hotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_atras_hotel.Image = ((System.Drawing.Image)(resources.GetObject("ptr_atras_hotel.Image")));
            this.ptr_atras_hotel.Location = new System.Drawing.Point(655, 615);
            this.ptr_atras_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_atras_hotel.Name = "ptr_atras_hotel";
            this.ptr_atras_hotel.Size = new System.Drawing.Size(224, 192);
            this.ptr_atras_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_atras_hotel.TabIndex = 8;
            this.ptr_atras_hotel.TabStop = false;
            // 
            // ptr_piscina
            // 
            this.ptr_piscina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_piscina.Image = ((System.Drawing.Image)(resources.GetObject("ptr_piscina.Image")));
            this.ptr_piscina.Location = new System.Drawing.Point(655, 418);
            this.ptr_piscina.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_piscina.Name = "ptr_piscina";
            this.ptr_piscina.Size = new System.Drawing.Size(224, 192);
            this.ptr_piscina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_piscina.TabIndex = 9;
            this.ptr_piscina.TabStop = false;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 748);
            this.Controls.Add(this.ptr_piscina);
            this.Controls.Add(this.ptr_atras_hotel);
            this.Controls.Add(this.ptr_quarto);
            this.Controls.Add(this.ptr_hotel);
            this.Controls.Add(this.pnl_pg_lateral);
            this.Controls.Add(this.mnu_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_principal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pg_1_Load);
            this.mnu_principal.ResumeLayout(false);
            this.mnu_principal.PerformLayout();
            this.pnl_pg_lateral.ResumeLayout(false);
            this.pnl_pg_lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_atras_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_piscina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hospedadoscheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnu_principal;
        private System.Windows.Forms.Panel pnl_pg_lateral;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Timer tmr_horas;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer tmr_data;
        private System.Windows.Forms.PictureBox ptr_relogio;
        private System.Windows.Forms.PictureBox ptr_hotel;
        private System.Windows.Forms.PictureBox ptr_quarto;
        private System.Windows.Forms.PictureBox ptr_atras_hotel;
        private System.Windows.Forms.PictureBox ptr_piscina;
        private System.Windows.Forms.Label lbl_separador_2;
        private System.Windows.Forms.PictureBox ptr_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_separador_1;
        private System.Windows.Forms.Label lbl_nome;
    }
}