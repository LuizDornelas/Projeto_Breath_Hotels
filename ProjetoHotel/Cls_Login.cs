using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                string sql = "SELECT * FROM login WHERE login ='" + this.login + "' and senha='" + this.senha + "' and ativo= 'SIM' LIMIT 1;"; //monta o comando 

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();                

                if (dr.Read())
                {
                    this.tipo = dr["tipo"].ToString();

                    if (this.login == dr["login"].ToString() && (this.senha) == dr["senha"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
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