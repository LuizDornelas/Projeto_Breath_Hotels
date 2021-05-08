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
            this.atualizaCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedadoscheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.pnl_pg_lateral = new System.Windows.Forms.Panel();
            this.lbl_quartosdisponiveis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ptr_quartos = new System.Windows.Forms.PictureBox();
            this.lbl_quartostotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptr_checkin = new System.Windows.Forms.PictureBox();
            this.lbl_reservas = new System.Windows.Forms.Label();
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
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.mnu_principal.SuspendLayout();
            this.pnl_pg_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_checkin)).BeginInit();
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
            this.funcionariosToolStripMenuItem,
            this.atualizaCadastroToolStripMenuItem});
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
            // atualizaCadastroToolStripMenuItem
            // 
            this.atualizaCadastroToolStripMenuItem.Name = "atualizaCadastroToolStripMenuItem";
            this.atualizaCadastroToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.atualizaCadastroToolStripMenuItem.Text = "Atualiza Cadastro";
            this.atualizaCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizaCadastroToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospedadoscheckInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.reservasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // hospedadoscheckInToolStripMenuItem
            // 
            this.hospedadoscheckInToolStripMenuItem.Name = "hospedadoscheckInToolStripMenuItem";
            this.hospedadoscheckInToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.hospedadoscheckInToolStripMenuItem.Text = "Checkin";
            this.hospedadoscheckInToolStripMenuItem.Click += new System.EventHandler(this.hospedadoscheckInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.checkOutToolStripMenuItem.Text = "Checkout";
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
            this.pnl_pg_lateral.Controls.Add(this.lbl_quartosdisponiveis);
            this.pnl_pg_lateral.Controls.Add(this.label5);
            this.pnl_pg_lateral.Controls.Add(this.ptr_quartos);
            this.pnl_pg_lateral.Controls.Add(this.lbl_quartostotal);
            this.pnl_pg_lateral.Controls.Add(this.label2);
            this.pnl_pg_lateral.Controls.Add(this.ptr_checkin);
            this.pnl_pg_lateral.Controls.Add(this.lbl_reservas);
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
            // lbl_quartosdisponiveis
            // 
            this.lbl_quartosdisponiveis.AutoSize = true;
            this.lbl_quartosdisponiveis.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quartosdisponiveis.ForeColor = System.Drawing.Color.White;
            this.lbl_quartosdisponiveis.Location = new System.Drawing.Point(11, 494);
            this.lbl_quartosdisponiveis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quartosdisponiveis.Name = "lbl_quartosdisponiveis";
            this.lbl_quartosdisponiveis.Size = new System.Drawing.Size(211, 22);
            this.lbl_quartosdisponiveis.TabIndex = 19;
            this.lbl_quartosdisponiveis.Text = "Quartos disponíveis: 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-25, 529);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "________________________________";
            // 
            // ptr_quartos
            // 
            this.ptr_quartos.Image = ((System.Drawing.Image)(resources.GetObject("ptr_quartos.Image")));
            this.ptr_quartos.Location = new System.Drawing.Point(21, 395);
            this.ptr_quartos.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_quartos.Name = "ptr_quartos";
            this.ptr_quartos.Size = new System.Drawing.Size(50, 50);
            this.ptr_quartos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_quartos.TabIndex = 16;
            this.ptr_quartos.TabStop = false;
            // 
            // lbl_quartostotal
            // 
            this.lbl_quartostotal.AutoSize = true;
            this.lbl_quartostotal.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quartostotal.ForeColor = System.Drawing.Color.White;
            this.lbl_quartostotal.Location = new System.Drawing.Point(11, 463);
            this.lbl_quartostotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quartostotal.Name = "lbl_quartostotal";
            this.lbl_quartostotal.Size = new System.Drawing.Size(166, 22);
            this.lbl_quartostotal.TabIndex = 17;
            this.lbl_quartostotal.Text = "Total Quartos: 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-25, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "________________________________";
            // 
            // ptr_checkin
            // 
            this.ptr_checkin.Image = ((System.Drawing.Image)(resources.GetObject("ptr_checkin.Image")));
            this.ptr_checkin.Location = new System.Drawing.Point(21, 268);
            this.ptr_checkin.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_checkin.Name = "ptr_checkin";
            this.ptr_checkin.Size = new System.Drawing.Size(50, 50);
            this.ptr_checkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_checkin.TabIndex = 12;
            this.ptr_checkin.TabStop = false;
            // 
            // lbl_reservas
            // 
            this.lbl_reservas.AutoSize = true;
            this.lbl_reservas.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservas.ForeColor = System.Drawing.Color.White;
            this.lbl_reservas.Location = new System.Drawing.Point(17, 336);
            this.lbl_reservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reservas.Name = "lbl_reservas";
            this.lbl_reservas.Size = new System.Drawing.Size(118, 22);
            this.lbl_reservas.TabIndex = 13;
            this.lbl_reservas.Text = "Reservas: 6";
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
            this.lbl_horas.Text = "16:13:18";
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
            // btn_pesquisa
            // 
            this.btn_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisa.Image")));
            this.btn_pesquisa.Location = new System.Drawing.Point(609, 38);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(41, 43);
            this.btn_pesquisa.TabIndex = 67;
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 748);
            this.Controls.Add(this.btn_pesquisa);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_checkin)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem atualizaCadastroToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptr_quartos;
        private System.Windows.Forms.Label lbl_quartostotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptr_checkin;
        private System.Windows.Forms.Label lbl_reservas;
        private System.Windows.Forms.Label lbl_quartosdisponiveis;
        private System.Windows.Forms.Button btn_pesquisa;
    }
}