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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((username == "mod" && password == "bigdaddy69") ||
                (username == "jjusino" && password == "COMP205")
                (username == "admin" && password == "admin"))
            {
                MessageBox.Show("Welcome, " + username + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Here you could open the next window or form
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

