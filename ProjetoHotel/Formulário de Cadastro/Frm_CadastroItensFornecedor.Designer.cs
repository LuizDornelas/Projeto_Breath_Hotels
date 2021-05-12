
namespace ProjetoHotel
{
    partial class Frm_CadastroItensFornecedor
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(409, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(256, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Cadastro Itens";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(103, 132);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(880, 31);
            this.txt_nome.TabIndex = 45;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(103, 222);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(203, 31);
            this.txt_quantidade.TabIndex = 46;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(416, 222);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(211, 31);
            this.txt_valor.TabIndex = 47;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(771, 222);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(212, 31);
            this.txt_status.TabIndex = 48;
            // 
            // dgv_itens
            // 
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(103, 286);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(880, 286);
            this.dgv_itens.TabIndex = 64;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(103, 608);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 50;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(436, 608);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(204, 55);
            this.btn_excluir.TabIndex = 51;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(771, 608);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 52;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(98, 104);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(150, 25);
            this.lbl_nome.TabIndex = 65;
            this.lbl_nome.Text = "Nome do item:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(411, 194);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(145, 25);
            this.lbl_valor.TabIndex = 66;
            this.lbl_valor.Text = "Valor do item:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(98, 194);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(204, 25);
            this.lbl_quantidade.TabIndex = 67;
            this.lbl_quantidade.Text = "Quantidade de itens:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(766, 194);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(82, 25);
            this.lbl_status.TabIndex = 68;
            this.lbl_status.Text = "Status :";
            // 
            // Frm_CadastroItensFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 719);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_CadastroItensFornecedor";
            this.Text = "Cadastro Itens";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_status;
    }
}