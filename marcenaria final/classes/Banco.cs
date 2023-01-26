using System.Data.SqlClient;


namespace marcenaria_final.classes
{
    public class Banco
    {
        public SqlConnection con = new SqlConnection("CONEXAO SQL");
    }
}
