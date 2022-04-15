using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.UI.Forms
{
    public partial class ViewOwner : Form
    {
        int count = 0;
        public ViewOwner()
        {
            InitializeComponent();
          
        }
        public void EstateList()
        {
            var result = new List<Estate>();
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;  //string de conectare la baza de date sql (a se obtine din app.config!)


            using (var connection = new SqlConnection(connectionString))
            {
 SqlCommand cmd = new SqlCommand();
                connection.Open();
               
                cmd.CommandText = "SELECT Name FROM Estate where OwnerId=@id";
                cmd.Connection = connection;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = label6.Text;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    listView1.Items.Add(dr[0].ToString());
                    count++;
                }
                label7.Text = "Total Estates: " + count;

            }
        }

        private void ViewOwner_Load(object sender, EventArgs e)
        {
            EstateList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

