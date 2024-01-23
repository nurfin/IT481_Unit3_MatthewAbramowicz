using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using IT481_Unit_3_Matthew_Abramowicz;

namespace Matthew_Abramowicz_Unit3_IT481
{
    public partial class Form1 : Form
    {
        DB database;
        private DB db;
        private string user;
        private string password;
        private string server;
        private string databaseEntry;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            databaseEntry = textBox4.Text;

            if (user.Length == 0 || password.Length == 0 || server.Length == 0 || databaseEntry.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter username, password, server and database values");
            }
            if (isValid)
            {
                db = new DB("Server = " + server + "\\SQLEXPRESS;" +
                       "Trusted_Connections=true;" +
                       "Database = " + database + ";" +
                       "User ID = " + user + ";" +
                       "Password = " + password + ";");
                MessageBox.Show("Connection information sent");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = MATTKID\\SQLEXPRESS; " +
                    "Trusted_Connection=true;" +
                    "Database=northwind;" +
                    "User Instance=false;" +
                    "Connection timeout=30");
            MessageBox.Show("Connection information sent");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerNames();
            MessageBox.Show(names, "CustomerNames");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order count");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string orderid = database.getOrder();
            MessageBox.Show(orderid, "OrderID");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "EmployeeLastName");
        }
    }
}