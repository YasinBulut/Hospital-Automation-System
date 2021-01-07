using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_1
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-FEPGLU4;Initial Catalog=HASTANEOTOMASYON;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
