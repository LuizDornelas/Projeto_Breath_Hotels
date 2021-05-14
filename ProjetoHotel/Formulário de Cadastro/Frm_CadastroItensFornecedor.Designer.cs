
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroItensFornecedor));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_nome_item = new System.Windows.Forms.TextBox();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.msk_quantidade_itens = new System.Windows.Forms.MaskedTextBox();
            this.btn_atualiza_dgv = new System.Windows.Forms.Button();
            this.lbl_nome_fornecedor = new System.Windows.Forms.Label();
            this.txt_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.lbl_valor_compra = new System.Windows.Forms.Label();
            this.txt_valor_item = new System.Windows.Forms.TextBox();
            this.txt_valor_fornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(294, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(474, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Cadastro Itens Consumíveis";
            // 
            // txt_nome_item
            // 
            this.txt_nome_item.Location = new System.Drawing.Point(151, 116);
            this.txt_nome_item.MaxLength = 20;
            this.txt_nome_item.Name = "txt_nome_item";
            this.txt_nome_item.Size = new System.Drawing.Size(249, 31);
            this.txt_nome_item.TabIndex = 45;
            // 
            // dgv_itens
            // 
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(151, 254);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(756, 150);
            this.dgv_itens.TabIndex = 64;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(225, 433);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 50;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(626, 433);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 52;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(146, 88);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(150, 25);
            this.lbl_nome.TabIndex = 65;
            this.lbl_nome.Text = "Nome do item:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(476, 88);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(145, 25);
            this.lbl_valor.TabIndex = 66;
            this.lbl_valor.Text = "Valor do item:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(703, 88);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(204, 25);
            this.lbl_quantidade.TabIndex = 67;
            this.lbl_quantidade.Text = "Quantidade de itens:";
            // 
            // msk_quantidade_itens
            // 
            this.msk_quantidade_itens.Location = new System.Drawing.Point(708, 116);
            this.msk_quantidade_itens.Mask = "999";
            this.msk_quantidade_itens.Name = "msk_quantidade_itens";
            this.msk_quantidade_itens.Size = new System.Drawing.Size(135, 31);
            this.msk_quantidade_itens.TabIndex = 69;
            // 
            // btn_atualiza_dgv
            // 
            this.btn_atualiza_dgv.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_dgv.Location = new System.Drawing.Point(924, 254);
            this.btn_atualiza_dgv.Name = "btn_atualiza_dgv";
            this.btn_atualiza_dgv.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_dgv.TabIndex = 83;
            this.btn_atualiza_dgv.UseVisualStyleBackColor = true;
            this.btn_atualiza_dgv.Click += new System.EventHandler(this.btn_atualiza_dgv_Click);
            // 
            // lbl_nome_fornecedor
            // 
            this.lbl_nome_fornecedor.AutoSize = true;
            this.lbl_nome_fornecedor.Location = new System.Drawing.Point(279, 177);
            this.lbl_nome_fornecedor.Name = "lbl_nome_fornecedor";
            this.lbl_nome_fornecedor.Size = new System.Drawing.Size(215, 25);
            this.lbl_nome_fornecedor.TabIndex = 85;
            this.lbl_nome_fornecedor.Text = "Nome do Fornecedor:";
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(284, 205);
            this.txt_nome_fornecedor.MaxLength = 20;
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(249, 31);
            this.txt_nome_fornecedor.TabIndex = 84;
            // 
            // lbl_valor_compra
            // 
            this.lbl_valor_compra.AutoSize = true;
            this.lbl_valor_compra.Location = new System.Drawing.Point(609, 177);
            this.lbl_valor_compra.Name = "lbl_valor_compra";
            this.lbl_valor_compra.Size = new System.Drawing.Size(195, 25);
            this.lbl_valor_compra.TabIndex = 86;
            this.lbl_valor_compra.Text = "Valor para compra:";
            // 
            // txt_valor_item
            // 
            this.txt_valor_item.Location = new System.Drawing.Point(481, 116);
            this.txt_valor_item.MaxLength = 20;
            this.txt_valor_item.Name = "txt_valor_item";
            this.txt_valor_item.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_item.TabIndex = 114;
            this.txt_valor_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_item_KeyPress);
            // 
            // txt_valor_fornecedor
            // 
            this.txt_valor_fornecedor.Location = new System.Drawing.Point(614, 205);
            this.txt_valor_fornecedor.MaxLength = 20;
            this.txt_valor_fornecedor.Name = "txt_valor_fornecedor";
            this.txt_valor_fornecedor.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_fornecedor.TabIndex = 115;
            this.txt_valor_fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_fornecedor_KeyPress);
            // 
            // Frm_CadastroItensFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 505);
            this.ControlBox = false;
            this.Controls.Add(this.txt_valor_fornecedor);
            this.Controls.Add(this.txt_valor_item);
            this.Controls.Add(this.lbl_valor_compra);
            this.Controls.Add(this.lbl_nome_fornecedor);
            this.Controls.Add(this.txt_nome_fornecedor);
            this.Controls.Add(this.btn_atualiza_dgv);
            this.Controls.Add(this.msk_quantidade_itens);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.txt_nome_item);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_CadastroItensFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Itens";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_CadastroItensFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_nome_item;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.MaskedTextBox msk_quantidade_itens;
        private System.Windows.Forms.Button btn_atualiza_dgv;
        private System.Windows.Forms.Label lbl_nome_fornecedor;
        private System.Windows.Forms.TextBox txt_nome_fornecedor;
        private System.Windows.Forms.Label lbl_valor_compra;
        private System.Windows.Forms.TextBox txt_valor_item;
        private System.Windows.Forms.TextBox txt_valor_fornecedor;
    }
}