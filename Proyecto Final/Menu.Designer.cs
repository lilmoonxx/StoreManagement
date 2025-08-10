namespace Proyecto_Final
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ventBttn = new System.Windows.Forms.Button();
            this.invnBttn = new System.Windows.Forms.Button();
            this.seleccLabel = new System.Windows.Forms.Label();
            this.volvBttn = new System.Windows.Forms.Button();
            this.exitBttn2 = new System.Windows.Forms.Button();
            this.storeDataSet = new Proyecto_Final.StoreDataSet();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Proyecto_Final.StoreDataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new Proyecto_Final.StoreDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ventBttn
            // 
            this.ventBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ventBttn.Location = new System.Drawing.Point(98, 99);
            this.ventBttn.Name = "ventBttn";
            this.ventBttn.Size = new System.Drawing.Size(104, 41);
            this.ventBttn.TabIndex = 0;
            this.ventBttn.Text = "Sale";
            this.ventBttn.UseVisualStyleBackColor = false;
            this.ventBttn.Click += new System.EventHandler(this.ventBttn_Click);
            // 
            // invnBttn
            // 
            this.invnBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invnBttn.Location = new System.Drawing.Point(563, 99);
            this.invnBttn.Name = "invnBttn";
            this.invnBttn.Size = new System.Drawing.Size(104, 41);
            this.invnBttn.TabIndex = 1;
            this.invnBttn.Text = "Inventory";
            this.invnBttn.UseVisualStyleBackColor = false;
            this.invnBttn.Click += new System.EventHandler(this.invnBttn_Click);
            // 
            // seleccLabel
            // 
            this.seleccLabel.AutoSize = true;
            this.seleccLabel.Location = new System.Drawing.Point(350, 54);
            this.seleccLabel.Name = "seleccLabel";
            this.seleccLabel.Size = new System.Drawing.Size(48, 16);
            this.seleccLabel.TabIndex = 2;
            this.seleccLabel.Text = "Select:";
            // 
            // volvBttn
            // 
            this.volvBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.volvBttn.Location = new System.Drawing.Point(27, 392);
            this.volvBttn.Name = "volvBttn";
            this.volvBttn.Size = new System.Drawing.Size(75, 23);
            this.volvBttn.TabIndex = 3;
            this.volvBttn.Text = "back";
            this.volvBttn.UseVisualStyleBackColor = false;
            this.volvBttn.Click += new System.EventHandler(this.volvBttn_Click);
            // 
            // exitBttn2
            // 
            this.exitBttn2.BackColor = System.Drawing.Color.Red;
            this.exitBttn2.Location = new System.Drawing.Point(660, 392);
            this.exitBttn2.Name = "exitBttn2";
            this.exitBttn2.Size = new System.Drawing.Size(75, 23);
            this.exitBttn2.TabIndex = 4;
            this.exitBttn2.Text = "exit";
            this.exitBttn2.UseVisualStyleBackColor = false;
            this.exitBttn2.Click += new System.EventHandler(this.exitBttn2_Click);
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources._12201509;
            this.pictureBox1.Location = new System.Drawing.Point(493, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(303, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBttn2);
            this.Controls.Add(this.volvBttn);
            this.Controls.Add(this.seleccLabel);
            this.Controls.Add(this.invnBttn);
            this.Controls.Add(this.ventBttn);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ventBttn;
        private System.Windows.Forms.Button invnBttn;
        private System.Windows.Forms.Label seleccLabel;
        private System.Windows.Forms.Button volvBttn;
        private System.Windows.Forms.Button exitBttn2;
        private StoreDataSet storeDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private StoreDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}