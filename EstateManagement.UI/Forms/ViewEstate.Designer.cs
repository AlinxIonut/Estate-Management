
namespace EstateManagement.UI.Forms
{
    partial class ViewEstate
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_Type = new System.Windows.Forms.Label();
            this.l_Price = new System.Windows.Forms.Label();
            this.l_Adress = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.textBox_NameFolder = new System.Windows.Forms.TextBox();
            this.button_DeletePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(431, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(143, 237);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView_ItemCheck);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Photos";
            this.columnHeader1.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prev
            // 
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.Location = new System.Drawing.Point(12, 85);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(36, 33);
            this.Prev.TabIndex = 3;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(286, 85);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(36, 33);
            this.Next.TabIndex = 4;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_Type);
            this.groupBox1.Controls.Add(this.l_Price);
            this.groupBox1.Controls.Add(this.l_Adress);
            this.groupBox1.Controls.Add(this.l_Name);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 252);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // l_Type
            // 
            this.l_Type.AutoSize = true;
            this.l_Type.Location = new System.Drawing.Point(7, 184);
            this.l_Type.Name = "l_Type";
            this.l_Type.Size = new System.Drawing.Size(0, 23);
            this.l_Type.TabIndex = 3;
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Location = new System.Drawing.Point(7, 132);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(0, 23);
            this.l_Price.TabIndex = 2;
            // 
            // l_Adress
            // 
            this.l_Adress.AutoSize = true;
            this.l_Adress.Location = new System.Drawing.Point(6, 86);
            this.l_Adress.Name = "l_Adress";
            this.l_Adress.Size = new System.Drawing.Size(0, 23);
            this.l_Adress.TabIndex = 1;
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(7, 40);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(0, 23);
            this.l_Name.TabIndex = 0;
            // 
            // textBox_NameFolder
            // 
            this.textBox_NameFolder.Location = new System.Drawing.Point(474, 422);
            this.textBox_NameFolder.Name = "textBox_NameFolder";
            this.textBox_NameFolder.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameFolder.TabIndex = 8;
            this.textBox_NameFolder.Visible = false;
            // 
            // button_DeletePhoto
            // 
            this.button_DeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeletePhoto.Location = new System.Drawing.Point(461, 293);
            this.button_DeletePhoto.Name = "button_DeletePhoto";
            this.button_DeletePhoto.Size = new System.Drawing.Size(83, 23);
            this.button_DeletePhoto.TabIndex = 9;
            this.button_DeletePhoto.Text = "Delete";
            this.button_DeletePhoto.UseVisualStyleBackColor = true;
            this.button_DeletePhoto.Click += new System.EventHandler(this.button_DeletePhoto_Click);
            // 
            // ViewEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 680);
            this.Controls.Add(this.button_DeletePhoto);
            this.Controls.Add(this.textBox_NameFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewEstate";
            this.Text = "ViewEstate";
            this.Load += new System.EventHandler(this.ViewEstate_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewEstate_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label l_Type;
        public System.Windows.Forms.Label l_Price;
        public System.Windows.Forms.Label l_Adress;
        public System.Windows.Forms.Label l_Name;
        public System.Windows.Forms.TextBox textBox_NameFolder;
        private System.Windows.Forms.Button button_DeletePhoto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}