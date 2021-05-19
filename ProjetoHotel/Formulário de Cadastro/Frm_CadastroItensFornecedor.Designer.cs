
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.lbl_titulo.Location = new System.Drawing.Point(244, 48);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(492, 56);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Cadastro Itens Consumíveis";
            // 
            // txt_nome_item
            // 
            this.txt_nome_item.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_item.Location = new System.Drawing.Point(98, 192);
            this.txt_nome_item.MaxLength = 20;
            this.txt_nome_item.Name = "txt_nome_item";
            this.txt_nome_item.Size = new System.Drawing.Size(249, 31);
            this.txt_nome_item.TabIndex = 45;
            // 
            // dgv_itens
            // 
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_itens.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(98, 384);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(883, 242);
            this.dgv_itens.TabIndex = 64;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(254, 661);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(188, 69);
            this.btn_voltar.TabIndex = 50;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(547, 661);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(189, 69);
            this.btn_salvar.TabIndex = 52;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(93, 161);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(131, 28);
            this.lbl_nome.TabIndex = 65;
            this.lbl_nome.Text = "Nome do item:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(376, 161);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(124, 28);
            this.lbl_valor.TabIndex = 66;
            this.lbl_valor.Text = "Valor do item:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(552, 161);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(184, 28);
            this.lbl_quantidade.TabIndex = 67;
            this.lbl_quantidade.Text = "Quantidade de itens:";
            // 
            // msk_quantidade_itens
            // 
            this.msk_quantidade_itens.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_quantidade_itens.Location = new System.Drawing.Point(557, 192);
            this.msk_quantidade_itens.Mask = "999";
            this.msk_quantidade_itens.Name = "msk_quantidade_itens";
            this.msk_quantidade_itens.Size = new System.Drawing.Size(52, 31);
            this.msk_quantidade_itens.TabIndex = 69;
            // 
            // btn_atualiza_dgv
            // 
            this.btn_atualiza_dgv.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_dgv.Location = new System.Drawing.Point(568, 285);
            this.btn_atualiza_dgv.Name = "btn_atualiza_dgv";
            this.btn_atualiza_dgv.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_dgv.TabIndex = 83;
            this.btn_atualiza_dgv.UseVisualStyleBackColor = true;
            this.btn_atualiza_dgv.Click += new System.EventHandler(this.btn_atualiza_dgv_Click);
            // 
            // lbl_nome_fornecedor
            // 
            this.lbl_nome_fornecedor.AutoSize = true;
            this.lbl_nome_fornecedor.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_fornecedor.Location = new System.Drawing.Point(93, 254);
            this.lbl_nome_fornecedor.Name = "lbl_nome_fornecedor";
            this.lbl_nome_fornecedor.Size = new System.Drawing.Size(186, 28);
            this.lbl_nome_fornecedor.TabIndex = 85;
            this.lbl_nome_fornecedor.Text = "Nome do Fornecedor:";
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(98, 285);
            this.txt_nome_fornecedor.MaxLength = 20;
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(249, 31);
            this.txt_nome_fornecedor.TabIndex = 84;
            // 
            // lbl_valor_compra
            // 
            this.lbl_valor_compra.AutoSize = true;
            this.lbl_valor_compra.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_compra.Location = new System.Drawing.Point(376, 254);
            this.lbl_valor_compra.Name = "lbl_valor_compra";
            this.lbl_valor_compra.Size = new System.Drawing.Size(170, 28);
            this.lbl_valor_compra.TabIndex = 86;
            this.lbl_valor_compra.Text = "Valor para compra:";
            // 
            // txt_valor_item
            // 
            this.txt_valor_item.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_item.Location = new System.Drawing.Point(381, 192);
            this.txt_valor_item.MaxLength = 20;
            this.txt_valor_item.Name = "txt_valor_item";
            this.txt_valor_item.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_item.TabIndex = 114;
            this.txt_valor_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_item_KeyPress);
            // 
            // txt_valor_fornecedor
            // 
            this.txt_valor_fornecedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_fornecedor.Location = new System.Drawing.Point(381, 285);
            this.txt_valor_fornecedor.MaxLength = 20;
            this.txt_valor_fornecedor.Name = "txt_valor_fornecedor";
            this.txt_valor_fornecedor.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_fornecedor.TabIndex = 115;
            this.txt_valor_fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_fornecedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(617, 763);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "* Todos os campos são de preenchimento obrigatório";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_CadastroItensFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 797);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}