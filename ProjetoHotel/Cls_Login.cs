using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    class Cls_Login
    {
        private string login;
        private string senha;
        private string tipo;

        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                this.senha = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public bool logar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = "SELECT * FROM login WHERE login ='" + this.login + "' and senha='" + this.senha + "' LIMIT 1;"; //monta o comando 

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();                

                if (dr.Read())
                {
                    this.tipo = dr["tipo"].ToString();

                    if (this.login == dr["login"].ToString() && (this.senha) == dr["senha"].ToString() && dr["ativo"].ToString() == "SIM")
                    {
                        return true;
                    }
                    else if (dr["ativo"].ToString() == "NAO")
                    {
                        MessageBox.Show("Usuário desativado, contate seu administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha divergentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}