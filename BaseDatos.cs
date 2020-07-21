using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nuevo3
{
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/Cinthia/source/repos/Nuevo3/Nuevo3/Libro1.xlsx" + ";Extended Properties='Excel 12.0;IMEX=1;'";///Direccion donde esta ubicado el archivo


            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("Select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();

            adaptador.SelectCommand = consulta;
            DataSet ds = new DataSet();

            adaptador.Fill(ds); // recoge contenido que tiene adaptador

            dataGridView1.DataSource = ds.Tables[0];
            conector.Close();

            ///Data Source = LAPTOP - 03ABHNFQ; Initial Catalog = ReporteEntid; Integrated Security = True
            //----Exportar a SQL----



            SqlConnection conexion_receptora = new SqlConnection("Data Source=LAPTOP-03ABHNFQ; Initial Catalog = ReporteEntid; Integrated Security = True");//Pegar direccion ahi
            conexion_receptora.Open();

            SqlBulkCopy exportar = default(SqlBulkCopy);

            exportar = new SqlBulkCopy(conexion_receptora);

            exportar.DestinationTableName = "Beneficiarios4"; //nombre  de la tabla que creaste

            exportar.WriteToServer(ds.Tables[0]);

            conexion_receptora.Close();

            MessageBox.Show("Exportacion exitosa");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source =LAPTOP-03ABHNFQ;Initial Catalog =ReporteEntid; Integrated Security = True");
            conexion.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO RENTA VALUES (2,3,'14635886-7','ACEVEDO ITURRIETA' ,'CARINA DEL CARMEN' ,1,2,' ','Zenteno #580 Cerro Larrain',300000)", conexion);
            SqlCommand insercion = new SqlCommand("INSERT INTO RENTA VALUES(3,2,'13635889-8','AGUILAR CACERES' ,'FERNANDA ANTONIA',2,2,' ','Tocornal #550 Cerro Baron',170000)", conexion);
            SqlCommand insertar = new SqlCommand("INSERT INTO RENTA VALUES (4,1,'15635879-8','LOPEZ FREIRE' ,'CLAUDIO ANDRES',1,1,' ',' Papudo #479 Cerro Concepcion',250000)", conexion);
            SqlCommand cuarta = new SqlCommand("INSERT INTO RENTA VALUES(5,2,'11436718-4','ARREDONDO GUTIERREZ' ,'MATIAS ANTONIO',1,1,' ','Jorge Kenrick 35 Cerro San Roque',310000)",conexion);
            SqlCommand quinta = new SqlCommand("INSERT INTO RENTA VALUES(6,3,'18731809-7',' CARTER VASQUEZ' ,' JORGE GUILLERMO',2,1,' ','Castillo #389 Cerro Cordillera',580000)",conexion);
            SqlCommand sexta = new SqlCommand(" INSERT INTO RENTA VALUES(7,3,'15778385-6','CABELLO TAPIA' ,'CESAR ANTONIO',1,1,' ','Correa #58 Cerro Polanco',730000)",conexion);
            SqlCommand septima = new SqlCommand("INSERT INTO RENTA VALUES(8,2,'10881179-K','MARTINEZ ALMONACID' ,'SANDRA MARIA',1,2,' ','Lecheros #385 Cerro Lechero',1240000)",conexion);
            SqlCommand octava = new SqlCommand("INSERT INTO RENTA VALUES(9,2,'12229699-7','ALCORCE RAMIREZ' ,'EVELYN ANTONIA',2,2,' ','Cavareda #559 Cerro Florida',2250000)",conexion);
            SqlCommand novena = new SqlCommand("INSERT INTO RENTA VALUES(10,1,'13996678-3','VALENZUELA HERRERA' ,'OSCAR ARSENIO',2,1,' ','San Guillero #156 Cerro Placeres',880000)",conexion);
            SqlCommand decima = new SqlCommand(" INSERT INTO RENTA VALUES(1,2,'10031793-1','PIZARRO GONZALEZ' ,'RUBEN SANTOS',1,1,' ','Avenida Sandoval #389 Cerro Carcel',150000)",conexion);

            SqlCommand once = new SqlCommand("select * from Renta",conexion);

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            SqlDataAdapter adaptador3 = new SqlDataAdapter();
            SqlDataAdapter adaptador4 = new SqlDataAdapter();
            SqlDataAdapter adaptador5 = new SqlDataAdapter();
            SqlDataAdapter adaptador6 = new SqlDataAdapter();
            SqlDataAdapter adaptador7 = new SqlDataAdapter();
            SqlDataAdapter adaptador8 = new SqlDataAdapter();
            SqlDataAdapter adaptador9 = new SqlDataAdapter();
            SqlDataAdapter adaptador10 = new SqlDataAdapter();
            SqlDataAdapter adaptador11 = new SqlDataAdapter();

            adaptador1.SelectCommand = comando;
            adaptador2.SelectCommand = insercion;
            adaptador3.SelectCommand = insertar;
            adaptador4.SelectCommand = cuarta;
            adaptador5.SelectCommand = quinta;
            adaptador6.SelectCommand = sexta;
            adaptador7.SelectCommand = septima;
            adaptador8.SelectCommand = octava;
            adaptador9.SelectCommand = novena;
            adaptador10.SelectCommand = decima;
            adaptador11.SelectCommand = once;


            DataTable tabla = new DataTable();

            //DataTable tabla = new DataTable();
           /// DataTable tabla = new DataTable();

            adaptador1.Fill(tabla);
            adaptador2.Fill(tabla);
            adaptador3.Fill(tabla);
            adaptador4.Fill(tabla);
            adaptador5.Fill(tabla);
            adaptador6.Fill(tabla);
            adaptador7.Fill(tabla);
            adaptador8.Fill(tabla);
            adaptador9.Fill(tabla);
            adaptador10.Fill(tabla);
            adaptador11.Fill(tabla);

            //// adaptador.Fill(tabla);

            dataGridView1.DataSource = tabla;


            MessageBox.Show("Insercion exitosa");

            conexion.Close();
        }
    }
}
















