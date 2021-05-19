
namespace ProjetoHotel.Formulários_de_Atualização
{
    partial class Frm_AtualizaItensFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtualizaItensFornecedor));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_nome_item = new System.Windows.Forms.TextBox();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_nome_fornecedor = new System.Windows.Forms.Label();
            this.txt_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.lbl_valor_compra = new System.Windows.Forms.Label();
            this.btn_atualiza_dgv = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.txt_valor_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_valor_item = new System.Windows.Forms.TextBox();
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
            this.lbl_titulo.Location = new System.Drawing.Point(290, 44);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(474, 56);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Atualiza Itens Consumíveis";
            // 
            // txt_nome_item
            // 
            this.txt_nome_item.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_item.Location = new System.Drawing.Point(344, 155);
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
            this.dgv_itens.Location = new System.Drawing.Point(128, 327);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(821, 169);
            this.dgv_itens.TabIndex = 64;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(344, 123);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(131, 28);
            this.lbl_nome.TabIndex = 65;
            this.lbl_nome.Text = "Nome do item:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(632, 123);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(124, 28);
            this.lbl_valor.TabIndex = 66;
            this.lbl_valor.Text = "Valor do item:";
            // 
            // lbl_nome_fornecedor
            // 
            this.lbl_nome_fornecedor.AutoSize = true;
            this.lbl_nome_fornecedor.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_fornecedor.Location = new System.Drawing.Point(344, 220);
            this.lbl_nome_fornecedor.Name = "lbl_nome_fornecedor";
            this.lbl_nome_fornecedor.Size = new System.Drawing.Size(186, 28);
            this.lbl_nome_fornecedor.TabIndex = 85;
            this.lbl_nome_fornecedor.Text = "Nome do Fornecedor:";
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(344, 251);
            this.txt_nome_fornecedor.MaxLength = 20;
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(249, 31);
            this.txt_nome_fornecedor.TabIndex = 84;
            // 
            // lbl_valor_compra
            // 
            this.lbl_valor_compra.AutoSize = true;
            this.lbl_valor_compra.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_compra.Location = new System.Drawing.Point(632, 220);
            this.lbl_valor_compra.Name = "lbl_valor_compra";
            this.lbl_valor_compra.Size = new System.Drawing.Size(170, 28);
            this.lbl_valor_compra.TabIndex = 86;
            this.lbl_valor_compra.Text = "Valor para compra:";
            // 
            // btn_atualiza_dgv
            // 
            this.btn_atualiza_dgv.Image = global::ProjetoHotel.Properties.Resources.refresh;
            this.btn_atualiza_dgv.Location = new System.Drawing.Point(297, 245);
            this.btn_atualiza_dgv.Name = "btn_atualiza_dgv";
            this.btn_atualiza_dgv.Size = new System.Drawing.Size(41, 43);
            this.btn_atualiza_dgv.TabIndex = 83;
            this.btn_atualiza_dgv.UseVisualStyleBackColor = true;
            this.btn_atualiza_dgv.Click += new System.EventHandler(this.btn_atualiza_dgv_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(442, 522);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(204, 55);
            this.btn_excluir.TabIndex = 107;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(700, 522);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 106;
            this.btn_salvar.Text = "Atualizar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(112)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(169, 522);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 105;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa.Location = new System.Drawing.Point(123, 123);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(138, 28);
            this.lbl_pesquisa.TabIndex = 108;
            this.lbl_pesquisa.Text = "Pesquisar Item:";
            // 
            // cmb_item
            // 
            this.cmb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.IntegralHeight = false;
            this.cmb_item.Location = new System.Drawing.Point(128, 155);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(152, 36);
            this.cmb_item.TabIndex = 111;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.cmb_item_SelectedIndexChanged);
            // 
            // txt_valor_fornecedor
            // 
            this.txt_valor_fornecedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_fornecedor.Location = new System.Drawing.Point(637, 251);
            this.txt_valor_fornecedor.MaxLength = 20;
            this.txt_valor_fornecedor.Name = "txt_valor_fornecedor";
            this.txt_valor_fornecedor.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_fornecedor.TabIndex = 112;
            this.txt_valor_fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_fornecedor_KeyPress);
            // 
            // txt_valor_item
            // 
            this.txt_valor_item.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_item.Location = new System.Drawing.Point(637, 160);
            this.txt_valor_item.MaxLength = 20;
            this.txt_valor_item.Name = "txt_valor_item";
            this.txt_valor_item.Size = new System.Drawing.Size(135, 31);
            this.txt_valor_item.TabIndex = 113;
            this.txt_valor_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_item_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_AtualizaItensFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 644);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_valor_item);
            this.Controls.Add(this.txt_valor_fornecedor);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_valor_compra);
            this.Controls.Add(this.lbl_nome_fornecedor);
            this.Controls.Add(this.txt_nome_fornecedor);
            this.Controls.Add(this.btn_atualiza_dgv);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.txt_nome_item);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_AtualizaItensFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Atualiza Itens";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_AtualizaItensFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_nome_item;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_atualiza_dgv;
        private System.Windows.Forms.Label lbl_nome_fornecedor;
        private System.Windows.Forms.TextBox txt_nome_fornecedor;
        private System.Windows.Forms.Label lbl_valor_compra;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.TextBox txt_valor_fornecedor;
        private System.Windows.Forms.TextBox txt_valor_item;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}