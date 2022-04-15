
namespace EstateManagement.UI.Forms
{
    partial class Edit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditForm_Name = new System.Windows.Forms.TextBox();
            this.textBoxEditForm_Email = new System.Windows.Forms.TextBox();
            this.textBoxEditForm_Phone = new System.Windows.Forms.TextBox();
            this.textBoxEditForm_CNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_IdEdit = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // textBoxEditForm_Name
            // 
            this.textBoxEditForm_Name.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEditForm_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditForm_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEditForm_Name.Location = new System.Drawing.Point(27, 75);
            this.textBoxEditForm_Name.Name = "textBoxEditForm_Name";
            this.textBoxEditForm_Name.Size = new System.Drawing.Size(100, 13);
            this.textBoxEditForm_Name.TabIndex = 6;
            // 
            // textBoxEditForm_Email
            // 
            this.textBoxEditForm_Email.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEditForm_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditForm_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEditForm_Email.Location = new System.Drawing.Point(27, 162);
            this.textBoxEditForm_Email.Name = "textBoxEditForm_Email";
            this.textBoxEditForm_Email.Size = new System.Drawing.Size(100, 13);
            this.textBoxEditForm_Email.TabIndex = 7;
            this.textBoxEditForm_Email.Validated += new System.EventHandler(this.textBoxEditForm_Email_Validated);
            // 
            // textBoxEditForm_Phone
            // 
            this.textBoxEditForm_Phone.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEditForm_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditForm_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEditForm_Phone.Location = new System.Drawing.Point(27, 242);
            this.textBoxEditForm_Phone.Name = "textBoxEditForm_Phone";
            this.textBoxEditForm_Phone.Size = new System.Drawing.Size(100, 13);
            this.textBoxEditForm_Phone.TabIndex = 8;
            this.textBoxEditForm_Phone.TextChanged += new System.EventHandler(this.textBoxEditForm_Phone_TextChanged);
            this.textBoxEditForm_Phone.Validated += new System.EventHandler(this.textBoxEditForm_Phone_Validated);
            // 
            // textBoxEditForm_CNP
            // 
            this.textBoxEditForm_CNP.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEditForm_CNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditForm_CNP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEditForm_CNP.Location = new System.Drawing.Point(27, 324);
            this.textBoxEditForm_CNP.Name = "textBoxEditForm_CNP";
            this.textBoxEditForm_CNP.Size = new System.Drawing.Size(100, 13);
            this.textBoxEditForm_CNP.TabIndex = 9;
            this.textBoxEditForm_CNP.Validated += new System.EventHandler(this.textBoxEditForm_CNP_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "CNP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(27, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_IdEdit
            // 
            this.textBox_IdEdit.BackColor = System.Drawing.Color.White;
            this.textBox_IdEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_IdEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_IdEdit.Location = new System.Drawing.Point(12, 425);
            this.textBox_IdEdit.Name = "textBox_IdEdit";
            this.textBox_IdEdit.Size = new System.Drawing.Size(100, 13);
            this.textBox_IdEdit.TabIndex = 16;
            this.textBox_IdEdit.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 450);
            this.Controls.Add(this.textBox_IdEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEditForm_CNP);
            this.Controls.Add(this.textBoxEditForm_Phone);
            this.Controls.Add(this.textBoxEditForm_Email);
            this.Controls.Add(this.textBoxEditForm_Name);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxEditForm_Name;
        public System.Windows.Forms.TextBox textBoxEditForm_Email;
        public System.Windows.Forms.TextBox textBoxEditForm_Phone;
        public System.Windows.Forms.TextBox textBoxEditForm_CNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_IdEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}