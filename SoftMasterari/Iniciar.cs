using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftMaster
{
   public partial class Form1 : Form
   {
      // Diccionario de usuarios y contraseñas predeterminados
      private Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "kelly", "12345" },
            { "jan", "abcde" },
            { "ariana", "00000" },
            { "ana", "3005" }
        };

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         
      }

      private void bIniciarSecion_Click(object sender, EventArgs e)
      {
         string usuarioIngresado = tbUsuario.Text;
         string contraseñaIngresada = tbContraseña.Text;

         // Validacion
         if (usuarios.ContainsKey(usuarioIngresado) && usuarios[usuarioIngresado] == contraseñaIngresada)
         {
            // Si las credenciales son correctas, mostrar un mensaje y ocultar el formulario
            MessageBox.Show("Inicio de sesión exitoso.");
            this.Hide();  // Ocultar el formulario de inicio de sesión

            //segunda pantalla
            modulosPrin modulosPrin = new modulosPrin();
            modulosPrin.Show();
         }
         else
         {
            // Si las credenciales son incorrectas, mostrar un mensaje de error
            MessageBox.Show("Usuario o contraseña incorrectos.");
            tbUsuario.Clear();
            tbContraseña.Clear();
            tbUsuario.Focus();
         }
      }

        private void lContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}

