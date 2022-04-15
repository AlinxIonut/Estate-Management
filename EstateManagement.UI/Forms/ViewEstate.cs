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
    public partial class ViewEstate : Form
    {
        ImageList imgs = new ImageList();
        int count = 0;
        int counts = 0;
        
        AllEstates allEstates = new AllEstates();
        public ViewEstate()
        {
            InitializeComponent();
        }

        public void ImageList()
        {
            imgs.ImageSize = new Size(230, 230);
          
            String[] paths = { };




            string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
            if (Directory.Exists($"{PicturesPath}\\{textBox_NameFolder.Text}"))
            {
                paths = Directory.GetFiles($"{PicturesPath}\\{textBox_NameFolder.Text}");

                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                    
                    listView.Items.Add(Path.GetFileName(path));
                    imgs.Images.SetKeyName(count, Path.GetFileName(path));
                  
                    count++;


                }


            }
        }
        private void PhotoLoad()
        {
            button_DeletePhoto.Enabled = true;
            if (count == 1)
            {
                Prev.Enabled = false;
                Next.Enabled = false;

            }
            try
            {
                pictureBox1.Image = imgs.Images[0];
               

            }
            catch
            {
                pictureBox1.Image = Image.FromFile("D:\\Proiecte c#\\EstateManagement.Models\\nophoto.jpg");
                Prev.Visible = false;
                Next.Visible = false;
                button_DeletePhoto.Enabled = false;
            };
           
        }
        private void ViewEstate_Load(object sender, EventArgs e)
        {
            imgs.ImageSize = new Size(230, 230);
            PhotoLoad();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Prev.Enabled = false;
        }

        private void Prev_Click(object sender, EventArgs e)
        {

            imgs.ImageSize = new Size(230, 230);

            if (counts == 1)
            {
                pictureBox1.Image = imgs.Images[--counts];
                Prev.Enabled = false;
            }
            if (counts > 1)
            {
                Next.Enabled = true;
                Prev.Enabled = true;
                pictureBox1.Image = imgs.Images[--counts];


            }
            else
            {
                Prev.Enabled = false;
                Next.Enabled = true;
            }
pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Next_Click(object sender, EventArgs e)
        {

            imgs.ImageSize = new Size(230, 230);

            if (counts < count - 1)
            {
                Prev.Enabled = true;
                Next.Enabled = true;
                counts++;
                pictureBox1.Image = imgs.Images[counts];


            }
            if (counts == count - 1)
            {

                Next.Enabled = false;
                Prev.Enabled = true;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ViewEstate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void listView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                pictureBox1.Image = imgs.Images[imgs.Images.IndexOfKey(listView.SelectedItems[0].Text)];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
            catch { };
         
        }

        private void button_DeletePhoto_Click(object sender, EventArgs e)
        {
            var photoRepository = RepositoryFactory.CreatePictureRepository();
            Picture picture = new Picture();

            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "select ID from Pictures where Name=@name";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                try
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = listView.SelectedItems[0].Text;
                    picture.Id = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                catch { };
            }

         
            var result = MessageBox.Show("Are u sure u want delete?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                string PicturesPath = ConfigurationManager.AppSettings["PicturesPath"];
                string paths = $"{PicturesPath}\\{textBox_NameFolder.Text}";
                
                if (File.Exists(Path.Combine(paths, listView.SelectedItems[0].Text)))
                {
                  
                     photoRepository.Delete(picture.Id);  
                    MessageBox.Show("Photo  deleted.");
                    imgs.Images.RemoveByKey(listView.SelectedItems[0].Text);
                    pictureBox1.Image = null; 
                     count -=1;
                    PhotoLoad();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(Path.Combine(paths, listView.SelectedItems[0].Text));
                     listView.SelectedItems[0].Remove();
                       

                } 
                else
                      MessageBox.Show("File not found");
            }     
                    
                   
          
            }

      
    }
    }

