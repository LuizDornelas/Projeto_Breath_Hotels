namespace ProjetoHotel
{
    partial class Frm_CadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroUsuarios));
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.cmb_cadastro_fun = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(796, 133);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.msk_telefone.Mask = "(99)00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(184, 31);
            this.msk_telefone.TabIndex = 26;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(100, 209);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rua.Multiline = true;
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(166, 31);
            this.txt_rua.TabIndex = 25;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(100, 133);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(438, 31);
            this.txt_nome.TabIndex = 24;
            // 
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(587, 133);
            this.msk_rg.Margin = new System.Windows.Forms.Padding(4);
            this.msk_rg.Mask = "99,999,999-9";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(148, 31);
            this.msk_rg.TabIndex = 23;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(582, 104);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(49, 25);
            this.lbl_cpf.TabIndex = 22;
            this.lbl_cpf.Text = "RG:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(95, 104);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 25);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(791, 104);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(98, 25);
            this.lbl_telefone.TabIndex = 20;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Location = new System.Drawing.Point(95, 180);
            this.lbl_rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(57, 25);
            this.lbl_rua.TabIndex = 19;
            this.lbl_rua.Text = "Rua:";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(851, 265);
            this.lbl_cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(74, 25);
            this.lbl_cargo.TabIndex = 37;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(469, 265);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(93, 25);
            this.lbl_usuario.TabIndex = 38;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(474, 294);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 31);
            this.txt_usuario.TabIndex = 39;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(659, 265);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(76, 25);
            this.lbl_senha.TabIndex = 41;
            this.lbl_senha.Text = "Senha:";
            this.lbl_senha.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(664, 294);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(166, 31);
            this.txt_senha.TabIndex = 42;
            // 
            // cmb_cadastro_fun
            // 
            this.cmb_cadastro_fun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cadastro_fun.FormattingEnabled = true;
            this.cmb_cadastro_fun.Location = new System.Drawing.Point(856, 292);
            this.cmb_cadastro_fun.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cadastro_fun.Name = "cmb_cadastro_fun";
            this.cmb_cadastro_fun.Size = new System.Drawing.Size(124, 33);
            this.cmb_cadastro_fun.TabIndex = 43;
            this.cmb_cadastro_fun.SelectedIndexChanged += new System.EventHandler(this.cmb_cadastro_fun_SelectedIndexChanged);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(350, 29);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(368, 38);
            this.Titulo.TabIndex = 44;
            this.Titulo.Text = "Cadastro de Usuários";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "* Todos os dados são de preenchimento obrigatório";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(285, 180);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(96, 25);
            this.lbl_numero.TabIndex = 47;
            this.lbl_numero.Text = "Número:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(469, 180);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(79, 25);
            this.lbl_bairro.TabIndex = 48;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(474, 209);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairro.Multiline = true;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(166, 31);
            this.txt_bairro.TabIndex = 49;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(659, 180);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(83, 25);
            this.lbl_cidade.TabIndex = 50;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(664, 209);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade.Multiline = true;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(166, 31);
            this.txt_cidade.TabIndex = 51;
            // 
            // msk_numero
            // 
            this.msk_numero.Location = new System.Drawing.Point(290, 209);
            this.msk_numero.Margin = new System.Windows.Forms.Padding(4);
            this.msk_numero.Mask = "99999999";
            this.msk_numero.Name = "msk_numero";
            this.msk_numero.Size = new System.Drawing.Size(148, 31);
            this.msk_numero.TabIndex = 52;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(100, 294);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Multiline = true;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(166, 31);
            this.txt_estado.TabIndex = 53;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(285, 265);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(59, 25);
            this.lbl_cep.TabIndex = 54;
            this.lbl_cep.Text = "CEP:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(95, 265);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(83, 25);
            this.lbl_estado.TabIndex = 55;
            this.lbl_estado.Text = "Estado:";
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(290, 294);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(4);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(148, 31);
            this.msk_cep.TabIndex = 56;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(277, 362);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 58;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(587, 362);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 59;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
            // 
            // Frm_cadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_voltar);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.cmb_cadastro_fun);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_rua);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_cadastroUsuarios";
            this.Text = "Cadastro de Usuários";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_cadastroFuncionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_telefone;
        public System.Windows.Forms.TextBox txt_rua;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        public System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox cmb_cadastro_fun;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvar;
    }
}