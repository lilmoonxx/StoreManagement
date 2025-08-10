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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void volvBttn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void exitBttn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDataSet);

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.storeDataSet.Producto);

        }

        private void aggBttn_Click(object sender, EventArgs e)
        {
            Details details = new Details();

            details.ShowDialog();

            this.productoTableAdapter.Fill(this.storeDataSet.Producto);
        }

        private void deleteBttn2_Click(object sender, EventArgs e)
        {
            if (productoDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in productoDataGridView.SelectedRows)
                {
                    if (!row.IsNewRow)
                        productoDataGridView.Rows.Remove(row);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void productoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
