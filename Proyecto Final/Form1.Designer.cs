namespace Proyecto_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.welcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(355, 280);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(132, 22);
            this.userBox.TabIndex = 1;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(355, 350);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(132, 22);
            this.passBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(295, 283);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(36, 16);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "user:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(272, 353);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 16);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "password:";
            // 
            // loginBttn
            // 
            this.loginBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginBttn.Location = new System.Drawing.Point(365, 407);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(111, 46);
            this.loginBttn.TabIndex = 6;
            this.loginBttn.Text = "sign in";
            this.loginBttn.UseVisualStyleBackColor = false;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.BackColor = System.Drawing.Color.Red;
            this.exitBttn.Location = new System.Drawing.Point(736, 456);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(75, 23);
            this.exitBttn.TabIndex = 7;
            this.exitBttn.Text = "exit";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // welcLabel
            // 
            this.welcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.welcLabel.Location = new System.Drawing.Point(95, 15);
            this.welcLabel.Name = "welcLabel";
            this.welcLabel.Size = new System.Drawing.Size(670, 59);
            this.welcLabel.TabIndex = 8;
            this.welcLabel.Text = "Welcome to Rap Magazine Official Store!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(846, 507);
            this.Controls.Add(this.welcLabel);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label welcLabel;
    }
}

