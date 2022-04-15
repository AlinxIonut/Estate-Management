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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.UI.Forms
{
   
    public partial class AddOwner : Form
    {
     
     
       public  List<Owner> owners = new List<Owner>();
        int indexRow;
        public AddOwner()
        {
            InitializeComponent();
            textBox_CNP.MaxLength = 13;
            textBox_Phone.MaxLength = 10;
            textBox_Name.MaxLength = 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Name_Validated(object sender, EventArgs e)
        {
            textBox_Name.MaxLength = 40;

        }

        private void button_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Email_Validated(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                errorProvider1.Clear();
                return;
            }

            if (Regex.IsMatch(textBox_Email.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.textBox_Email, "Enter a valid email");
              
                textBox_Email.Focus();
                return;
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           
            long parsedValue;
            if (string.IsNullOrEmpty(textBox_Phone.Text))
            {
                errorProvider1.Clear();
                return;
                
            }
            if (!long.TryParse(textBox_Phone.Text, out parsedValue) || (textBox_Phone.TextLength < 10))
            {
                ((TextBox)sender).Focus();
                errorProvider1.SetError(this.textBox_Phone, "Enter a valid number");


                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

    

        
        public bool CnpIsValid()
        {
           
            long parsedValue;
            if (!long.TryParse(textBox_CNP.Text, out parsedValue))
            {
              return false;
          }
            if (!(textBox_CNP.TextLength == textBox_CNP.MaxLength))
            {
               
                return false;
            }
            else
            {
               
                return true;
            }
        }
        public bool TextBoxAreEmpty()
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_Email.Text) || string.IsNullOrEmpty(textBox_Phone.Text) || string.IsNullOrEmpty(textBox_CNP.Text))
            {
                
                return true;
            }
            else return false;
           
        }
        public void UpdateGridWhenEdit()
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
            if (dgv_Owner.Columns.Contains(edit.Name = "Edit"))
            {
                dgv_Owner.Columns.Remove("Edit");
                dgv_Owner.Columns.Remove("Delete");
            }


            var bindigList = new BindingList<Owner>(owners);
            dgv_Owner.DataSource = new BindingSource(bindigList, null);



            dgv_Owner.Columns.Add(edit);
            dgv_Owner.Columns.Add(delete);
            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_CNP.Clear();
            textBox_Phone.Clear();
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
            if (dgv_Owner.Columns.Contains(edit.Name = "Edit"))
            {
                dgv_Owner.Columns.Remove("Edit");
                dgv_Owner.Columns.Remove("Delete");
            }
            

            var bindigList = new BindingList<Owner>(owners);
            dgv_Owner.DataSource = new BindingSource(bindigList, null);
           
           
           
                dgv_Owner.Columns.Add(edit);
            dgv_Owner.Columns.Add(delete);
            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_CNP.Clear();
            textBox_Phone.Clear();
            
        }
        public bool EmailIsValid()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                errorProvider1.Clear();
                return false;
            }

            if (Regex.IsMatch(textBox_Email.Text, pattern))
            {
                errorProvider1.Clear();
                return true;
            }
            else
            {
                errorProvider1.SetError(this.textBox_Email, "Enter a valid email");

                textBox_Email.Focus();
                return false;
            }
        }
        public bool PhoneIsValid()
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBox_Phone.Text))
            {
                errorProvider1.Clear();
                return false;

            }
            if (!long.TryParse(textBox_Phone.Text, out parsedValue) || (textBox_Phone.TextLength < 10))
            {
                textBox_Phone.Focus();
                errorProvider1.SetError(this.textBox_Phone, "Enter a valid number");


                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        public bool OwnerExist()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "select * from Owner  where Email=@email";
            using (var connection = new SqlConnection(connectionString))
            {
               
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox_Email.Text;
              
               
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
        private void btn_AddOwner_Click(object sender, EventArgs e)
        {
            if (OwnerExist() == false)
            {
                if (!TextBoxAreEmpty())
               
            {
                    if (EmailIsValid())
                    {
                        if (PhoneIsValid())
                        {
                            if (CnpIsValid())

                            {

                                var ownerRepository = RepositoryFactory.CreateOwnerRepository();
                                Owner owner = new Owner();

                                owner.Name = textBox_Name.Text;
                                owner.Email = textBox_Email.Text;
                                owner.Phone = textBox_Phone.Text;
                                owner.Cnp = textBox_CNP.Text;

                                ownerRepository.Create(owner);
                                var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                                var sql = "select ID from Owner where Name=@name";

                                using (var connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    SqlCommand cmd = new SqlCommand(sql, connection);
                                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = owner.Name;
                                    owner.Id = (int)cmd.ExecuteScalar();
                                }
                                owners.Add(owner);

                                // dgv_Owner.DataSource = owners;


                                UpdateGrid();
                                dgv_Owner.Columns[0].Visible = false;

                            }   else MessageBox.Show("CNP is not valid");
                        } else MessageBox.Show("Phone is not valid");
                     
                    }
                    else MessageBox.Show("Email is not valid");
                   
                }
                else MessageBox.Show("You need to complete all fields.");

            } 
            else
                    {
                        MessageBox.Show("This email is aleardy used");
                    }
        }
       
        private void dgv_Owner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Owner.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
              
               textBox_Name.Text = dgv_Owner.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox_Email.Text = dgv_Owner.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                textBox_Phone.Text = dgv_Owner.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                textBox_CNP.Text = dgv_Owner.Rows[e.RowIndex].Cells["CNP"].Value.ToString();
             textBox_Id.Text = dgv_Owner.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                indexRow = e.RowIndex;
                button1.Visible = true;
            }
            if (dgv_Owner.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

               
                var ownerRepository = RepositoryFactory.CreateOwnerRepository();

                Owner owner = new Owner();
                
                owner.Id = int.Parse(dgv_Owner.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                int id = owner.Id;
                var result = MessageBox.Show("Are u sure u want delete?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ownerRepository.Delete(id);
                        dgv_Owner.Rows.RemoveAt(e.RowIndex);
                    }
                    catch { MessageBox.Show("You need to delete all estates assigned for this owner"); }
                }
             
              
            }
        }
        private void StyleDGV()
        {
            dgv_Owner.BorderStyle = BorderStyle.None;
            dgv_Owner.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Owner.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Owner.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_Owner.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_Owner.BackgroundColor = Color.White;

            dgv_Owner.EnableHeadersVisualStyles = false;
            dgv_Owner.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Owner.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Owner.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void AddOwner_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            StyleDGV();
           /* var confingFile= ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = confingFile.AppSettings.Settings;
            settings["repType"].Value = "2";
            confingFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(confingFile.AppSettings.SectionInformation.Name);
            var appSettings = ConfigurationManager.AppSettings;
        */ //Schimbare valoare repType din app confing.
        }

        private void textBox_CNP_Validated(object sender, EventArgs e)
        {
           
            long parsedValue;
            if(string.IsNullOrEmpty(textBox_CNP.Text))
            {
                errorProvider1.Clear();
                return;
            }
            if (!long.TryParse(textBox_CNP.Text, out parsedValue))
            {
                ((TextBox)sender).Focus();
                errorProvider1.SetError(this.textBox_CNP, "Write a valid CNP");
                
                return;
            }
            if (!(textBox_CNP.TextLength == textBox_CNP.MaxLength))
            {
                errorProvider1.SetError(this.textBox_CNP, "Write a valid CNP");
                ((TextBox)sender).Focus();
                return;
            }
            else
            {

                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
          
            var ownerRepository = RepositoryFactory.CreateOwnerRepository();
         
            Owner owner = new Owner();
           
            owner.Name = textBox_Name.Text;
            owner.Email = textBox_Email.Text;
            owner.Phone = textBox_Phone.Text;
           owner.Cnp = textBox_CNP.Text;
            owner.Id = int.Parse(textBox_Id.Text);
           
            
                if (!TextBoxAreEmpty())

                {
                    if (EmailIsValid())
                    {
                        if (PhoneIsValid())
                        {
                            if (CnpIsValid())

                            {
                                ownerRepository.Update(owner);
                                DataGridViewRow newDataRow = dgv_Owner.Rows[indexRow];
                                newDataRow.Cells[1].Value = owner.Name;
                                newDataRow.Cells[2].Value = owner.Email;
                                newDataRow.Cells[3].Value = owner.Phone;
                                newDataRow.Cells[4].Value = owner.Cnp;
                                textBox_Name.Clear();
                                textBox_Email.Clear();
                                textBox_Phone.Clear();
                                textBox_CNP.Clear();
                                button1.Visible = false;
                            }
                            else MessageBox.Show("CNP is not valid");
                        }
                        else MessageBox.Show("Phone is not valid");
                    }
                    else MessageBox.Show("Email is not valid");
                }
                else MessageBox.Show("Complete all data");
            }
        
            }
    }
    

