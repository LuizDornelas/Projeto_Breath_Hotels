
namespace ProjetoHotel
{
    partial class Frm_AtualizaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtualizaUsuarios));
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.msk_numero = new System.Windows.Forms.MaskedTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.cmb_ativo = new System.Windows.Forms.ComboBox();
            this.lbl_ativo = new System.Windows.Forms.Label();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cmb_pesquisacad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_telefone
            // 
            this.msk_telefone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone.Location = new System.Drawing.Point(791, 283);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.msk_telefone.Mask = "(99)00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(184, 31);
            this.msk_telefone.TabIndex = 26;
            // 
            // txt_rua
            // 
            this.txt_rua.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(95, 359);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rua.Multiline = true;
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(166, 31);
            this.txt_rua.TabIndex = 25;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(95, 283);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(438, 31);
            this.txt_nome.TabIndex = 24;
            // 
            // msk_rg
            // 
            this.msk_rg.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_rg.Location = new System.Drawing.Point(582, 283);
            this.msk_rg.Margin = new System.Windows.Forms.Padding(4);
            this.msk_rg.Mask = "99,999,999-9";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(148, 31);
            this.msk_rg.TabIndex = 23;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rg.Location = new System.Drawing.Point(577, 254);
            this.lbl_rg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(38, 28);
            this.lbl_rg.TabIndex = 22;
            this.lbl_rg.Text = "RG:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(90, 254);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(65, 28);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(786, 254);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(86, 28);
            this.lbl_telefone.TabIndex = 20;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(90, 330);
            this.lbl_rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(48, 28);
            this.lbl_rua.TabIndex = 19;
            this.lbl_rua.Text = "Rua:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(846, 415);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(50, 28);
            this.lbl_tipo.TabIndex = 37;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(464, 415);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(78, 28);
            this.lbl_usuario.TabIndex = 38;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(469, 444);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 31);
            this.txt_usuario.TabIndex = 39;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(654, 415);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(69, 28);
            this.lbl_senha.TabIndex = 41;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(659, 444);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(166, 31);
            this.txt_senha.TabIndex = 42;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(851, 442);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(124, 36);
            this.cmb_tipo.TabIndex = 43;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.lbl_titulo.Location = new System.Drawing.Point(400, 57);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(323, 56);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Atualiza Cadastro";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(280, 330);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(82, 28);
            this.lbl_numero.TabIndex = 47;
            this.lbl_numero.Text = "Número:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(464, 330);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(63, 28);
            this.lbl_bairro.TabIndex = 48;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(469, 359);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairro.Multiline = true;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(166, 31);
            this.txt_bairro.TabIndex = 49;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(654, 330);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(75, 28);
            this.lbl_cidade.TabIndex = 50;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(659, 359);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade.Multiline = true;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(166, 31);
            this.txt_cidade.TabIndex = 51;
            // 
            // msk_numero
            // 
            this.msk_numero.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_numero.Location = new System.Drawing.Point(285, 359);
            this.msk_numero.Margin = new System.Windows.Forms.Padding(4);
            this.msk_numero.Mask = "99999999";
            this.msk_numero.Name = "msk_numero";
            this.msk_numero.Size = new System.Drawing.Size(148, 31);
            this.msk_numero.TabIndex = 52;
            // 
            // txt_estado
            // 
            this.txt_estado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(95, 444);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Multiline = true;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(166, 31);
            this.txt_estado.TabIndex = 53;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(280, 415);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(47, 28);
            this.lbl_cep.TabIndex = 54;
            this.lbl_cep.Text = "CEP:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(90, 415);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(72, 28);
            this.lbl_estado.TabIndex = 55;
            this.lbl_estado.Text = "Estado:";
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(285, 444);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(4);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(148, 31);
            this.msk_cep.TabIndex = 56;
            // 
            // cmb_ativo
            // 
            this.cmb_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ativo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ativo.FormattingEnabled = true;
            this.cmb_ativo.Location = new System.Drawing.Point(851, 359);
            this.cmb_ativo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ativo.Name = "cmb_ativo";
            this.cmb_ativo.Size = new System.Drawing.Size(124, 36);
            this.cmb_ativo.TabIndex = 57;
            // 
            // lbl_ativo
            // 
            this.lbl_ativo.AutoSize = true;
            this.lbl_ativo.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ativo.Location = new System.Drawing.Point(846, 330);
            this.lbl_ativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ativo.Name = "lbl_ativo";
            this.lbl_ativo.Size = new System.Drawing.Size(57, 28);
            this.lbl_ativo.TabIndex = 58;
            this.lbl_ativo.Text = "Ativo:";
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa.Location = new System.Drawing.Point(98, 185);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(115, 28);
            this.lbl_pesquisa.TabIndex = 59;
            this.lbl_pesquisa.Text = "Seleciona ID:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(447, 691);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(197, 63);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(101, 490);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(916, 195);
            this.dgv_usuarios.TabIndex = 64;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(688, 165);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(166, 65);
            this.btn_salvar.TabIndex = 65;
            this.btn_salvar.Text = "Atualizar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cmb_pesquisacad
            // 
            this.cmb_pesquisacad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pesquisacad.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pesquisacad.FormattingEnabled = true;
            this.cmb_pesquisacad.Location = new System.Drawing.Point(226, 182);
            this.cmb_pesquisacad.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pesquisacad.Name = "cmb_pesquisacad";
            this.cmb_pesquisacad.Size = new System.Drawing.Size(124, 36);
            this.cmb_pesquisacad.TabIndex = 68;
            this.cmb_pesquisacad.SelectedIndexChanged += new System.EventHandler(this.cmb_pesquisacad_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(881, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_AtualizaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 766);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_pesquisacad);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.lbl_ativo);
            this.Controls.Add(this.cmb_ativo);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.msk_numero);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_rua);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_AtualizaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Atualiza Cadastro";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_AtualizaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_telefone;
        public System.Windows.Forms.TextBox txt_rua;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        public System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_bairro;
        public System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_cidade;
        public System.Windows.Forms.TextBox txt_cidade;
        public System.Windows.Forms.MaskedTextBox msk_numero;
        public System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_estado;
        public System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.ComboBox cmb_ativo;
        private System.Windows.Forms.Label lbl_ativo;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cmb_pesquisacad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}