using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PreDemExam
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = makeConnection();
                startTableForm(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private MySqlConnection makeConnection()
        {
            var conn = new MySqlConnection(makeConStr());
            conn.Open();
            return conn;
        }

        private string makeConStr()
        {
            var user = userTB.Text;
            var password = passwordTB.Text;
            var dbName = dbNameTB.Text;

            // return $"datasource=127.0.0.1;port=3306;username={user};password={password};database={dbName};convert zero datetime=True";
            return $"datasource=127.0.0.1;port=3306;username=user;password=1111;database=predemexam;convert zero datetime=True";
        }

        private void startTableForm(MySqlConnection connection)
        {
            var tableForm = new TableForm(connection);
            tableForm.Show();
            Hide();
        }
    }
}
