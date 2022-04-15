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



    public partial class FormAddEstate : Form
    {
        public List<Estate> estates = new List<Estate>();
        int indexRow;    
        public string strVar = string.Empty;
        public FormAddEstate()
        {
          
            InitializeComponent();
            textBox_Name.MaxLength = 40;
        }

        private void button_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_AddEstate_Click(object sender, EventArgs e)
        {

            if (!TextBoxAreEmpty())
            {
                if (!EstateExist())
                {
                    var result = MessageBox.Show("Do you want add photo for this estate? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    var EstateRepository = RepositoryFactory.CreateEstateRepository();

                    Estate estate = new Estate();

                    estate.Name = textBox_Name.Text;
                    estate.Address = textBox_Adress.Text;
                    estate.Price = double.Parse(textBox_Price.Text);
                    estate.Type = comboBox_Type.SelectedItem.ToString();
                    estate.OwnerId = int.Parse(comboBox_OwnerID.SelectedValue.ToString());
                    estate.CreateDate = date_Add.Value;

                    EstateRepository.Create(estate);
                    var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                    var sql = "select ID from Estate where Name=@name";

                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = estate.Name;
                        estate.Id = (int)cmd.ExecuteScalar();
                        textBox_IdEstate.Text = estate.Id.ToString();
                    }
                    strVar = textBox_Name.Text;
                    if (result == DialogResult.Yes)
                    {
                        AddPhotos addPhotos = new AddPhotos(this);
                        addPhotos.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You don t add any photo");
                    }
                    estates.Add(estate);
                    UpdateGrid();
                  
                    //  dgv_Estate.Columns[0].Visible = false;
                }
                else { MessageBox.Show("Estates can not have the same name."); }
               
            }  else { MessageBox.Show("Complete all field for add an estate"); }
        }
        public void UpdateGrid()
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.FlatStyle = FlatStyle.Flat;
            delete.HeaderText = "Delete";
            delete.Name = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "Delete";
            delete.Width = 30;

            edit.FlatStyle = FlatStyle.Flat;
            edit.HeaderText = "Edit";
            edit.Name = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Text = "Edit";
            edit.Width = 30;
            if (dgv_Estate.Columns.Contains(edit.Name = "Edit"))
            {
                dgv_Estate.Columns.Remove("Edit");
                dgv_Estate.Columns.Remove("Delete");
            }


            var bindigList = new BindingList<Estate>(estates);
            dgv_Estate.DataSource = new BindingSource(bindigList, null);


            
            dgv_Estate.Columns.Add(edit);
            dgv_Estate.Columns.Add(delete);
            textBox_Name.Clear();
           
            textBox_Adress.Clear();
            textBox_Price.Clear();

        }

        public bool EstateExist()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "select * from Estate  where Name=@name";
            using (var connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBox_Name.Text;


                if (Convert.ToInt32(cmd.ExecuteScalar()) >= 1)
                {

                    return true;

                }
                else
                {

                    return false;
                }
            }
        }

        private void StyleDGV()
        {
            dgv_Estate.BorderStyle = BorderStyle.None;
            dgv_Estate.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Estate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Estate.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_Estate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_Estate.BackgroundColor = Color.White;

            dgv_Estate.EnableHeadersVisualStyles = false;
            dgv_Estate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Estate.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Estate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void UpdateComboBoxOwner()
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
                comboBox_OwnerID.DataSource = table;
                comboBox_OwnerID.DisplayMember = "Name";
                comboBox_OwnerID.ValueMember = "Id";

           
                

            }
        }
        private void FormAddEstate_Load(object sender, EventArgs e)
        {
            UpdateComboBoxOwner();
            StyleDGV();
            button_EditEstate.Visible = false;
            


        }

        private void dgv_Estate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Estate.Columns[e.ColumnIndex].HeaderText == "Edit")
            {

                textBox_Name.Text = dgv_Estate.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox_Adress.Text = dgv_Estate.Rows[e.RowIndex].Cells["Address"].Value.ToString();
               textBox_Price.Text = dgv_Estate.Rows[e.RowIndex].Cells["Price"].Value.ToString();
               comboBox_Type.SelectedItem = dgv_Estate.Rows[e.RowIndex].Cells["Type"].Value.ToString();
               textBox_IdEstate.Text = dgv_Estate.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                comboBox_OwnerID.SelectedValue = dgv_Estate.Rows[e.RowIndex].Cells["OwnerId"].Value.ToString();
                date_Add.Value = (DateTime) dgv_Estate.Rows[e.RowIndex].Cells["CreateDate"].Value;
                indexRow = e.RowIndex;
                button_EditEstate.Visible = true;
             
            }
            if (dgv_Estate.Columns[e.ColumnIndex].HeaderText == "Delete")
            {


                var estateRepository = RepositoryFactory.CreateEstateRepository();

                Estate estate = new Estate();
               
               estate.Id = int.Parse(dgv_Estate.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                var result = MessageBox.Show("Are u sure u want delete?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete($"{PicturesPath}\\{dgv_Estate.Rows[e.RowIndex].Cells["Name"].Value.ToString()}");
                    }
                    catch{ }
                try
                    {
                        estateRepository.Delete(estate.Id);  
                        dgv_Estate.Rows.RemoveAt(e.RowIndex);
                     
                    }
                    catch { MessageBox.Show ("First time you  need to delete  photos assigned to estate."); }

                    
                  
                    
                    
                }


               
                
                
            }
        }

        private void dgv_Estate_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewEstate viewEstate = new ViewEstate();
            viewEstate.textBox_NameFolder.Text = dgv_Estate.Rows[e.RowIndex].Cells[1].Value.ToString();
            viewEstate.l_Name.Text = "Name: " + dgv_Estate.Rows[e.RowIndex].Cells[1].Value.ToString();
            viewEstate.l_Adress.Text = "Address: " + dgv_Estate.Rows[e.RowIndex].Cells[2].Value.ToString();
            viewEstate.l_Price.Text = "Price: " + dgv_Estate.Rows[e.RowIndex].Cells[4].Value.ToString();
            viewEstate.l_Type.Text = "Type: " + dgv_Estate.Rows[e.RowIndex].Cells[5].Value.ToString();
            viewEstate.ImageList();
            viewEstate.ShowDialog();
        }

        private void textBox_Name_Validated(object sender, EventArgs e)
        {

        }
        public bool TextBoxAreEmpty()
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_Adress.Text) || string.IsNullOrEmpty(textBox_Price.Text) || comboBox_Type.SelectedIndex == -1 || comboBox_OwnerID.SelectedIndex==-1)
            {
            
                return true;
            }
            else return false;

        }
        private void textBox_Price_Validated(object sender, EventArgs e)
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBox_Price.Text))
            {
                errorProvider1.Clear();
                return;

            }
            if (!long.TryParse(textBox_Price.Text, out parsedValue))
            {
                ((TextBox)sender).Focus();
                errorProvider1.SetError(this.textBox_Price, "Enter a valid price");


                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button_EditEstate_Click(object sender, EventArgs e)
        {
           
            var estateRepository = RepositoryFactory.CreateEstateRepository();

            var result = MessageBox.Show("Do you want add photo for this estate? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Estate estate = new Estate();

            estate.Name = textBox_Name.Text;
            estate.Address = textBox_Adress.Text;
            estate.Price = int.Parse(textBox_Price.Text); 
            estate.Type = comboBox_Type.SelectedItem.ToString();
            estate.OwnerId = int.Parse(comboBox_OwnerID.SelectedValue.ToString());
         
            estate.CreateDate = date_Add.Value;
            estate.Id = int.Parse(textBox_IdEstate.Text);
            if (result == DialogResult.Yes)
            {
                AddPhotos addPhotos = new AddPhotos(this);
                addPhotos.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don t add any photo");
            }
            if (!TextBoxAreEmpty())

            {
               
                            estateRepository.Update(estate);
                            DataGridViewRow newDataRow = dgv_Estate.Rows[indexRow];
                            newDataRow.Cells[1].Value = estate.Name;
                            newDataRow.Cells[2].Value = estate.Address;
                            newDataRow.Cells[4].Value = estate.Price;
                            newDataRow.Cells[5].Value = estate.Type;
                            newDataRow.Cells[3].Value = estate.OwnerId;
                            newDataRow.Cells[6].Value = estate.CreateDate;
               
                
                textBox_Name.Clear();
                textBox_Adress.Clear();
                textBox_Price.Clear();
                button_EditEstate.Visible = false;
            }
            
    }

        private void dgv_Estate_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
