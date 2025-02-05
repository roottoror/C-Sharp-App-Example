using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=haydarb;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=false;trusted_connection=true");
            baglan.Open();
            return baglan;
        }
    }
}
