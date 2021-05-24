
namespace ProjetoHotel
{
    partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_pg_lateral = new System.Windows.Forms.Panel();
            this.lbl_reservas_andamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.ptr_checkin = new System.Windows.Forms.PictureBox();
            this.lbl_reservas_encerradas = new System.Windows.Forms.Label();
            this.ptr_usuario = new System.Windows.Forms.PictureBox();
            this.lbl_separador_1 = new System.Windows.Forms.Label();
            this.ptr_relogio = new System.Windows.Forms.PictureBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.tmr_horas = new System.Windows.Forms.Timer(this.components);
            this.tmr_data = new System.Windows.Forms.Timer(this.components);
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasEncerradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_andamento = new System.Windows.Forms.Button();
            this.btn_encerrados = new System.Windows.Forms.Button();
            this.dgv_reservas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_pg_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_checkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).BeginInit();
            this.mnu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_pg_lateral
            // 
            this.pnl_pg_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pg_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.pnl_pg_lateral.Controls.Add(this.lbl_reservas_andamento);
            this.pnl_pg_lateral.Controls.Add(this.label1);
            this.pnl_pg_lateral.Controls.Add(this.label2);
            this.pnl_pg_lateral.Controls.Add(this.lbl_nome);
            this.pnl_pg_lateral.Controls.Add(this.ptr_checkin);
            this.pnl_pg_lateral.Controls.Add(this.lbl_reservas_encerradas);
            this.pnl_pg_lateral.Controls.Add(this.ptr_usuario);
            this.pnl_pg_lateral.Controls.Add(this.lbl_separador_1);
            this.pnl_pg_lateral.Controls.Add(this.ptr_relogio);
            this.pnl_pg_lateral.Controls.Add(this.lbl_data);
            this.pnl_pg_lateral.Controls.Add(this.lbl_horas);
            this.pnl_pg_lateral.Location = new System.Drawing.Point(1196, 28);
            this.pnl_pg_lateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_pg_lateral.Name = "pnl_pg_lateral";
            this.pnl_pg_lateral.Size = new System.Drawing.Size(355, 767);
            this.pnl_pg_lateral.TabIndex = 3;
            // 
            // lbl_reservas_andamento
            // 
            this.lbl_reservas_andamento.AutoSize = true;
            this.lbl_reservas_andamento.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservas_andamento.ForeColor = System.Drawing.Color.White;
            this.lbl_reservas_andamento.Location = new System.Drawing.Point(5, 459);
            this.lbl_reservas_andamento.Name = "lbl_reservas_andamento";
            this.lbl_reservas_andamento.Size = new System.Drawing.Size(299, 36);
            this.lbl_reservas_andamento.TabIndex = 73;
            this.lbl_reservas_andamento.Text = "Reservas em andamento: 6";
            this.lbl_reservas_andamento.Click += new System.EventHandler(this.lbl_reservas_andamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-35, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 26);
            this.label1.TabIndex = 72;
            this.label1.Text = "________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-33, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "________________________________";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(3, 267);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(145, 36);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "Usuário: Luiz";
            // 
            // ptr_checkin
            // 
            this.ptr_checkin.Image = ((System.Drawing.Image)(resources.GetObject("ptr_checkin.Image")));
            this.ptr_checkin.Location = new System.Drawing.Point(11, 347);
            this.ptr_checkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_checkin.Name = "ptr_checkin";
            this.ptr_checkin.Size = new System.Drawing.Size(67, 62);
            this.ptr_checkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_checkin.TabIndex = 69;
            this.ptr_checkin.TabStop = false;
            // 
            // lbl_reservas_encerradas
            // 
            this.lbl_reservas_encerradas.AutoSize = true;
            this.lbl_reservas_encerradas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservas_encerradas.ForeColor = System.Drawing.Color.White;
            this.lbl_reservas_encerradas.Location = new System.Drawing.Point(5, 425);
            this.lbl_reservas_encerradas.Name = "lbl_reservas_encerradas";
            this.lbl_reservas_encerradas.Size = new System.Drawing.Size(259, 36);
            this.lbl_reservas_encerradas.TabIndex = 70;
            this.lbl_reservas_encerradas.Text = "Reservas encerradas: 6";
            // 
            // ptr_usuario
            // 
            this.ptr_usuario.Image = ((System.Drawing.Image)(resources.GetObject("ptr_usuario.Image")));
            this.ptr_usuario.Location = new System.Drawing.Point(7, 182);
            this.ptr_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_usuario.Name = "ptr_usuario";
            this.ptr_usuario.Size = new System.Drawing.Size(67, 62);
            this.ptr_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_usuario.TabIndex = 8;
            this.ptr_usuario.TabStop = false;
            // 
            // lbl_separador_1
            // 
            this.lbl_separador_1.AutoSize = true;
            this.lbl_separador_1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separador_1.ForeColor = System.Drawing.Color.White;
            this.lbl_separador_1.Location = new System.Drawing.Point(-21, 145);
            this.lbl_separador_1.Name = "lbl_separador_1";
            this.lbl_separador_1.Size = new System.Drawing.Size(460, 26);
            this.lbl_separador_1.TabIndex = 7;
            this.lbl_separador_1.Text = "________________________________";
            // 
            // ptr_relogio
            // 
            this.ptr_relogio.Image = ((System.Drawing.Image)(resources.GetObject("ptr_relogio.Image")));
            this.ptr_relogio.Location = new System.Drawing.Point(8, 27);
            this.ptr_relogio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_relogio.Name = "ptr_relogio";
            this.ptr_relogio.Size = new System.Drawing.Size(67, 62);
            this.ptr_relogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_relogio.TabIndex = 6;
            this.ptr_relogio.TabStop = false;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(67, 111);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(198, 36);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "DATA:  25/03/2021";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.White;
            this.lbl_horas.Location = new System.Drawing.Point(100, 43);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(89, 36);
            this.lbl_horas.TabIndex = 6;
            this.lbl_horas.Text = "16:13:18";
            // 
            // tmr_horas
            // 
            this.tmr_horas.Enabled = true;
            this.tmr_horas.Tick += new System.EventHandler(this.tmr_horas_Tick_1);
            // 
            // tmr_data
            // 
            this.tmr_data.Enabled = true;
            this.tmr_data.Tick += new System.EventHandler(this.tmr_data_Tick_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(85, 40);
            this.sairToolStripMenuItem.Text = "Login";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.logToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.fecharSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(179, 40);
            this.produtosToolStripMenuItem.Text = "Comprar Itens";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // mnu_principal
            // 
            this.mnu_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.mnu_principal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.reservasEncerradasToolStripMenuItem});
            this.mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_principal.Name = "mnu_principal";
            this.mnu_principal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnu_principal.Size = new System.Drawing.Size(1539, 44);
            this.mnu_principal.TabIndex = 0;
            this.mnu_principal.Text = "menu_pg1";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.históricoToolStripMenuItem.Text = "Reservas em Andamento";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // reservasEncerradasToolStripMenuItem
            // 
            this.reservasEncerradasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reservasEncerradasToolStripMenuItem.Name = "reservasEncerradasToolStripMenuItem";
            this.reservasEncerradasToolStripMenuItem.Size = new System.Drawing.Size(248, 40);
            this.reservasEncerradasToolStripMenuItem.Text = "Reservas Encerradas";
            this.reservasEncerradasToolStripMenuItem.Click += new System.EventHandler(this.reservasEncerradasToolStripMenuItem_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_compra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_compra.BackgroundImage")));
            this.btn_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_compra.Location = new System.Drawing.Point(16, 295);
            this.btn_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(104, 91);
            this.btn_compra.TabIndex = 70;
            this.btn_compra.UseVisualStyleBackColor = false;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisa.Image")));
            this.btn_pesquisa.Location = new System.Drawing.Point(1113, 48);
            this.btn_pesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(55, 53);
            this.btn_pesquisa.TabIndex = 68;
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_andamento
            // 
            this.btn_andamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_andamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_andamento.BackgroundImage")));
            this.btn_andamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_andamento.Location = new System.Drawing.Point(16, 55);
            this.btn_andamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_andamento.Name = "btn_andamento";
            this.btn_andamento.Size = new System.Drawing.Size(104, 91);
            this.btn_andamento.TabIndex = 77;
            this.btn_andamento.UseVisualStyleBackColor = false;
            this.btn_andamento.Click += new System.EventHandler(this.btn_andamento_Click_1);
            // 
            // btn_encerrados
            // 
            this.btn_encerrados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_encerrados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_encerrados.BackgroundImage")));
            this.btn_encerrados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_encerrados.Location = new System.Drawing.Point(16, 174);
            this.btn_encerrados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_encerrados.Name = "btn_encerrados";
            this.btn_encerrados.Size = new System.Drawing.Size(104, 91);
            this.btn_encerrados.TabIndex = 79;
            this.btn_encerrados.UseVisualStyleBackColor = false;
            this.btn_encerrados.Click += new System.EventHandler(this.btn_encerrados_Click_1);
            // 
            // dgv_reservas
            // 
            this.dgv_reservas.AllowUserToAddRows = false;
            this.dgv_reservas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14F);
            this.dgv_reservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_reservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_reservas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_reservas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_reservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_reservas.Location = new System.Drawing.Point(563, 108);
            this.dgv_reservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_reservas.Name = "dgv_reservas";
            this.dgv_reservas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_reservas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 14F);
            this.dgv_reservas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_reservas.Size = new System.Drawing.Size(605, 492);
            this.dgv_reservas.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 793);
            this.Controls.Add(this.dgv_reservas);
            this.Controls.Add(this.btn_encerrados);
            this.Controls.Add(this.btn_andamento);
            this.Controls.Add(this.btn_compra);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.pnl_pg_lateral);
            this.Controls.Add(this.mnu_principal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_principal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.pnl_pg_lateral.ResumeLayout(false);
            this.pnl_pg_lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_checkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).EndInit();
            this.mnu_principal.ResumeLayout(false);
            this.mnu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_pg_lateral;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Timer tmr_horas;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer tmr_data;
        private System.Windows.Forms.PictureBox ptr_relogio;
        private System.Windows.Forms.PictureBox ptr_usuario;
        private System.Windows.Forms.Label lbl_separador_1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnu_principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptr_checkin;
        private System.Windows.Forms.Label lbl_reservas_encerradas;
        private System.Windows.Forms.Label lbl_reservas_andamento;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasEncerradasToolStripMenuItem;
        private System.Windows.Forms.Button btn_compra;    
        private System.Windows.Forms.Button btn_andamento;
        private System.Windows.Forms.Button btn_encerrados;
        private System.Windows.Forms.DataGridView dgv_reservas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}