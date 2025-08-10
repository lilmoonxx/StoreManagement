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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDataSet);

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.storeDataSet.Ventas);

        }

        private void exitBttn7_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
