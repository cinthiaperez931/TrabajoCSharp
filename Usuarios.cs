using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Nuevo3
{
    class Usuarios : Class1
    {
        private string usuario;
        private string contraseña;

        public Usuarios()

        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;


        }

        public string Usuario
        {

            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }

        }
        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }
            set { this.contraseña = value; }



        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT ID FROM USUARIO1  WHERE Nombre_Causante = '{0}' AND CONTRASEÑA ='{1}'", this.usuario, this.contraseña);
            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader Reg = null;

            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                // this.mensaje = "Bienvenido, Datos Correctos";


                Inicio abrir = new Inicio();
                abrir.Show();

                

                


            }

            else
            {
                this.mensaje = "Datos Incorrectos, Verifique porfavor";
            }

            this.cnn.Close();
            return Resultado;


        }



        
    }
}
