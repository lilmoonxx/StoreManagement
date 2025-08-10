using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.StoreDataSetTableAdapters;

namespace Proyecto_Final
{
    public partial class Venta : Form


    {
        private DataTable carrito = new DataTable();
        private StoreDataSet.ProductoDataTable productos;
        private VentasTableAdapter ventasAdapter = new VentasTableAdapter();
        private ProductoTableAdapter productoAdapter = new ProductoTableAdapter();

        public Venta()
        {
            InitializeComponent();

            carrito.Columns.Add("IDProducto", typeof(int));
            carrito.Columns.Add("Nombre", typeof(string));
            carrito.Columns.Add("Precio", typeof(decimal));

            dgvCarrito.DataSource = carrito;

            // Cargar productos desde la base de datos
            productos = productoAdapter.GetData();
        }
        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataRow row in carrito.Rows)
            {
                subtotal += Convert.ToDecimal(row["Precio"]);
            }

            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            subTotLabel.Text = $"{subtotal:C}";
            taxLabel.Text = $"{tax:C}";
            totalLabel.Text = $"{total:C}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void exitBttn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aggBttn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idProductoBox.Text, out int idProducto))
            {
                var producto = productos.FirstOrDefault(p => p.Id == idProducto);
                if (producto != null)
                {
                    carrito.Rows.Add(producto.Id, producto.Nombre, producto.Precio);
                    CalcularTotales();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un ID válido.");
            }

            idProductoBox.Clear();
            idProductoBox.Focus();
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCarrito.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dgvCarrito.Rows.Remove(row);
                }

                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Selecciona una fila del carrito para eliminar.");
            }
        }

        private void procBttn_Click(object sender, EventArgs e)
        {
            if (carrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            if (!decimal.TryParse(totalLabel.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal total))

            {
                MessageBox.Show("No se pudo obtener el total.");
                return;
            }

            ventasTableAdapter.Fill(storeDataSet.Ventas);

            var newRow = storeDataSet.Ventas.NewVentasRow();
            newRow.Fecha = DateTime.Now;
            newRow.Total = total;

            storeDataSet.Ventas.Rows.Add(newRow);
            ventasTableAdapter.Update(storeDataSet.Ventas);

            MessageBox.Show("Venta registrada exitosamente.");

            carrito.Clear();
            CalcularTotales();

            ventasTableAdapter.Update(storeDataSet.Ventas);

            // Mostrar el formulario de historial de ventas
            Registro historyForm = new Registro();
            historyForm.Show();
        }
        private void subTotLabel_Click(object sender, EventArgs e)
        {

        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.storeDataSet.Producto);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.productoTableAdapter.SearchDesc(this.storeDataSet.Producto, searchBox2.Text);   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
