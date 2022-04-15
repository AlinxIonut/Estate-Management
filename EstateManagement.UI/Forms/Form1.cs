using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.UI
{

    public partial class Form1 : Form
    {
        private Form activeForm;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //de exemplu, daca doresc ca creez un estate
            var estateRepository = RepositoryFactory.CreateEstateRepository();

            //incarc un Estate din interfata (toate datele, initial fara poze!, ulterior, voi putea adauga poze!!)
            Estate estate = new Estate(); //obtinut din interfata
            MessageBox.Show(estate.Name);
            estateRepository.Create(estate); //!!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adaugarea unei noi poze in sistem, la un estate existent
            //avem nevoie de estateId
            var pictureRepository = RepositoryFactory.CreatePictureRepository();
            Picture picture = new Picture();
            pictureRepository.Create(picture);

            //salvarea fisierul pe disk, intr-un folder cu numele dat de id-ul estate-ului (estateId)
            //de exemplu, daca un estate are id-ul 5, toate pozele lui se vor salva in Picture/5/...
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
        public void ShowOwnerMenu()
        {
            if (panel_Owner.Visible == false)
            {
                panel_Owner.Visible = true;
            }
            else
                panel_Owner.Visible = false;
        }
        private void button_Owner_Click(object sender, EventArgs e)
        {
            ShowOwnerMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           panel_Owner.Visible = false;
            panel_Estate.Visible = false;
        }
        public void ShowEstateMenu()
        {
            if (panel_Estate.Visible == false)
            {
                panel_Estate.Visible = true;
            }
            else
                panel_Estate.Visible = false;
        }
        private void button_Estate_Click(object sender, EventArgs e)
        {
            ShowEstateMenu();
        }

        private void button_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenForm(Form form)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel_Main.Controls.Add(form);
            this.panel_Main.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void button_AddOwner_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.AddOwner());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.AllOwners());

        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_logo_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void button_Home_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }



        }

        private void button_AddEstate_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormAddEstate());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new Forms.AllEstates());
        }
    }
}
