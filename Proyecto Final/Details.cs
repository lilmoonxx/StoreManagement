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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDataSet);

        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.storeDataSet.Producto);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBttnn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDataSet);
        }
    }
}
