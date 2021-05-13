using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    class Cls_Checkin_Checkout
    {
        private string criterio;
        private string nome;
        private string nomefunc;
        private string rg;
        private string telefone;
        private double valor;
        private DateTime entrada;
        private DateTime saida;
        private string entradaout;
        private string saidaout;
        private string cama_solteiro;
        private string cama_casal;
        private string quarto;
        private string id;
        private double total;
        private string cartao;
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
        public string Cartao
        {
            get
            {
                return this.cartao;
            }
            set
            {
                this.cartao = value;
            }
        }
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Cama_solteiro
        {
            get
            {
                return this.cama_solteiro;
            }
            set
            {
                this.cama_solteiro = value;
            }
        }
        public string Cama_casal
        {
            get
            {
                return this.cama_casal;
            }
            set
            {
                this.cama_casal = value;
            }
        }
        public string Entradaout
        {
            get
            {
                return this.entradaout;
            }
            set
            {
                this.entradaout = value;
            }
        }
        public string Saidaout
        {
            get
            {
                return this.saidaout;
            }
            set
            {
                this.saidaout = value;
            }
        }
        public string Quarto
        {
            get
            {
                return this.quarto;
            }
            set
            {
                this.quarto = value;
            }
        }
        public DateTime Entrada
        {
            get
            {
                return this.entrada;
            }
            set
            {
                this.entrada = value;
            }
        }
        public DateTime Saida
        {
            get
            {
                return this.saida;
            }
            set
            {
                this.saida = value;
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
        public string Nomefunc
        {
            get
            {
                return this.nomefunc;
            }
            set
            {
                this.nomefunc = value;
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
        public double Valor
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
        public bool pesquisar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select nome, rg, telefone from usuario where usuarioid = '" + this.criterio + "' and ativo = 'SIM' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.nome = pesquisa["nome"].ToString();
                    this.rg = pesquisa["rg"].ToString();
                    this.telefone = pesquisa["telefone"].ToString();
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
        public bool pesquisaid()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select nomecli, entrada, saida, quartofk from reservas where reservaid = '" + this.criterio + "' and status = 'Em andamento' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.nome = pesquisa["nomecli"].ToString();
                    this.entradaout = pesquisa["entrada"].ToString();
                    this.saidaout = pesquisa["saida"].ToString();
                    this.quarto = pesquisa["quartofk"].ToString();
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
        public bool pesquisaquarto()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select reservaid, nomecli, entrada, saida, quartofk from reservas where quartofk = '" + this.criterio + "' and status = 'Em andamento' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.nome = pesquisa["nomecli"].ToString();
                    this.entradaout = pesquisa["entrada"].ToString();
                    this.saidaout = pesquisa["saida"].ToString();
                    this.quarto = pesquisa["quartofk"].ToString();
                    this.id = pesquisa["reservaid"].ToString();
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
        public bool checkin(string id)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry;

                querry = "select ativo from usuario where usuarioid = '" + id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader ativo = cmd.ExecuteReader();

                ativo.Read();

                string verificaAtivo = ativo["ativo"].ToString();

                ativo.Close();

                if (verificaAtivo == "SIM")
                {
                    string checkin;

                    checkin = "INSERT INTO reservas(reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status, usuariofk) VALUES((select count(reservaid) + 1 from reservas), '" + this.nomefunc + "', '" + this.nome + "', '" + this.entrada + "', '" + this.saida + "', " + this.valor + ", '" + this.quarto + "','Em andamento', '" + id + "');";

                    cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                    NpgsqlDataReader reserva = cmd.ExecuteReader();

                    reserva.Close();

                    checkin = "UPDATE quartos SET status='Ocupado', reservafk=(select reservaid from reservas where quartofk = '" + this.quarto + "' and status = 'Em andamento') WHERE quarto = '" + this.quarto + "';";

                    cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                    NpgsqlDataReader reservaquarto = cmd.ExecuteReader();

                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário desativado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool camas()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select camasolteiro, camacasal from quartos where quarto = '" + this.criterio + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    this.cama_solteiro = pesquisa["camasolteiro"].ToString();
                    this.cama_casal = pesquisa["camacasal"].ToString();
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
        public bool valortotal(int totalDias)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                double valor_reserva = 0;
                double valor_itens = 0;

                pesquisar = "select diaria from quartos where reservafk = '" + this.id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    valor_reserva = Convert.ToDouble(pesquisa["diaria"].ToString());
                }
                pesquisa.Close();

                valor_reserva *= totalDias;

                pesquisar = "select sum(valor * quantidade) from consumos where reservafk = '" + this.id + "';";

                cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    if (pesquisa["sum"].ToString() != "")
                    {
                        valor_itens = Convert.ToDouble(pesquisa["sum"].ToString());
                    }
                }

                this.total = valor_reserva + valor_itens;

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool pgto_dinheiro_cartao(string id, string total)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select usuariofk from reservas where reservaid = '" + id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader retornaId = cmd.ExecuteReader();

                retornaId.Read();

                string usuariofk = retornaId["usuariofk"].ToString();

                retornaId.Close();

                pesquisar = "UPDATE reservas SET status='Encerrado', valor = '" + total + "', saida = '" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' WHERE usuariofk = '" + usuariofk + "';";

                cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader atualizaReserva = cmd.ExecuteReader();

                atualizaReserva.Read();

                atualizaReserva.Close();

                pesquisar = "UPDATE quartos SET status='Disponível', reservafk=null WHERE reservafk = '" + id + "';";

                cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader liberaQuarto = cmd.ExecuteReader();

                liberaQuarto.Read();

                liberaQuarto.Close();

                pesquisar = "select count(usuariofk) from reservas where status = 'Em andamento' and usuariofk = '" + usuariofk + "';";

                cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader verificaReservas = cmd.ExecuteReader();

                verificaReservas.Read();

                int num_reservas = Convert.ToInt16(verificaReservas["count"].ToString());

                verificaReservas.Close();

                if (num_reservas == 0)
                {
                    pesquisar = "UPDATE usuario SET ativo='NAO' WHERE usuarioid = '" + usuariofk + "';";

                    cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                    NpgsqlDataReader desativaUsuario = cmd.ExecuteReader();

                    desativaUsuario.Read();

                    desativaUsuario.Close();

                    pesquisar = "UPDATE login SET ativo='NAO' WHERE fk_usuario = '" + usuariofk + "';";

                    cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                    NpgsqlDataReader desativaLogin = cmd.ExecuteReader();

                    desativaLogin.Read();

                    desativaLogin.Close();
                }

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool procura_cartao(string id)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string pesquisar;

                pesquisar = "select usuariofk from reservas where reservaid = '" + id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader retornaId = cmd.ExecuteReader();

                retornaId.Read();

                string usuariofk = retornaId["usuariofk"].ToString();

                retornaId.Close();

                pesquisar = "select count(usuariofk) from cartao where usuariofk = '" + usuariofk + "';";

                cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader procuraCartao = cmd.ExecuteReader();

                procuraCartao.Read();

                int qntCartao = Convert.ToInt16(procuraCartao["count"].ToString());

                procuraCartao.Close();

                if (qntCartao != 0)
                {
                    pesquisar = "select numerocartao from cartao where usuariofk = '" + usuariofk + "';";

                    cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                    NpgsqlDataReader retornaNum = cmd.ExecuteReader();

                    retornaNum.Read();

                    this.cartao = retornaNum["numerocartao"].ToString();

                    retornaNum.Close();

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
        public bool compra()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "select quantidade from itens where item = '"+ this.nome +"';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader verificaQuantidade = cmd.ExecuteReader();

                verificaQuantidade.Read();

                int qntAtual = Convert.ToInt16(verificaQuantidade["quantidade"].ToString());

                verificaQuantidade.Close();

                int totalQnt = qntAtual - this.quantidade;

                if (totalQnt < 0)
                {
                    MessageBox.Show("Quantidade maior do que há disponível!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (totalQnt == 0)
                    {
                        querry = "UPDATE itens set status = 'Indisponível' WHERE item = '" + this.nome + "';";

                        cmd = new NpgsqlCommand(querry, pgsqlConnection);

                        NpgsqlDataReader attStatus = cmd.ExecuteReader();

                        attStatus.Close();
                    }
                    querry = "select reservaid from reservas where quartofk = '" + this.criterio + "' and status = 'Em andamento';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader retornaId = cmd.ExecuteReader();

                    retornaId.Read();

                    string reservaid = retornaId["reservaid"].ToString();

                    retornaId.Close();

                    querry = "select itemid from itens where item = '" + this.nome + "';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader retornaItemId = cmd.ExecuteReader();

                    retornaItemId.Read();

                    string itemid = retornaItemId["itemid"].ToString();

                    retornaItemId.Close();

                    string totalbd = Convert.ToString(this.total).Replace(",", ".");                    
                    
                    querry = "INSERT INTO consumos(item, valor, quantidade, data, reservafk, itemfk) VALUES('" + this.nome + "', '" + totalbd + "', '" + this.quantidade + "', '" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "', '" + reservaid + "', '" + itemid + "');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader consumo = cmd.ExecuteReader();

                    consumo.Close();

                    querry = "UPDATE itens set quantidade = quantidade - '" + this.quantidade + "' WHERE item = '" + this.nome + "';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    NpgsqlDataReader attQnt = cmd.ExecuteReader();
                    
                    return true;
                }                
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
