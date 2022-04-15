using EstateManagement.Models;
using EstateManagement.Repository;
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
    public partial class EditEstate : Form
    {
        public EditEstate()
        {
            InitializeComponent();
        }

        private void EditEstate_Load(object sender, EventArgs e)
        {
            
        }
        public void UpdateComboBoxOwner()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "select Id,Name from Owner  ";
            using (var connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable table = new DataTable();
                da.Fill(table);
                
                comboBox_OwnerEdited.DataSource = table;
                
                comboBox_OwnerEdited.DisplayMember = "Name";
                comboBox_OwnerEdited.ValueMember = "Id";
              
            


            }
        }

        private void button_EditEstate_Click(object sender, EventArgs e)
        {

            var estateRepository = RepositoryFactory.CreateEstateRepository();

            Estate estate = new Estate();

            estate.Name = textBox_NameEdited.Text;
            estate.Address = textBox_AddressEdited.Text;
            estate.Price = int.Parse(textBox_PriceEdited.Text);
            estate.Type = comboBox_TypeEdited.SelectedItem.ToString();
            estate.Id = int.Parse(textBox_IdEdited.Text);
            estate.CreateDate = dateTimePicker1.Value;
            estate.OwnerId = int.Parse(comboBox_OwnerEdited.SelectedValue.ToString());
            var result = MessageBox.Show("Do you want add photo for this estate? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AddPhotos addPhotos = new AddPhotos(this);
                addPhotos.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don t add any photo");
            }

            estateRepository.Update(estate);
                        MessageBox.Show("Estate was edited with succes! Press on refresh button to see changes.");
                        this.Close();
           
        }
    }
}
