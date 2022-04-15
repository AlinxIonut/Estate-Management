using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.UI.Forms
{
    public partial class AllEstates : Form
    {
        DataTable dataTable = new DataTable();
       
        
        public AllEstates()
        {
            InitializeComponent();
        }

        private void button_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_RefreshEstate_Click(object sender, EventArgs e)
        {
            var estateRepository = RepositoryFactory.CreateEstateRepository();
            dgv_Estates.DataSource = estateRepository.GetAll();
            comboBox_OwnerList.SelectedIndex = -1;
            textBox_SearchByName.Clear();
            textBox_PriceMax.Clear();
            textBox_PriceMin.Clear();
            
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

                comboBox_OwnerList.DataSource = table;

                comboBox_OwnerList.DisplayMember = "Name";
                comboBox_OwnerList.ValueMember = "Id";


                comboBox_OwnerList.SelectedIndex = -1;



            }
          
        }
        private void UpdateGrid()
        {
            var estateRepository = RepositoryFactory.CreateEstateRepository();
            dgv_Estates.DataSource = estateRepository.GetAll();
        }
        private void AllEstates_Load(object sender, EventArgs e)
        {
            UpdateComboBoxOwner();
            UpdateGrid();
            Dgv_Button();
            StyleDGV();
            
        }
        private void Dgv_Button()
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.FlatStyle = FlatStyle.Flat;
            delete.HeaderText = "Delete";
            delete.Name = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "Delete";
            delete.Width = 60;

            edit.FlatStyle = FlatStyle.Flat;
            edit.HeaderText = "Edit";
            edit.Name = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Text = "Edit";
            edit.Width = 60;

            dgv_Estates.Columns.Add(edit);
            dgv_Estates.Columns.Add(delete);
            dgv_Estates.Columns[0].Visible = false;
        }
        private void StyleDGV()
        {
            dgv_Estates.BorderStyle = BorderStyle.None;
            dgv_Estates.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(19, 29, 69);
            dgv_Estates.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Estates.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_Estates.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_Estates.BackgroundColor = Color.White;
            dgv_Estates.DefaultCellStyle.ForeColor = Color.DarkTurquoise;

            dgv_Estates.EnableHeadersVisualStyles = false;
            dgv_Estates.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Estates.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Estates.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkTurquoise;
        }

        private void dgv_Estates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Estates.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                EditEstate edit = new EditEstate();





                edit.textBox_NameEdited.Text = dgv_Estates.Rows[e.RowIndex].Cells["Name"].Value.ToString();
               edit.textBox_AddressEdited.Text = dgv_Estates.Rows[e.RowIndex].Cells["Address"].Value.ToString();
               edit.textBox_PriceEdited.Text = dgv_Estates.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                edit.comboBox_TypeEdited.SelectedItem = dgv_Estates.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                 edit.dateTimePicker1.Value = (DateTime)dgv_Estates.Rows[e.RowIndex].Cells["CreateDate"].Value;
                edit.textBox_IdEdited.Text = dgv_Estates.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                edit.UpdateComboBoxOwner();
                edit.comboBox_OwnerEdited.SelectedValue = dgv_Estates.Rows[e.RowIndex].Cells["OwnerId"].Value.ToString();
              
                
               






                edit.ShowDialog();

                

            }

            if (dgv_Estates.Columns[e.ColumnIndex].HeaderText == "Delete")
            {


                var estateRepository = RepositoryFactory.CreateEstateRepository();

                Estate estate = new Estate();

                estate.Id = int.Parse(dgv_Estates.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                int id = estate.Id;
                var result = MessageBox.Show("Are u sure u want delete?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
                    try
                    {
                        Directory.Delete($"{PicturesPath}\\{dgv_Estates.Rows[e.RowIndex].Cells["Name"].Value.ToString()}");
                    }
                    catch { }
                    try
                    {
                        estateRepository.Delete(estate.Id);
                        dgv_Estates.DataSource = estateRepository.GetAll();
                    }
                    catch { MessageBox.Show(" First time you  need to delete  photo assigned to estate."); }
                    }
               
                    
                   
                
                
            }
        }

        private void dgv_Estates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewEstate viewEstate = new ViewEstate();
            viewEstate.textBox_NameFolder.Text = dgv_Estates.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            viewEstate.l_Name.Text = "Name: " + dgv_Estates.Rows[e.RowIndex].Cells[3].Value.ToString();
            viewEstate.l_Adress.Text = "Address: " + dgv_Estates.Rows[e.RowIndex].Cells[4].Value.ToString();
            viewEstate.l_Price.Text = "Price: " + dgv_Estates.Rows[e.RowIndex].Cells[6].Value.ToString();
            viewEstate.l_Type.Text = "Type: " + dgv_Estates.Rows[e.RowIndex].Cells[7].Value.ToString();
            viewEstate.ImageList();
            viewEstate.ShowDialog();
        }

        private void comboBox_OwnerList_SelectedValueChanged(object sender, EventArgs e)
        {
          
           }

        private void textBox_SearchByName_TextChanged(object sender, EventArgs e)
        {
            var estateRepository =  RepositoryFactory.CreateEstateRepository();
            dgv_Estates.DataSource = estateRepository.GetAll().Where(estate => estate.Name.Contains(textBox_SearchByName.Text) || estate.Type.Contains(textBox_SearchByName.Text)).ToList();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox_OwnerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var estateRepository = RepositoryFactory.CreateEstateRepository();
            try
            {
              
                dgv_Estates.DataSource = estateRepository.GetAll().Where(estate => estate.OwnerId.ToString() == comboBox_OwnerList.SelectedValue.ToString()).ToList();
            }
            catch { }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
           
            var estateRepository = RepositoryFactory.CreateEstateRepository();
            try
            {
                dgv_Estates.DataSource = estateRepository.GetAll().Where(estate => estate.Price >= int.Parse(textBox_PriceMin.Text) && estate.Price <= int.Parse(textBox_PriceMax.Text)).ToList();
                
            }
            catch { }
        }
    }
    }
    

