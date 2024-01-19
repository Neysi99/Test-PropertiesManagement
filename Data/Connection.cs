using System.Data.SqlClient;


namespace PropertiesManagement.Data
{

    public class Connection
    {

        private String connectionSql = string.Empty;

        public Connection(){
            
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            connectionSql = builder.GetSection("ConnectionStrings:ConnectionSQL").Value;
    }

        public string getConnectionSQL()
        {
            return connectionSql;
        }

    }
}
