
namespace EstateManagement.UI.Forms
{
    partial class AddPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_AddPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Location = new System.Drawing.Point(89, 12);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(225, 154);
            this.pictureBox_Image.TabIndex = 0;
            this.pictureBox_Image.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Search
            // 
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(73, 172);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(85, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "SearchPhoto";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_AddPhoto
            // 
            this.button_AddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddPhoto.Location = new System.Drawing.Point(245, 172);
            this.button_AddPhoto.Name = "button_AddPhoto";
            this.button_AddPhoto.Size = new System.Drawing.Size(69, 23);
            this.button_AddPhoto.TabIndex = 2;
            this.button_AddPhoto.Text = "Add";
            this.button_AddPhoto.UseVisualStyleBackColor = true;
            this.button_AddPhoto.Click += new System.EventHandler(this.button_AddPhoto_Click);
            // 
            // AddPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 422);
            this.Controls.Add(this.button_AddPhoto);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.pictureBox_Image);
            this.Name = "AddPhotos";
            this.Text = "AddPhotos";
            this.Load += new System.EventHandler(this.AddPhotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_AddPhoto;
    }
}