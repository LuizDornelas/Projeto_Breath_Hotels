﻿
namespace ProjetoHotel
{
    partial class Frm_CadastroCartao
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.msk_pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.lbl_numero_cartao = new System.Windows.Forms.Label();
            this.msk_numero_cartao = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome_cartao = new System.Windows.Forms.TextBox();
            this.lbl_nome_cartao = new System.Windows.Forms.Label();
            this.lbl_bandeira = new System.Windows.Forms.Label();
            this.msk_validade = new System.Windows.Forms.MaskedTextBox();
            this.msk_codigo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_validade = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cmb_bandeira = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(101, 183);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(416, 31);
            this.txt_nome.TabIndex = 24;
            // 
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(547, 183);
            this.msk_rg.Margin = new System.Windows.Forms.Padding(4);
            this.msk_rg.Mask = "99,999,999-9";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.ReadOnly = true;
            this.msk_rg.Size = new System.Drawing.Size(148, 31);
            this.msk_rg.TabIndex = 23;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(542, 154);
            this.lbl_rg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(42, 25);
            this.lbl_rg.TabIndex = 22;
            this.lbl_rg.Text = "RG";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(96, 154);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(162, 25);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome do cliente";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(366, 21);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(346, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Cadastro de Cartões";
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(104, 107);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(132, 25);
            this.lbl_pesquisa.TabIndex = 59;
            this.lbl_pesquisa.Text = "Pesquisar ID";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(263, 412);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // msk_pesquisa
            // 
            this.msk_pesquisa.Location = new System.Drawing.Point(233, 103);
            this.msk_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.msk_pesquisa.Mask = "99999";
            this.msk_pesquisa.Name = "msk_pesquisa";
            this.msk_pesquisa.Size = new System.Drawing.Size(84, 31);
            this.msk_pesquisa.TabIndex = 67;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_pesquisa.Location = new System.Drawing.Point(324, 98);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(41, 43);
            this.btn_pesquisa.TabIndex = 66;
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // lbl_numero_cartao
            // 
            this.lbl_numero_cartao.AutoSize = true;
            this.lbl_numero_cartao.Location = new System.Drawing.Point(96, 233);
            this.lbl_numero_cartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero_cartao.Name = "lbl_numero_cartao";
            this.lbl_numero_cartao.Size = new System.Drawing.Size(153, 25);
            this.lbl_numero_cartao.TabIndex = 73;
            this.lbl_numero_cartao.Text = "Número cartão";
            // 
            // msk_numero_cartao
            // 
            this.msk_numero_cartao.Location = new System.Drawing.Point(101, 262);
            this.msk_numero_cartao.Margin = new System.Windows.Forms.Padding(4);
            this.msk_numero_cartao.Mask = "9999-9999-9999-9999";
            this.msk_numero_cartao.Name = "msk_numero_cartao";
            this.msk_numero_cartao.Size = new System.Drawing.Size(289, 31);
            this.msk_numero_cartao.TabIndex = 74;
            // 
            // txt_nome_cartao
            // 
            this.txt_nome_cartao.Location = new System.Drawing.Point(547, 262);
            this.txt_nome_cartao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_cartao.MaxLength = 50;
            this.txt_nome_cartao.Multiline = true;
            this.txt_nome_cartao.Name = "txt_nome_cartao";
            this.txt_nome_cartao.Size = new System.Drawing.Size(438, 31);
            this.txt_nome_cartao.TabIndex = 75;
            // 
            // lbl_nome_cartao
            // 
            this.lbl_nome_cartao.AutoSize = true;
            this.lbl_nome_cartao.Location = new System.Drawing.Point(542, 233);
            this.lbl_nome_cartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_cartao.Name = "lbl_nome_cartao";
            this.lbl_nome_cartao.Size = new System.Drawing.Size(132, 25);
            this.lbl_nome_cartao.TabIndex = 76;
            this.lbl_nome_cartao.Text = "Nome cartão";
            // 
            // lbl_bandeira
            // 
            this.lbl_bandeira.AutoSize = true;
            this.lbl_bandeira.Location = new System.Drawing.Point(542, 302);
            this.lbl_bandeira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bandeira.Name = "lbl_bandeira";
            this.lbl_bandeira.Size = new System.Drawing.Size(97, 25);
            this.lbl_bandeira.TabIndex = 77;
            this.lbl_bandeira.Text = "Bandeira";
            // 
            // msk_validade
            // 
            this.msk_validade.Location = new System.Drawing.Point(101, 331);
            this.msk_validade.Margin = new System.Windows.Forms.Padding(4);
            this.msk_validade.Mask = "00/00";
            this.msk_validade.Name = "msk_validade";
            this.msk_validade.Size = new System.Drawing.Size(89, 31);
            this.msk_validade.TabIndex = 78;
            this.msk_validade.ValidatingType = typeof(System.DateTime);
            // 
            // msk_codigo
            // 
            this.msk_codigo.Location = new System.Drawing.Point(353, 331);
            this.msk_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.msk_codigo.Mask = "999";
            this.msk_codigo.Name = "msk_codigo";
            this.msk_codigo.Size = new System.Drawing.Size(71, 31);
            this.msk_codigo.TabIndex = 79;
            // 
            // lbl_validade
            // 
            this.lbl_validade.AutoSize = true;
            this.lbl_validade.Location = new System.Drawing.Point(96, 302);
            this.lbl_validade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_validade.Name = "lbl_validade";
            this.lbl_validade.Size = new System.Drawing.Size(94, 25);
            this.lbl_validade.TabIndex = 80;
            this.lbl_validade.Text = "Validade";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(348, 302);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(76, 25);
            this.lbl_codigo.TabIndex = 81;
            this.lbl_codigo.Text = "Código";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(547, 412);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 82;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cmb_bandeira
            // 
            this.cmb_bandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bandeira.FormattingEnabled = true;
            this.cmb_bandeira.Location = new System.Drawing.Point(547, 331);
            this.cmb_bandeira.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_bandeira.Name = "cmb_bandeira";
            this.cmb_bandeira.Size = new System.Drawing.Size(148, 33);
            this.cmb_bandeira.TabIndex = 83;
            // 
            // Frm_CadastroCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 520);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_bandeira);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_validade);
            this.Controls.Add(this.msk_codigo);
            this.Controls.Add(this.msk_validade);
            this.Controls.Add(this.lbl_bandeira);
            this.Controls.Add(this.lbl_nome_cartao);
            this.Controls.Add(this.txt_nome_cartao);
            this.Controls.Add(this.msk_numero_cartao);
            this.Controls.Add(this.lbl_numero_cartao);
            this.Controls.Add(this.msk_pesquisa);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_CadastroCartao";
            this.Text = "Cadastro Cartao";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisa;
        public System.Windows.Forms.MaskedTextBox msk_pesquisa;
        private System.Windows.Forms.Label lbl_numero_cartao;
        public System.Windows.Forms.MaskedTextBox msk_numero_cartao;
        public System.Windows.Forms.TextBox txt_nome_cartao;
        private System.Windows.Forms.Label lbl_nome_cartao;
        private System.Windows.Forms.Label lbl_bandeira;
        public System.Windows.Forms.MaskedTextBox msk_validade;
        public System.Windows.Forms.MaskedTextBox msk_codigo;
        private System.Windows.Forms.Label lbl_validade;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cmb_bandeira;
    }
}