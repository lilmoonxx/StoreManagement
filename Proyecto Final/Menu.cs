using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ventBttn_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            this.Hide();
        }

        private void invnBttn_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Hide();
        }

        private void volvBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitBttn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
