using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cslearning.Infrastructure
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=animeco;User Id=postgres;Password=root;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
