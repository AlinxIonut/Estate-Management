using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.UI.Forms
{
    public partial class AllOwners : Form
    {
        private Form activeForm;
        public AllOwners()
        {
            InitializeComponent();
        }
        private void StyleDGV()
        {
            dgv_Owners.BorderStyle = BorderStyle.None;
            dgv_Owners.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(19, 29, 69);
            dgv_Owners.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Owners.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_Owners.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_Owners.BackgroundColor = Color.White;
            dgv_Owners.DefaultCellStyle.ForeColor = Color.DarkTurquoise;

            dgv_Owners.EnableHeadersVisualStyles = false;
            dgv_Owners.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Owners.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Owners.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkTurquoise;
        }
        private void AllOwners_Load(object sender, EventArgs e)
        {
            var ownerRepository = RepositoryFactory.CreateOwnerRepository();
            StyleDGV();
           dgv_Owners.DataSource= ownerRepository.GetAll();
            Dgv_Button();


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

            dgv_Owners.Columns.Add(edit);
            dgv_Owners.Columns.Add(delete);
            dgv_Owners.Columns[0].Visible = false;
        }
     
            private void dgv_Owners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

                if (dgv_Owners.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                Edit edit = new Edit();
                    
              
               
               
                   
                    edit.textBoxEditForm_Name.Text = dgv_Owners.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    edit.textBoxEditForm_Email.Text = dgv_Owners.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    edit.textBoxEditForm_Phone.Text = dgv_Owners.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    edit.textBoxEditForm_CNP.Text = dgv_Owners.Rows[e.RowIndex].Cells["CNP"].Value.ToString();
                    edit.textBox_IdEdit.Text = dgv_Owners.Rows[e.RowIndex].Cells["ID"].Value.ToString();
          
               
               
               
               
                
                    edit.ShowDialog();
               


            }
            
            if (dgv_Owners.Columns[e.ColumnIndex].HeaderText == "Delete")
            {


                var ownerRepository = RepositoryFactory.CreateOwnerRepository();

                Owner owner = new Owner();

                owner.Id = int.Parse(dgv_Owners.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                int id = owner.Id;
               var result= MessageBox.Show("Are u sure u want delete?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ownerRepository.Delete(id);
                        dgv_Owners.DataSource = ownerRepository.GetAll();
                    }
                    catch { MessageBox.Show("You need to delete all estates assigned for this owner"); }
                } 
            
                
            }
        }

        private void button_ShutDown_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            var ownerRepository = RepositoryFactory.CreateOwnerRepository();
            dgv_Owners.DataSource = ownerRepository.GetAll();
        }

        private void dgv_Owners_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewOwner viewOwner = new ViewOwner();
            viewOwner.label1.Text = "Name: " + dgv_Owners.Rows[e.RowIndex].Cells[3].Value.ToString();
            viewOwner.label2.Text = "Email: " + dgv_Owners.Rows[e.RowIndex].Cells[4].Value.ToString();
            viewOwner.label3.Text = "Phone: " + dgv_Owners.Rows[e.RowIndex].Cells[5].Value.ToString();
           viewOwner.label4.Text ="CNP: "+dgv_Owners.Rows[e.RowIndex].Cells[6].Value.ToString();
            viewOwner.label6.Text = dgv_Owners.Rows[e.RowIndex].Cells[2].Value.ToString();
            viewOwner.ShowDialog();
        }
    }
}
