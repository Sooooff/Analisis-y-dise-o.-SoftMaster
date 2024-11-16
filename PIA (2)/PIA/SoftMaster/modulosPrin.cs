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
   public partial class modulosPrin : Form
   {
      public modulosPrin()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void bInventario_Click(object sender, EventArgs e)
      {
         InventarioForm InventarioForm = new InventarioForm();
         InventarioForm.Show();
      }
   }
}
