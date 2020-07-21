using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevo3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Ingresar
        {


            Usuarios UsuarioOb = new Usuarios();
            UsuarioOb.Usuario = this.txt1.Text;

            UsuarioOb.Contraseña = this.txt2.Text;
            if (UsuarioOb.Buscar()== true)
            {

                //MessageBox.Show(UsuarioOb.Mensaje, "Login");

                this.Hide();
            }
            
            else
            {
                MessageBox.Show(UsuarioOb.Mensaje, "ERROR");
            }


        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // contraseña
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //usuario
        {

        }

        private void label3_Click(object sender, EventArgs e) 
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//ConfirmarContraseña
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
