using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    class Cls_Checkin
    {
        private string criterio;
        private string nome;
        private string nomefunc;
        private string rg;
        private string telefone;
        private double valor;
        private DateTime entrada;
        private DateTime saida;
        private string quarto;
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

                pesquisar = "select nome, rg, telefone from usuario where usuarioid = '" + this.criterio + "' LIMIT 1;";

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
        public bool checkin()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Cls_Conexao objconexao = new Cls_Conexao();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string checkin;

                checkin = "INSERT INTO reservas(reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status) VALUES((select count(reservaid) + 1 from reservas), '" + this.nomefunc + "', '" + this.nome + "', '"+ this.entrada + "', '" + this.saida + "', " + this.valor + ", '"+ this.quarto +"','Em andamento');";

                NpgsqlCommand cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                NpgsqlDataReader reserva = cmd.ExecuteReader();

                reserva.Close();

                checkin = "UPDATE quartos SET status='Ocupado', reservafk=(select reservaid from reservas where quartofk = '"+ this.quarto +"') WHERE quarto = '"+ this.quarto +"';";

                cmd = new NpgsqlCommand(checkin, pgsqlConnection);

                NpgsqlDataReader reservaquarto = cmd.ExecuteReader();        

                return true;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
