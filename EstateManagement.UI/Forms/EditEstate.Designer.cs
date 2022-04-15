
namespace EstateManagement.UI.Forms
{
    partial class EditEstate
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NameEdited = new System.Windows.Forms.TextBox();
            this.textBox_AddressEdited = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PriceEdited = new System.Windows.Forms.TextBox();
            this.comboBox_TypeEdited = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_OwnerEdited = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_EditEstate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_IdEdited = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // textBox_NameEdited
            // 
            this.textBox_NameEdited.Location = new System.Drawing.Point(31, 30);
            this.textBox_NameEdited.Name = "textBox_NameEdited";
            this.textBox_NameEdited.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameEdited.TabIndex = 22;
            // 
            // textBox_AddressEdited
            // 
            this.textBox_AddressEdited.Location = new System.Drawing.Point(31, 92);
            this.textBox_AddressEdited.Name = "textBox_AddressEdited";
            this.textBox_AddressEdited.Size = new System.Drawing.Size(100, 20);
            this.textBox_AddressEdited.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Price";
            // 
            // textBox_PriceEdited
            // 
            this.textBox_PriceEdited.Location = new System.Drawing.Point(31, 151);
            this.textBox_PriceEdited.Name = "textBox_PriceEdited";
            this.textBox_PriceEdited.Size = new System.Drawing.Size(100, 20);
            this.textBox_PriceEdited.TabIndex = 26;
            // 
            // comboBox_TypeEdited
            // 
            this.comboBox_TypeEdited.FormattingEnabled = true;
            this.comboBox_TypeEdited.Items.AddRange(new object[] {
            "App ",
            "House",
            "Ground",
            "Office "});
            this.comboBox_TypeEdited.Location = new System.Drawing.Point(31, 208);
            this.comboBox_TypeEdited.Name = "comboBox_TypeEdited";
            this.comboBox_TypeEdited.Size = new System.Drawing.Size(100, 21);
            this.comboBox_TypeEdited.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(49, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Type";
            // 
            // comboBox_OwnerEdited
            // 
            this.comboBox_OwnerEdited.FormattingEnabled = true;
            this.comboBox_OwnerEdited.Location = new System.Drawing.Point(31, 270);
            this.comboBox_OwnerEdited.Name = "comboBox_OwnerEdited";
            this.comboBox_OwnerEdited.Size = new System.Drawing.Size(100, 21);
            this.comboBox_OwnerEdited.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "OwnerName";
            // 
            // button_EditEstate
            // 
            this.button_EditEstate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_EditEstate.FlatAppearance.BorderSize = 0;
            this.button_EditEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditEstate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditEstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_EditEstate.Location = new System.Drawing.Point(28, 375);
            this.button_EditEstate.Name = "button_EditEstate";
            this.button_EditEstate.Size = new System.Drawing.Size(103, 32);
            this.button_EditEstate.TabIndex = 31;
            this.button_EditEstate.Text = "Edit";
            this.button_EditEstate.UseVisualStyleBackColor = false;
            this.button_EditEstate.Click += new System.EventHandler(this.button_EditEstate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 324);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(51, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date";
            // 
            // textBox_IdEdited
            // 
            this.textBox_IdEdited.Location = new System.Drawing.Point(28, 418);
            this.textBox_IdEdited.Name = "textBox_IdEdited";
            this.textBox_IdEdited.Size = new System.Drawing.Size(10, 20);
            this.textBox_IdEdited.TabIndex = 34;
            this.textBox_IdEdited.Visible = false;
            // 
            // EditEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 450);
            this.Controls.Add(this.textBox_IdEdited);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_EditEstate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_OwnerEdited);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_TypeEdited);
            this.Controls.Add(this.textBox_PriceEdited);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_AddressEdited);
            this.Controls.Add(this.textBox_NameEdited);
            this.Controls.Add(this.label1);
            this.Name = "EditEstate";
            this.Text = "EditEstate";
            this.Load += new System.EventHandler(this.EditEstate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_NameEdited;
        public System.Windows.Forms.TextBox textBox_AddressEdited;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_PriceEdited;
        public System.Windows.Forms.ComboBox comboBox_TypeEdited;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox_OwnerEdited;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button_EditEstate;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_IdEdited;
    }
}