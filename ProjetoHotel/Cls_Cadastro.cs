
using Npgsql;
using System;

namespace ProjetoHotel
{
    class Cls_Cadastro
    {
        private string nome;
        private string rg;
        private string telefone;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string login;
        private string senha;
        private string tipo;
        private string fk;
        private int fk_int;

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
        public string Rg
        {
            get
            {
                return this.rg;
            }
            set
            {
                this.rg = value;
            }
        }
        public string Telefone
        {
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }
        }
        public string Rua
        {
            get
            {
                return this.rua;
            }
            set
            {
                this.rua = value;
            }
        }
        public string Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public string Bairro
        {
            get
            {
                return this.bairro;
            }
            set
            {
                this.bairro = value;
            }
        }
        public string Cidade
        {
            get
            {
                return this.cidade;
            }
            set
            {
                this.cidade = value;
            }
        }
        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string Cep
        {
            get
            {
                return this.cep;
            }
            set
            {
                this.cep = value;
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
        public bool cadastro()
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string fk_user = "select count(usuarioid) from usuario;";

                NpgsqlCommand cmd = new NpgsqlCommand(fk_user, pgsqlConnection);

                NpgsqlDataReader fk_usuario = cmd.ExecuteReader();

                if (fk_usuario.Read())
                {
                    this.fk = fk_usuario["count"].ToString();                    

                    this.fk_int = Convert.ToInt32(this.fk);

                    this.fk_int += 1;
                }
                fk_usuario.Close();                

                string user = "INSERT INTO public.usuario(usuarioid, nome, rg, telefone, rua, numero, bairro, cidade, estado, cep, ativo) VALUES ('" + this.fk_int + "', '" + this.nome + "', '" + this.rg + "', '" + this.telefone + "', '" + this.rua + "', '" + this.numero + "', '" + this.bairro + "', '" + this.cidade + "', '" + this.estado + "', '" + this.cep + "', 'SIM');";

                cmd = new NpgsqlCommand(user, pgsqlConnection);

                NpgsqlDataReader usuario = cmd.ExecuteReader();

                usuario.Close();

                string loginq = "INSERT INTO public.login(loginid, login, senha, ativo, tipo, fk_usuario) VALUES ('" + this.fk_int + "', '" + this.login + "', '" + this.senha + "', 'SIM', '" + this.tipo + "', '" + this.fk_int + "');";

                cmd = new NpgsqlCommand(loginq, pgsqlConnection);

                NpgsqlDataReader login = cmd.ExecuteReader();

                login.Close();

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
