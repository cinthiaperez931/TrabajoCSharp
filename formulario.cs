using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nuevo3
{
    public partial class Inicio : Form

    {
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

           ///this.Hide();

            this.Close();



        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            
          

            // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source =LAPTOP-03ABHNFQ;Initial Catalog =ReporteEntid; Integrated Security = True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select RENTA.RentaPromedio FROM Beneficiarios4 INNER JOIN Renta ON Beneficiarios4.RUT_BENEFICIARIO=Renta.Rut_Beneficiario", conexion);
        
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            dataGridView1.DataSource = tabla;
            conexion.Close();


        }
    }
}
