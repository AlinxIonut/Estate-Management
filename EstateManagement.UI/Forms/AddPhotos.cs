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
    public partial class AddPhotos : Form
    {
        ImageList imgs = new ImageList();
        string filePath = string.Empty;
        FormAddEstate f1;
        EditEstate f2;
        Estate estate = new Estate();
        public AddPhotos(FormAddEstate frm1)
        {
            InitializeComponent();
            this.f1 = frm1;

        }
        public AddPhotos(EditEstate frm2)

        {
            InitializeComponent();
            this.f2 = frm2;
            
        }
        private void button_Search_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Desktop";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            pictureBox_Image.Image = Image.FromFile(filePath);
            pictureBox_Image.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void button_AddPhoto_Click(object sender, EventArgs e)
        {
            if (f1 != null  )
            {
                Guid guid = Guid.NewGuid();
                var PicturesRepository = RepositoryFactory.CreatePictureRepository();
                Picture pictures = new Picture();
                pictures.Name = guid.ToString() + ".jpg";
                System.Drawing.Image img = System.Drawing.Image.FromFile(filePath);
                pictures.Size = img.Height;
                pictures.CreateDate = f1.date_Add.Value;
                pictures.Path = filePath;

                var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                var sql = "select ID from Estate where Name=@name";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = f1.textBox_Name.Text;
                    if (cmd.ExecuteScalar() != null)
                    {
                        pictures.EstateId = (int)cmd.ExecuteScalar();
                    }
                    else
                    {
                        MessageBox.Show("You can not add new photo if you change the name, save the new name, and after you can edit the photos");
                        this.Close();
                        return;
                    }
                    
                }
              
                    PicturesRepository.Create(pictures);


                    var PictureId = "select ID from Pictures where Name=@name";
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(PictureId, connection);

                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = guid.ToString() + ".jpg";
                        pictures.Id = (int)cmd.ExecuteScalar();

                    }


                    string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
                    ImageList imgs = new ImageList();
                    DirectoryInfo DIR = new DirectoryInfo($"{PicturesPath}\\{f1.textBox_Name.Text}");
                    if (DIR.Exists)
                    {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    Image imageref = Image.FromFile(pictures.Path);
                        imageref.Save($"{PicturesPath}\\{f1.textBox_Name.Text}\\{guid}.jpg");



                        MessageBox.Show("Photo was added with succes, now you can add another one. ");

                       
                    }
                    else
                    {
                        DIR.Create();
                        Image imageref = Image.FromFile(pictures.Path);
                        imageref.Save($"{PicturesPath}\\{f1.textBox_Name.Text}\\{guid}.jpg");
                        MessageBox.Show("Photo was added with succes, now you can add another one. ");


                    }
                }
            
            else
            {
                Guid guid = Guid.NewGuid();
                var PicturesRepository = RepositoryFactory.CreatePictureRepository();
                Picture pictures = new Picture();
                pictures.Name = guid.ToString() + ".jpg";
                System.Drawing.Image img = System.Drawing.Image.FromFile(filePath);
                pictures.Size = img.Height;
                pictures.CreateDate = f2.dateTimePicker1.Value;
                pictures.Path = filePath;

                var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                var sql = "select ID from Estate where Name=@name";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
            
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = f2.textBox_NameEdited.Text;
                    if (cmd.ExecuteScalar() != null)
                    {
                        pictures.EstateId = (int)cmd.ExecuteScalar();
                    }
                    else
                    {
                        MessageBox.Show("You can not add new photo if you change the name, save the new name, and after you can edit the photos");
                        this.Close();
                        return;
                    }
                }

                PicturesRepository.Create(pictures);

                var PictureId = "select ID from Pictures where Name=@name";
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(PictureId, connection);

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = guid.ToString() + ".jpg";
                    pictures.Id = (int)cmd.ExecuteScalar();

                }


                string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
               ImageList imgs = new ImageList();
                DirectoryInfo DIR = new DirectoryInfo($"{PicturesPath}\\{f2.textBox_NameEdited.Text}");
                if (DIR.Exists)
                { 
                  
                    Image imageref = Image.FromFile(pictures.Path);
                    
                       
                        imageref.Save($"{PicturesPath}\\{f2.textBox_NameEdited.Text}\\{guid}.jpg");
                   
                
                    MessageBox.Show("Photo was added with succes, now you can add another one. ");

                    return;
                }
                else
                {
                    DIR.Create();
                    Image imageref = Image.FromFile(pictures.Path);
                    imageref.Save($"{PicturesPath}\\{f2.textBox_NameEdited.Text}\\{guid}.jpg");
                    MessageBox.Show("Photo was added with succes, now you can add another one. ");


                }
            }
            pictureBox_Image.Image.Dispose();
        }

        private void AddPhotos_Load(object sender, EventArgs e)
        {

        }
    }
}

