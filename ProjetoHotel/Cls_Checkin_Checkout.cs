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

                pesquisar = "select nomecli, entrada, saida, quartofk from reservas where reservaid = '" + this.criterio + "' LIMIT 1;";

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

                pesquisar = "select reservaid, nomecli, entrada, saida, quartofk from reservas where quartofk = '" + this.criterio + "' LIMIT 1;";

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
        public bool checkin()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string checkin;

                checkin = "INSERT INTO reservas(reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status) VALUES((select count(reservaid) + 1 from reservas), '" + this.nomefunc + "', '" + this.nome + "', '" + this.entrada + "', '" + this.saida + "', " + this.valor + ", '" + this.quarto + "','Em andamento');";

                NpgsqlCommand cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                NpgsqlDataReader reserva = cmd.ExecuteReader();

                reserva.Close();

                checkin = "UPDATE quartos SET status='Ocupado', reservafk=(select reservaid from reservas where quartofk = '" + this.quarto + "') WHERE quarto = '" + this.quarto + "';";

                cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                NpgsqlDataReader reservaquarto = cmd.ExecuteReader();

                return true;
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
        public bool valortotal()
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

                pesquisar = "select valor from reservas where reservaid = '" + this.id + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(pesquisar, pgsqlConnection);

                NpgsqlDataReader pesquisa = cmd.ExecuteReader();

                if (pesquisa.Read())
                {
                    valor_reserva = Convert.ToDouble(pesquisa["valor"].ToString());
                }
                pesquisa.Close();

                pesquisar = "select sum(valor) from consumos where reservafk = '" + this.id + "';";

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
    }
}
