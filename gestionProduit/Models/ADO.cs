using System.Data.SqlClient;
using System.Data;

namespace gestionProduit.Models
{
    public class ADO
    {
        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }
        public SqlDataAdapter adapter { get; set; }
        public SqlTransaction transaction { get; set; }
        public DataSet set { get; set; }
        public DataTable table { get; set; }

        public ADO()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samou\Desktop\gestionProduit\gestionProduit\App_Data\gestionproduit.mdf;Integrated Security=True");
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            set = new DataSet();
            table = new DataTable();
        }
    }
}