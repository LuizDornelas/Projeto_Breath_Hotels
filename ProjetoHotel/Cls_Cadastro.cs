
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
        private string criterio;
        private string pesquisa;
        private int pesquisaid;
        private string ativo;
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
        public string Criterio
        {
            get
            {
                return this.criterio;
            }
            set
            {
                this.criterio = value;
            }
        }
        public string Pesquisa
        {
            get
            {
                return this.pesquisa;
            }
            set
            {
                this.pesquisa = value;
            }
        }
        public string Ativo
        {
            get
            {
                return this.ativo;
            }
            set
            {
                this.ativo = value;
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
        public bool pesquisar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                if (this.criterio == "Id")
                {
                    pesquisar = "select nome, rg, telefone, rua, numero, bairro, cidade, login.ativo, estado, cep, login, senha, tipo from usuario, login where usuarioid = fk_usuario and usuarioid = '" + this.pesquisa + "' LIMIT 1;";
                }
                else if (this.criterio == "Nome")
                {
                    pesquisar = "select nome, rg, telefone, rua, numero, bairro, cidade, login.ativo, estado, cep, login, senha, tipo from usuario, login where usuarioid = fk_usuario and nome like '%" + this.pesquisa + "%' LIMIT 1;";
                }
                else if (this.criterio == "RG")
                {
                    pesquisar = "select nome, rg, telefone, rua, numero, bairro, cidade, login.ativo, estado, cep, login, senha, tipo from usuario, login where usuarioid = fk_usuario and rg = '" + this.pesquisa + "' LIMIT 1;";
                }
                else
                {
                    pesquisar = "select nome, rg, telefone, rua, numero, bairro, cidade, login.ativo, estado, cep, login, senha, tipo from usuario, login where usuarioid = fk_usuario and telefone = '" + this.pesquisa + "' LIMIT 1;";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.nome = pesquisa["nome"].ToString();
                    this.rg = pesquisa["rg"].ToString();
                    this.telefone = pesquisa["telefone"].ToString();
                    this.rua = pesquisa["rua"].ToString();
                    this.numero = pesquisa["numero"].ToString();
                    this.bairro = pesquisa["bairro"].ToString();
                    this.cidade = pesquisa["cidade"].ToString();
                    this.ativo = pesquisa["ativo"].ToString();
                    this.estado = pesquisa["estado"].ToString();
                    this.cep = pesquisa["cep"].ToString();
                    this.login = pesquisa["login"].ToString();
                    this.senha = pesquisa["senha"].ToString();
                    this.tipo = pesquisa["tipo"].ToString();

                    return true;
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
        public bool atualiza()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string atualizausuario;
                string atualizalogin;

                if (this.criterio == "Id")
                {
                    this.pesquisaid = Convert.ToInt32(this.pesquisa);
                    atualizausuario = "UPDATE usuario SET nome='" + this.nome + "', rg='" + this.rg + "', telefone='" + this.telefone + "', rua='" + this.rua + "', numero='" + this.numero + "', bairro='" + this.bairro + "', cidade='" + this.cidade + "', estado='" + this.estado + "', cep='" + this.cep + "', ativo='" + this.ativo + "' where usuarioid = " + this.pesquisaid + ";";
                    atualizalogin = "UPDATE login SET ativo='" + this.ativo + "', login='" + this.login + "', senha='" + this.senha + "', tipo='" + this.tipo + "' where fk_usuario = " + this.pesquisaid + ";";
                }
                else if (this.criterio == "Nome")
                {                    
                    atualizausuario = "UPDATE usuario SET nome='" + this.nome + "', rg='" + this.rg + "', telefone='" + this.telefone + "', rua='" + this.rua + "', numero='" + this.numero + "', bairro='" + this.bairro + "', cidade='" + this.cidade + "', estado='" + this.estado + "', cep='" + this.cep + "', ativo='" + this.ativo + "' where nome like '%"+ this.nome +"%';";
                    atualizalogin = "UPDATE login SET ativo='" + this.ativo + "', login='" + this.login + "', senha='" + this.senha + "', tipo='" + this.tipo + "' where fk_usuario = (select usuarioid from usuario where nome like '%" + this.nome + "%');";
                }
                else if (this.criterio == "RG")
                {                    
                    atualizausuario = "UPDATE usuario SET nome='" + this.nome + "', rg='" + this.rg + "', telefone='" + this.telefone + "', rua='" + this.rua + "', numero='" + this.numero + "', bairro='" + this.bairro + "', cidade='" + this.cidade + "', estado='" + this.estado + "', cep='" + this.cep + "', ativo='" + this.ativo + "' where rg = '" + this.rg + "';";
                    atualizalogin = "UPDATE login SET ativo='" + this.ativo + "', login='" + this.login + "', senha='" + this.senha + "', tipo='" + this.tipo + "' where fk_usuario = (select usuarioid from usuario where rg = '" + this.rg + "');";
                }
                else
                {                    
                    atualizausuario = "UPDATE usuario SET nome='" + this.nome + "', rg='" + this.rg + "', telefone='" + this.telefone + "', rua='" + this.rua + "', numero='" + this.numero + "', bairro='" + this.bairro + "', cidade='" + this.cidade + "', estado='" + this.estado + "', cep='" + this.cep + "', ativo='" + this.ativo + "' where telefone = '" + this.telefone + "';";
                    atualizalogin = "UPDATE login SET ativo='" + this.ativo + "', login='" + this.login + "', senha='" + this.senha + "', tipo='" + this.tipo + "' where fk_usuario = (select usuarioid from usuario where telefone = '" + this.telefone + "');";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(atualizausuario, pgsqlConnection);

                NpgsqlDataReader atualizauser = cmd.ExecuteReader();

                atualizauser.Close();

                cmd = new NpgsqlCommand(atualizalogin, pgsqlConnection);

                NpgsqlDataReader atualizarlogin = cmd.ExecuteReader();

                atualizarlogin.Close();

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}