using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARIO_EQUIPOSINFORMATICOS
{
    internal class conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=192.168.10.2;DataBase=INVENTARIO_EQUIPOSINFORMATICOS;User=sa;Password=Hyp3rn10Pr0_;TrustServerCertificate=true");
        public void conectar()
        {
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public SqlConnection getConexion()
        {
            return cn;
        }

    }
}
