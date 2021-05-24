using Npgsql;

namespace ProjetoHotel
{
    class Cls_Conexao
    {

        public NpgsqlConnection getConexao()
        {            
            NpgsqlConnection pgsqlConnection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=myhome2030;Database=BreathHotels;");

            return pgsqlConnection;
        }
    }
}
