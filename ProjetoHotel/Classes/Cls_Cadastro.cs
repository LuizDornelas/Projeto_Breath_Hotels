
using Npgsql;
using System;
using System.Windows.Forms;

namespace ProjetoHotel
{
    class Cls_Cadastro
    {
        private string nome;
        private string nome2;
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
        private string validade;
        private string codigo;
        private string bandeira;
        private int camasolteiro;
        private int camacasal;
        private string valor;
        private string valor2;
        private int quantidade;
        public int Quantidade
        {
            get
            {
                return this.quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }
        public string Valor2
        {
            get
            {
                return this.valor2;
            }
            set
            {
                this.valor2 = value;
            }
        }
        public int Camasolteiro
        {
            get
            {
                return this.camasolteiro;
            }
            set
            {
                this.camasolteiro = value;
            }
        }
        public int Camacasal
        {
            get
            {
                return this.camacasal;
            }
            set
            {
                this.camacasal = value;
            }
        }
        public string Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.valor = value;
            }
        }
        public string Nome2
        {
            get
            {
                return this.nome2;
            }
            set
            {
                this.nome2 = value;
            }
        }
        public string Validiade
        {
            get
            {
                return this.validade;
            }
            set
            {
                this.validade = value;
            }
        }
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public string Bandeira
        {
            get
            {
                return this.bandeira;
            }
            set
            {
                this.bandeira = value;
            }
        }
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

                string usersearch = "select count(login) from login where login = '" + this.login + "';";

                cmd = new NpgsqlCommand(usersearch, pgsqlConnection);

                NpgsqlDataReader userlogin = cmd.ExecuteReader();

                userlogin.Read();

                int qntlogin = Convert.ToInt16(userlogin["count"].ToString());

                userlogin.Close();

                if (qntlogin == 0)
                {
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
                else
                {
                    MessageBox.Show("Este login já existe, por favor insira outro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool pesquisar(string tipo)
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

                    if (pesquisa["tipo"].ToString() == "Admin" && tipo == "Cargo: Func")
                    {
                        MessageBox.Show("Não é possível atualizar este usuário com o seu login", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (pesquisa["tipo"].ToString() == "Func" && tipo == "Cargo: Func")
                    {
                        MessageBox.Show("Não é possível atualizar este usuário com o seu login", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
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
                }
                else
                {
                    MessageBox.Show("Não foi encontrado cadastro com os critérios informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                this.pesquisaid = Convert.ToInt32(this.pesquisa);
                atualizausuario = "UPDATE usuario SET nome='" + this.nome + "', rg='" + this.rg + "', telefone='" + this.telefone + "', rua='" + this.rua + "', numero='" + this.numero + "', bairro='" + this.bairro + "', cidade='" + this.cidade + "', estado='" + this.estado + "', cep='" + this.cep + "', ativo='" + this.ativo + "' where usuarioid = " + this.pesquisaid + ";";
                atualizalogin = "UPDATE login SET ativo='" + this.ativo + "', login='" + this.login + "', senha='" + this.senha + "', tipo='" + this.tipo + "' where fk_usuario = " + this.pesquisaid + ";";

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
        public bool pesquisar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select nome, rg from usuario where usuarioid = '" + this.criterio + "' and ativo = 'SIM' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.nome = pesquisa["nome"].ToString();
                    this.rg = pesquisa["rg"].ToString();
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
        public bool cadastroCartao(string id)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select count(usuariofk) from cartao where usuariofk = '" + id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader cartoes = cmd.ExecuteReader();

                cartoes.Read();

                int qntcartoes = Convert.ToInt16(cartoes["count"].ToString());

                cartoes.Close();

                querry = "select ativo from usuario where usuarioid = '" + id + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader ativo = cmd.ExecuteReader();

                ativo.Read();

                string verificaAtivo = ativo["ativo"].ToString();

                ativo.Close();

                if (qntcartoes == 0 && verificaAtivo == "SIM")
                {
                    querry = "INSERT INTO cartao(numerocartao, nome, validade, codigo, bandeira, usuariofk) VALUES ('" + this.numero + "', '" + this.nome + "', '" + this.validade + "', '" + this.codigo + "', '" + this.bandeira + "', '" + id + "');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader cadastraCartao = cmd.ExecuteReader();

                    cadastraCartao.Close();

                    return true;
                }
                else if (verificaAtivo != "SIM")
                {
                    MessageBox.Show("Usuário desativado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Usuário já tem cartão cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool pesquisarCartao()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select numerocartao, nome, validade, codigo, bandeira from cartao where usuariofk = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.numero = pesquisa["numerocartao"].ToString();
                    this.nome = pesquisa["nome"].ToString();
                    this.validade = pesquisa["validade"].ToString();
                    this.codigo = pesquisa["codigo"].ToString();
                    this.bandeira = pesquisa["bandeira"].ToString();

                    pesquisa.Close();

                    pesquisar = "select nome from usuario where usuarioid = '" + this.criterio + "';";

                    cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                    NpgsqlDataReader pesquisa2 = cmd.ExecuteReader();

                    pesquisa2.Read();

                    this.nome2 = pesquisa2["nome"].ToString();

                    pesquisa2.Close();

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
        public bool atualizaCartao()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string atualiza;

                atualiza = "UPDATE cartao SET numerocartao= '" + this.numero + "', nome= '" + this.nome + "', validade= '" + this.validade + "', codigo= '" + this.codigo + "', bandeira= '" + this.bandeira + "' where usuariofk = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(atualiza, pgsqlConnection);

                NpgsqlDataReader atualizar = cmd.ExecuteReader();

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool cadastroQuarto()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select count(quarto) from quartos where quarto = '" + this.nome + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartoresult = cmd.ExecuteReader();

                quartoresult.Read();

                int qntquarto = Convert.ToInt16(quartoresult["count"].ToString());

                quartoresult.Close();

                if (qntquarto == 0)
                {
                    querry = "INSERT INTO quartos(quarto, tipo, camasolteiro, camacasal, status, diaria) VALUES ('" + this.nome + "', '" + this.tipo + "', '" + this.camasolteiro + "', '" + this.camacasal + "', 'Disponível', '" + this.valor + "');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader quarto = cmd.ExecuteReader();

                    quarto.Close();

                    return true;
                }
                else
                {
                    MessageBox.Show("Este quarto já existe, por favor insira outro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool pesquisaQuarto()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select quarto, tipo, camasolteiro, camacasal, diaria from quartos where quarto = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartoresult = cmd.ExecuteReader();

                if (quartoresult.Read())
                {
                    this.nome = quartoresult["quarto"].ToString();
                    this.tipo = quartoresult["tipo"].ToString();
                    this.camasolteiro = Convert.ToInt16(quartoresult["camasolteiro"].ToString());
                    this.camacasal = Convert.ToInt16(quartoresult["camacasal"].ToString());
                    this.valor = quartoresult["diaria"].ToString();

                    quartoresult.Close();

                    querry = "select count(status) from quartos where quarto = '" + this.criterio + "' and status = 'Ocupado';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader quartostatus = cmd.ExecuteReader();

                    quartostatus.Read();

                    int quarto_status = Convert.ToInt16(quartostatus["count"].ToString());

                    if (quarto_status == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este quarto está ocupado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Este quarto não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool atualizaQuarto()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select quarto, tipo, camasolteiro, camacasal, diaria from quartos where quarto = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartoresult = cmd.ExecuteReader();

                if (quartoresult.Read())
                {
                    quartoresult.Close();

                    querry = "select count(status) from quartos where quarto = '" + this.criterio + "' and status = 'Ocupado';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader quartostatus = cmd.ExecuteReader();

                    quartostatus.Read();

                    int quarto_status = Convert.ToInt16(quartostatus["count"].ToString());

                    quartostatus.Close();

                    if (quarto_status == 0)
                    {
                        querry = "UPDATE quartos SET quarto='" + this.nome + "', tipo='" + this.tipo + "', camasolteiro='" + this.camasolteiro + "', camacasal='" + this.camacasal + "', diaria='" + this.valor + "' WHERE quarto = '" + this.criterio + "';";

                        cmd = new NpgsqlCommand(querry, pgsqlConnection);

                        NpgsqlDataReader attQuarto = cmd.ExecuteReader();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este quarto está ocupado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Este quarto não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool excluiQuarto()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select quarto, tipo, camasolteiro, camacasal, diaria from quartos where quarto = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader quartoresult = cmd.ExecuteReader();

                if (quartoresult.Read())
                {
                    quartoresult.Close();

                    querry = "select count(status) from quartos where quarto = '" + this.criterio + "' and status = 'Ocupado';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader quartostatus = cmd.ExecuteReader();

                    quartostatus.Read();

                    int quarto_status = Convert.ToInt16(quartostatus["count"].ToString());

                    quartostatus.Close();

                    if (quarto_status == 0)
                    {
                        querry = "DELETE FROM quartos WHERE quarto = '" + this.criterio + "';";

                        cmd = new NpgsqlCommand(querry, pgsqlConnection);

                        NpgsqlDataReader excluir = cmd.ExecuteReader();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este quarto está ocupado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Este quarto não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool excluiCartao()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "SELECT cartaoid, numerocartao, nome, validade, codigo, bandeira, usuariofk FROM cartao where usuariofk = '" + this.criterio + "';;";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader cartaoresult = cmd.ExecuteReader();

                if (cartaoresult.Read())
                {
                    DialogResult Dialogexcluir = new DialogResult();

                    Dialogexcluir = MessageBox.Show($"Excluir cartão nº: {cartaoresult["numerocartao"].ToString()}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Dialogexcluir == DialogResult.Yes)
                    {
                        cartaoresult.Close();

                        querry = "DELETE FROM cartao WHERE usuariofk = '" + this.criterio + "';";

                        cmd = new NpgsqlCommand(querry, pgsqlConnection);

                        NpgsqlDataReader excluir = cmd.ExecuteReader();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O cartão não foi excluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Não há cartão cadastrado para este usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool cadastroItens()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select item from itens where item = '" + this.nome + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader itemsearch = cmd.ExecuteReader();

                if (itemsearch.Read())
                {
                    MessageBox.Show("Já existe um item cadastrado com este nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    itemsearch.Close();

                    querry = "INSERT INTO itens(item, valor, quantidade, status) VALUES ('" + this.nome + "', '" + this.valor + "', '" + this.quantidade + "', 'Disponivel');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader cadItem = cmd.ExecuteReader();

                    cadItem.Close();

                    querry = "select itemid from itens where item = '" + this.nome + "';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader searchId = cmd.ExecuteReader();

                    searchId.Read();

                    string IdSearched = searchId["itemid"].ToString();

                    searchId.Close();

                    querry = "INSERT INTO fornecedor(nome_fornecedor, valor_item, itemfk) VALUES ('" + this.nome2 + "', '" + this.valor2 + "', '" + IdSearched + "');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader cadFornecedor = cmd.ExecuteReader();

                    return true;

                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool pesquisaItem()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select item, valor, quantidade, nome_fornecedor, valor_item from itens, fornecedor where itemid = itemfk and item = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader itemresult = cmd.ExecuteReader();

                itemresult.Read();

                this.nome = itemresult["item"].ToString();
                this.nome2 = itemresult["nome_fornecedor"].ToString();
                this.quantidade = Convert.ToInt16(itemresult["quantidade"].ToString());
                this.valor = itemresult["valor"].ToString();
                this.valor2 = itemresult["valor_item"].ToString();
                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool atualizaItens()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "UPDATE itens SET item='" + this.nome + "', valor='" + this.valor + "', WHERE item = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader itemAtt = cmd.ExecuteReader();

                itemAtt.Close();

                querry = "select itemid from itens where item = '" + this.nome + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader searchId = cmd.ExecuteReader();

                searchId.Read();

                string IdSearched = searchId["itemid"].ToString();

                searchId.Close();

                querry = "UPDATE fornecedor SET nome_fornecedor='" + this.nome2 + "', valor_item='" + this.valor2 + "' WHERE itemfk='" + IdSearched + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader fornecedorAtt = cmd.ExecuteReader();

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool excluiItem()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select itemid from itens where item = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader searchId = cmd.ExecuteReader();

                searchId.Read();

                string IdSearched = searchId["itemid"].ToString();

                searchId.Close();

                querry = "DELETE FROM fornecedor WHERE itemfk = '" + IdSearched + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader excluir = cmd.ExecuteReader();

                excluir.Close();

                querry = "DELETE FROM itens WHERE item = '" + this.criterio + "';";

                cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader excluir2 = cmd.ExecuteReader();

                excluir.Close();

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}