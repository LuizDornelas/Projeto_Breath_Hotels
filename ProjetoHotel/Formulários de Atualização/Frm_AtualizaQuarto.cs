﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Frm_AtualizaQuarto : Form
    {
        public Frm_AtualizaQuarto()
        {
            InitializeComponent();

            cmb_tipo.Items.Clear();
            cmb_tipo.Items.Add("Simples");
            cmb_tipo.Items.Add("Luxo");
            atualizadtg();
            attComboBox();            
        }
        public void attComboBox()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string combobox = "select quarto from quartos order by quarto;";

                NpgsqlCommand cmd = new NpgsqlCommand(combobox, pgsqlConnection);

                NpgsqlDataReader comboboxshow = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(comboboxshow);

                cmb_quarto.DisplayMember = "quarto";

                cmb_quarto.DataSource = dt;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void atualizadtg()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "SELECT quarto, tipo, camasolteiro, camacasal, status, diaria from quartos order by quarto;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                if (dgv.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dgv);
                    dgv_quartos.DataSource = dt;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void btn_atualiza_dgv_Click(object sender, EventArgs e)
        {
            atualizadtg();
        }        

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (cmb_quarto.Text == "")
            {
                MessageBox.Show("Não há quartos registrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                Cls_Cadastro atualizaQuarto = new Cls_Cadastro();

                atualizaQuarto.Criterio = cmb_quarto.Text;
                atualizaQuarto.Nome = txt_quarto.Text.ToUpper();
                atualizaQuarto.Tipo = cmb_tipo.Text;
                atualizaQuarto.Camasolteiro = Convert.ToInt16(msk_camasolteiro.Text);
                atualizaQuarto.Camacasal = Convert.ToInt16(msk_camacasal.Text);
                atualizaQuarto.Valor = msk_diaria.Text;

                if (atualizaQuarto.atualizaQuarto())
                {
                    MessageBox.Show("Quarto atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizadtg();                    
                }
            }
        }
        private void limpacampos()
        {
            txt_quarto.Text = "";
            msk_camasolteiro.Text = "";
            msk_camacasal.Text = "";
            msk_diaria.Text = "";
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (cmb_quarto.Text == "")
            {
                MessageBox.Show("Não há quartos registrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                Cls_Cadastro excluiQuarto = new Cls_Cadastro();

                excluiQuarto.Criterio = cmb_quarto.Text;

                DialogResult excluir = new DialogResult();

                excluir = MessageBox.Show($"Tem certeza que deseja excluir o quarto {excluiQuarto.Criterio}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (excluir == DialogResult.Yes)
                {
                    if (excluiQuarto.excluiQuarto())
                    {
                        MessageBox.Show("Quarto excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpacampos();
                        atualizadtg();
                        attComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("O quarto não foi excluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void cmb_quarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Cadastro pesquisa = new Cls_Cadastro();

            pesquisa.Criterio = cmb_quarto.Text;

            if (pesquisa.pesquisaQuarto())
            {
                txt_quarto.Text = pesquisa.Nome;
                cmb_tipo.Text = pesquisa.Tipo;
                msk_camasolteiro.Text = Convert.ToString(pesquisa.Camasolteiro);
                msk_camacasal.Text = Convert.ToString(pesquisa.Camacasal);
                msk_diaria.Text = pesquisa.Valor;
            }
        }
    }
}