using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstateManagement.UI.Forms
{
      
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            textBoxEditForm_Name.MaxLength = 40;
            textBoxEditForm_CNP.MaxLength = 13;
            textBoxEditForm_Phone.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            
                var ownerRepository = RepositoryFactory.CreateOwnerRepository();

                Owner owner = new Owner();

                owner.Name = textBoxEditForm_Name.Text;
                owner.Email = textBoxEditForm_Email.Text;
                owner.Phone = textBoxEditForm_Phone.Text;
                owner.Cnp = textBoxEditForm_CNP.Text;
                owner.Id = int.Parse(textBox_IdEdit.Text);

                if (EmailIsValid() == true)
                {

                    if (CNPIsValid() == true)
                    {
                        if (PhoneIsValid() == true)
                        {


                            ownerRepository.Update(owner);
                            MessageBox.Show("Owner was edited with succes! Press on refresh button to see changes.");
                            this.Close();
                        }
                        else MessageBox.Show("Enter a valid PHONE ");
                    }
                    else MessageBox.Show("Enter a valid CNP");
                }
                else MessageBox.Show("Enter a valid email");
            
        
        }
        private bool CNPIsValid()
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBoxEditForm_CNP.Text))
            {
                errorProvider1.Clear();
                return false;
            }
            if (!long.TryParse(textBoxEditForm_CNP.Text, out parsedValue))
            {
                textBoxEditForm_CNP.Focus();
                errorProvider1.SetError(this.textBoxEditForm_CNP, "Write a valid CNP");

                return false;
            }
            if (!(textBoxEditForm_CNP.TextLength == textBoxEditForm_CNP.MaxLength))
            {
                errorProvider1.SetError(this.textBoxEditForm_CNP, "Write a valid CNP");
               textBoxEditForm_CNP.Focus();
                return false;
            }
            else
            {

                errorProvider1.Clear();
                return true;
            }
        }

        private bool EmailIsValid()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (string.IsNullOrEmpty(textBoxEditForm_Email.Text))
            {
                errorProvider1.Clear();
                return false;
            }

            if (Regex.IsMatch(textBoxEditForm_Email.Text, pattern))
            {
                errorProvider1.Clear();
                return true;
            }
            else
            {
                errorProvider1.SetError(this.textBoxEditForm_Email, "Enter a valid email");

                textBoxEditForm_Email.Focus();
                return false;
            }
        }
        private bool PhoneIsValid()
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBoxEditForm_Phone.Text))
            {
                errorProvider1.Clear();
                return false;

            }
            if (!long.TryParse(textBoxEditForm_Phone.Text, out parsedValue) || (textBoxEditForm_Phone.TextLength < 10))
            {
                textBoxEditForm_Phone.Focus();
                errorProvider1.SetError(this.textBoxEditForm_Phone, "Enter a valid number");


                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEditForm_CNP_Validated(object sender, EventArgs e)
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBoxEditForm_CNP.Text))
            {
                errorProvider1.Clear();
                return;
            }
            if (!long.TryParse(textBoxEditForm_CNP.Text, out parsedValue))
            {
                ((TextBox)sender).Focus();
                errorProvider1.SetError(this.textBoxEditForm_CNP, "Write a valid CNP");

                return;
            }
            if (!(textBoxEditForm_CNP.TextLength == textBoxEditForm_CNP.MaxLength))
            {
                errorProvider1.SetError(this.textBoxEditForm_CNP, "Write a valid CNP");
                ((TextBox)sender).Focus();
                return;
            }
            else
            {

                errorProvider1.Clear();
            }
        }

        private void textBoxEditForm_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditForm_Phone_Validated(object sender, EventArgs e)
        {
            long parsedValue;
            if (string.IsNullOrEmpty(textBoxEditForm_Phone.Text))
            {
                errorProvider1.Clear();
                return;

            }
            if (!long.TryParse(textBoxEditForm_Phone.Text, out parsedValue) || (textBoxEditForm_Phone.TextLength < 10))
            {
                textBoxEditForm_Phone.Focus();
                errorProvider1.SetError(this.textBoxEditForm_Phone, "Enter a valid number");


                return;
            }
            else
            {
                errorProvider1.Clear();
                return;
            }
        }

        private void textBoxEditForm_Email_Validated(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (string.IsNullOrEmpty(textBoxEditForm_Email.Text))
            {
                errorProvider1.Clear();
                return ;
            }

            if (Regex.IsMatch(textBoxEditForm_Email.Text, pattern))
            {
                errorProvider1.Clear();
                return ;
            }
            else
            {
                errorProvider1.SetError(this.textBoxEditForm_Email, "Enter a valid email");

                textBoxEditForm_Email.Focus();
                return ;
            }
        }
    }
}


