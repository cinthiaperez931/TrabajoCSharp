
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Nuevo3
{
    class Class1
    {
        public string cadenaconexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public Class1()
        {

            this.cadenaconexion = ("Data Source=LAPTOP-03ABHNFQ;Initial Catalog =ReporteEntid; Integrated Security = True");                      
            this.cnn = new SqlConnection(this.cadenaconexion);

        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;

            }
        }


    }
}
