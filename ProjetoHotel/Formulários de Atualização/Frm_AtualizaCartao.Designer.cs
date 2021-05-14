
namespace ProjetoHotel
{
    partial class Frm_AtualizaCartao
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_cartoes = new System.Windows.Forms.DataGridView();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.cmb_bandeira = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_validade = new System.Windows.Forms.Label();
            this.msk_codigo = new System.Windows.Forms.MaskedTextBox();
            this.msk_validade = new System.Windows.Forms.MaskedTextBox();
            this.lbl_bandeira = new System.Windows.Forms.Label();
            this.lbl_nome_cartao = new System.Windows.Forms.Label();
            this.txt_nome_cartao = new System.Windows.Forms.TextBox();
            this.msk_numero_cartao = new System.Windows.Forms.MaskedTextBox();
            this.lbl_numero_cartao = new System.Windows.Forms.Label();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.cmb_pesquisa_cartao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(401, 31);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(272, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Atualiza Cartão";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(325, 564);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_cartoes
            // 
            this.dgv_cartoes.AllowUserToAddRows = false;
            this.dgv_cartoes.AllowUserToDeleteRows = false;
            this.dgv_cartoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_cartoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cartoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartoes.Location = new System.Drawing.Point(102, 344);
            this.dgv_cartoes.Name = "dgv_cartoes";
            this.dgv_cartoes.ReadOnly = true;
            this.dgv_cartoes.Size = new System.Drawing.Size(880, 176);
            this.dgv_cartoes.TabIndex = 64;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(790, 240);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(204, 55);
            this.btn_atualizar.TabIndex = 65;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // cmb_bandeira
            // 
            this.cmb_bandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bandeira.FormattingEnabled = true;
            this.cmb_bandeira.Location = new System.Drawing.Point(556, 252);
            this.cmb_bandeira.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_bandeira.Name = "cmb_bandeira";
            this.cmb_bandeira.Size = new System.Drawing.Size(148, 33);
            this.cmb_bandeira.TabIndex = 97;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(357, 223);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(76, 25);
            this.lbl_codigo.TabIndex = 96;
            this.lbl_codigo.Text = "Código";
            // 
            // lbl_validade
            // 
            this.lbl_validade.AutoSize = true;
            this.lbl_validade.Location = new System.Drawing.Point(105, 223);
            this.lbl_validade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_validade.Name = "lbl_validade";
            this.lbl_validade.Size = new System.Drawing.Size(94, 25);
            this.lbl_validade.TabIndex = 95;
            this.lbl_validade.Text = "Validade";
            // 
            // msk_codigo
            // 
            this.msk_codigo.Location = new System.Drawing.Point(362, 252);
            this.msk_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.msk_codigo.Mask = "999";
            this.msk_codigo.Name = "msk_codigo";
            this.msk_codigo.Size = new System.Drawing.Size(71, 31);
            this.msk_codigo.TabIndex = 94;
            // 
            // msk_validade
            // 
            this.msk_validade.Location = new System.Drawing.Point(110, 252);
            this.msk_validade.Margin = new System.Windows.Forms.Padding(4);
            this.msk_validade.Mask = "00/00";
            this.msk_validade.Name = "msk_validade";
            this.msk_validade.Size = new System.Drawing.Size(89, 31);
            this.msk_validade.TabIndex = 93;
            this.msk_validade.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_bandeira
            // 
            this.lbl_bandeira.AutoSize = true;
            this.lbl_bandeira.Location = new System.Drawing.Point(551, 223);
            this.lbl_bandeira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bandeira.Name = "lbl_bandeira";
            this.lbl_bandeira.Size = new System.Drawing.Size(97, 25);
            this.lbl_bandeira.TabIndex = 92;
            this.lbl_bandeira.Text = "Bandeira";
            // 
            // lbl_nome_cartao
            // 
            this.lbl_nome_cartao.AutoSize = true;
            this.lbl_nome_cartao.Location = new System.Drawing.Point(551, 154);
            this.lbl_nome_cartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_cartao.Name = "lbl_nome_cartao";
            this.lbl_nome_cartao.Size = new System.Drawing.Size(132, 25);
            this.lbl_nome_cartao.TabIndex = 91;
            this.lbl_nome_cartao.Text = "Nome cartão";
            // 
            // txt_nome_cartao
            // 
            this.txt_nome_cartao.Location = new System.Drawing.Point(556, 183);
            this.txt_nome_cartao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_cartao.MaxLength = 50;
            this.txt_nome_cartao.Multiline = true;
            this.txt_nome_cartao.Name = "txt_nome_cartao";
            this.txt_nome_cartao.Size = new System.Drawing.Size(438, 31);
            this.txt_nome_cartao.TabIndex = 90;
            // 
            // msk_numero_cartao
            // 
            this.msk_numero_cartao.Location = new System.Drawing.Point(110, 183);
            this.msk_numero_cartao.Margin = new System.Windows.Forms.Padding(4);
            this.msk_numero_cartao.Mask = "9999-9999-9999-9999";
            this.msk_numero_cartao.Name = "msk_numero_cartao";
            this.msk_numero_cartao.Size = new System.Drawing.Size(289, 31);
            this.msk_numero_cartao.TabIndex = 89;
            // 
            // lbl_numero_cartao
            // 
            this.lbl_numero_cartao.AutoSize = true;
            this.lbl_numero_cartao.Location = new System.Drawing.Point(105, 154);
            this.lbl_numero_cartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero_cartao.Name = "lbl_numero_cartao";
            this.lbl_numero_cartao.Size = new System.Drawing.Size(153, 25);
            this.lbl_numero_cartao.TabIndex = 88;
            this.lbl_numero_cartao.Text = "Número cartão";
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(105, 105);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(164, 25);
            this.lbl_pesquisa.TabIndex = 98;
            this.lbl_pesquisa.Text = "Seleciona cartão";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(556, 103);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(438, 31);
            this.txt_nome.TabIndex = 101;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(480, 105);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(68, 25);
            this.lbl_nome.TabIndex = 102;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(575, 564);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(204, 55);
            this.btn_excluir.TabIndex = 103;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // cmb_pesquisa_cartao
            // 
            this.cmb_pesquisa_cartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pesquisa_cartao.FormattingEnabled = true;
            this.cmb_pesquisa_cartao.Location = new System.Drawing.Point(275, 101);
            this.cmb_pesquisa_cartao.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pesquisa_cartao.Name = "cmb_pesquisa_cartao";
            this.cmb_pesquisa_cartao.Size = new System.Drawing.Size(73, 33);
            this.cmb_pesquisa_cartao.TabIndex = 104;
            this.cmb_pesquisa_cartao.SelectedIndexChanged += new System.EventHandler(this.cmb_pesquisa_cartao_SelectedIndexChanged);
            // 
            // Frm_AtualizaCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 631);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_pesquisa_cartao);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.cmb_bandeira);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_validade);
            this.Controls.Add(this.msk_codigo);
            this.Controls.Add(this.msk_validade);
            this.Controls.Add(this.lbl_bandeira);
            this.Controls.Add(this.lbl_nome_cartao);
            this.Controls.Add(this.txt_nome_cartao);
            this.Controls.Add(this.msk_numero_cartao);
            this.Controls.Add(this.lbl_numero_cartao);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.dgv_cartoes);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_AtualizaCartao";
            this.Text = "Atualiza Cartão";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_cartoes;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ComboBox cmb_bandeira;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_validade;
        public System.Windows.Forms.MaskedTextBox msk_codigo;
        public System.Windows.Forms.MaskedTextBox msk_validade;
        private System.Windows.Forms.Label lbl_bandeira;
        private System.Windows.Forms.Label lbl_nome_cartao;
        public System.Windows.Forms.TextBox txt_nome_cartao;
        public System.Windows.Forms.MaskedTextBox msk_numero_cartao;
        private System.Windows.Forms.Label lbl_numero_cartao;
        private System.Windows.Forms.Label lbl_pesquisa;
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.ComboBox cmb_pesquisa_cartao;
    }
}