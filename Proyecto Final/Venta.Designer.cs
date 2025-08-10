namespace Proyecto_Final
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.volvBttn2 = new System.Windows.Forms.Button();
            this.exitBttn3 = new System.Windows.Forms.Button();
            this.aggBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.procBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.idProductoBox = new System.Windows.Forms.TextBox();
            this.subLabel2 = new System.Windows.Forms.Label();
            this.taxLabel2 = new System.Windows.Forms.Label();
            this.totalLabel2 = new System.Windows.Forms.Label();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Proyecto_Final.StoreDataSet();
            this.searchBox2 = new System.Windows.Forms.TextBox();
            this.searchBttn3 = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Proyecto_Final.StoreDataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new Proyecto_Final.StoreDataSetTableAdapters.TableAdapterManager();
            this.productoTableAdapter = new Proyecto_Final.StoreDataSetTableAdapters.ProductoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // volvBttn2
            // 
            this.volvBttn2.BackColor = System.Drawing.Color.Yellow;
            this.volvBttn2.Location = new System.Drawing.Point(12, 535);
            this.volvBttn2.Name = "volvBttn2";
            this.volvBttn2.Size = new System.Drawing.Size(75, 23);
            this.volvBttn2.TabIndex = 0;
            this.volvBttn2.Text = "Volver";
            this.volvBttn2.UseVisualStyleBackColor = false;
            this.volvBttn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBttn3
            // 
            this.exitBttn3.BackColor = System.Drawing.Color.Red;
            this.exitBttn3.Location = new System.Drawing.Point(999, 535);
            this.exitBttn3.Name = "exitBttn3";
            this.exitBttn3.Size = new System.Drawing.Size(75, 23);
            this.exitBttn3.TabIndex = 1;
            this.exitBttn3.Text = "Salir";
            this.exitBttn3.UseVisualStyleBackColor = false;
            this.exitBttn3.Click += new System.EventHandler(this.exitBttn3_Click);
            // 
            // aggBttn
            // 
            this.aggBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.aggBttn.Location = new System.Drawing.Point(598, 385);
            this.aggBttn.Name = "aggBttn";
            this.aggBttn.Size = new System.Drawing.Size(115, 51);
            this.aggBttn.TabIndex = 2;
            this.aggBttn.Text = "Add";
            this.aggBttn.UseVisualStyleBackColor = false;
            this.aggBttn.Click += new System.EventHandler(this.aggBttn_Click);
            // 
            // deleteBttn
            // 
            this.deleteBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteBttn.Location = new System.Drawing.Point(732, 385);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(107, 51);
            this.deleteBttn.TabIndex = 3;
            this.deleteBttn.Text = "Delete";
            this.deleteBttn.UseVisualStyleBackColor = false;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // procBttn
            // 
            this.procBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.procBttn.Location = new System.Drawing.Point(929, 245);
            this.procBttn.Name = "procBttn";
            this.procBttn.Size = new System.Drawing.Size(144, 56);
            this.procBttn.TabIndex = 4;
            this.procBttn.Text = "Process sale";
            this.procBttn.UseVisualStyleBackColor = false;
            this.procBttn.Click += new System.EventHandler(this.procBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the ID of the product you want to add to your cart:";
            // 
            // subTotLabel
            // 
            this.subTotLabel.BackColor = System.Drawing.Color.White;
            this.subTotLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotLabel.Location = new System.Drawing.Point(977, 82);
            this.subTotLabel.Name = "subTotLabel";
            this.subTotLabel.Size = new System.Drawing.Size(94, 23);
            this.subTotLabel.TabIndex = 6;
            this.subTotLabel.Click += new System.EventHandler(this.subTotLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.White;
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(977, 119);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(94, 24);
            this.taxLabel.TabIndex = 7;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(977, 173);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(94, 25);
            this.totalLabel.TabIndex = 8;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(496, 12);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(410, 278);
            this.dgvCarrito.TabIndex = 9;
            this.dgvCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellContentClick);
            // 
            // idProductoBox
            // 
            this.idProductoBox.Location = new System.Drawing.Point(665, 338);
            this.idProductoBox.Name = "idProductoBox";
            this.idProductoBox.Size = new System.Drawing.Size(100, 22);
            this.idProductoBox.TabIndex = 10;
            // 
            // subLabel2
            // 
            this.subLabel2.AutoSize = true;
            this.subLabel2.Location = new System.Drawing.Point(912, 85);
            this.subLabel2.Name = "subLabel2";
            this.subLabel2.Size = new System.Drawing.Size(59, 16);
            this.subLabel2.TabIndex = 11;
            this.subLabel2.Text = "Subtotal:";
            // 
            // taxLabel2
            // 
            this.taxLabel2.AutoSize = true;
            this.taxLabel2.Location = new System.Drawing.Point(934, 127);
            this.taxLabel2.Name = "taxLabel2";
            this.taxLabel2.Size = new System.Drawing.Size(33, 16);
            this.taxLabel2.TabIndex = 12;
            this.taxLabel2.Text = "Tax:";
            // 
            // totalLabel2
            // 
            this.totalLabel2.AutoSize = true;
            this.totalLabel2.Location = new System.Drawing.Point(926, 182);
            this.totalLabel2.Name = "totalLabel2";
            this.totalLabel2.Size = new System.Drawing.Size(41, 16);
            this.totalLabel2.TabIndex = 13;
            this.totalLabel2.Text = "Total:";
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.RowHeadersWidth = 51;
            this.productoDataGridView.RowTemplate.Height = 24;
            this.productoDataGridView.Size = new System.Drawing.Size(478, 397);
            this.productoDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchBox2
            // 
            this.searchBox2.Location = new System.Drawing.Point(195, 450);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.Size = new System.Drawing.Size(118, 22);
            this.searchBox2.TabIndex = 15;
            this.searchBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBttn3
            // 
            this.searchBttn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBttn3.Location = new System.Drawing.Point(208, 481);
            this.searchBttn3.Name = "searchBttn3";
            this.searchBttn3.Size = new System.Drawing.Size(98, 42);
            this.searchBttn3.TabIndex = 16;
            this.searchBttn3.Text = "Buscar";
            this.searchBttn3.UseVisualStyleBackColor = false;
            this.searchBttn3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.storeDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Final.StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search for a product of interest:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1086, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBttn3);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.totalLabel2);
            this.Controls.Add(this.taxLabel2);
            this.Controls.Add(this.subLabel2);
            this.Controls.Add(this.idProductoBox);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procBttn);
            this.Controls.Add(this.deleteBttn);
            this.Controls.Add(this.aggBttn);
            this.Controls.Add(this.exitBttn3);
            this.Controls.Add(this.volvBttn2);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volvBttn2;
        private System.Windows.Forms.Button exitBttn3;
        private System.Windows.Forms.Button aggBttn;
        private System.Windows.Forms.Button deleteBttn;
        private System.Windows.Forms.Button procBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTotLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox idProductoBox;
        private System.Windows.Forms.Label subLabel2;
        private System.Windows.Forms.Label taxLabel2;
        private System.Windows.Forms.Label totalLabel2;
        private StoreDataSet storeDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private StoreDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private StoreDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox searchBox2;
        private System.Windows.Forms.Button searchBttn3;
        private System.Windows.Forms.Label label2;
    }
}