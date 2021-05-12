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
        private string nome;
        private string id;
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
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

                string sql = "SELECT * FROM login WHERE login ='" + this.login + "' and senha='" + this.senha + "' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();                

                if (dr.Read())
                {
                    this.tipo = dr["tipo"].ToString();

                    this.id = dr["fk_usuario"].ToString();

                    if (this.login == dr["login"].ToString() && (this.senha) == dr["senha"].ToString() && dr["ativo"].ToString() == "SIM")
                    {
                        dr.Close();
                        
                        sql = "select nome from usuario where usuarioid = '" + this.id + "';";

                        cmd = new NpgsqlCommand(sql, pgsqlConnection);

                        NpgsqlDataReader nomeLogin = cmd.ExecuteReader();

                        nomeLogin.Read();

                        this.nome = nomeLogin["nome"].ToString();

                        nomeLogin.Close();

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