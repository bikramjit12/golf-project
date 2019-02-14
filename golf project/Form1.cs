using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golf_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LbGolf_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LbGolf.Items.Clear(); //clear out old data in the listbox, we will need this later            
                                  //load the connection string and pass it to the command            
            string connectionString = @"Data Source=LAPTOP-Q2KFF8I0\SQLEXPRESS;Initial Catalog=Golf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Golf ORDER by ID";
                //read in the data with a datareader open the data connection 
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox 
                    ListViewItem item = new ListViewItem(new[] { reader["ID"].ToString(), reader["Title"].ToString(), reader["Firstname"].ToString(), reader["Surname"].ToString(), reader["Gender"].ToString(), reader["DOB"].ToString(), reader["Street"].ToString(), reader["Suburb"].ToString(), reader["City"].ToString(), reader["Available week days"].ToString(), reader["Handicap"].ToString() }); LbGolf.Items.Add(item);
                }
                reader.Close();
            }
        }
    }
}