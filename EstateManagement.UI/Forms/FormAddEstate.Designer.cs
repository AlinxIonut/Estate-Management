
namespace EstateManagement.UI.Forms
{
    partial class FormAddEstate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEstate));
            this.dgv_Estate = new System.Windows.Forms.DataGridView();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.date_Add = new System.Windows.Forms.DateTimePicker();
            this.comboBox_OwnerID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_AddEstate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_ShutDown = new System.Windows.Forms.Button();
            this.textBox_IdEstate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_EditEstate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Estate
            // 
            this.dgv_Estate.AllowUserToAddRows = false;
            this.dgv_Estate.AllowUserToDeleteRows = false;
            this.dgv_Estate.AllowUserToResizeColumns = false;
            this.dgv_Estate.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Estate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Estate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Estate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Estate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Estate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Estate.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Estate.EnableHeadersVisualStyles = false;
            this.dgv_Estate.Location = new System.Drawing.Point(207, 78);
            this.dgv_Estate.Name = "dgv_Estate";
            this.dgv_Estate.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estate.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Estate.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Estate.Size = new System.Drawing.Size(565, 311);
            this.dgv_Estate.TabIndex = 13;
            this.dgv_Estate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estate_CellContentClick);
            this.dgv_Estate.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estate_CellContentDoubleClick);
            this.dgv_Estate.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Estate_DataError);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(44, 55);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 14;
            this.textBox_Name.Validated += new System.EventHandler(this.textBox_Name_Validated);
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(41, 116);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 15;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(41, 180);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 16;
            this.textBox_Price.Validated += new System.EventHandler(this.textBox_Price_Validated);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "App ",
            "House",
            "Ground",
            "Office "});
            this.comboBox_Type.Location = new System.Drawing.Point(43, 244);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Type.TabIndex = 17;
            // 
            // date_Add
            // 
            this.date_Add.CustomFormat = "dd/mm/yyy";
            this.date_Add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Add.Location = new System.Drawing.Point(48, 299);
            this.date_Add.Name = "date_Add";
            this.date_Add.Size = new System.Drawing.Size(96, 20);
            this.date_Add.TabIndex = 18;
            this.date_Add.Value = new System.DateTime(2021, 12, 27, 0, 0, 0, 0);
            // 
            // comboBox_OwnerID
            // 
            this.comboBox_OwnerID.FormattingEnabled = true;
            this.comboBox_OwnerID.Location = new System.Drawing.Point(43, 352);
            this.comboBox_OwnerID.Name = "comboBox_OwnerID";
            this.comboBox_OwnerID.Size = new System.Drawing.Size(100, 21);
            this.comboBox_OwnerID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(65, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "TypeOfEstate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(69, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(39, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "OwnerName";
            // 
            // button_AddEstate
            // 
            this.button_AddEstate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AddEstate.FlatAppearance.BorderSize = 0;
            this.button_AddEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddEstate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddEstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_AddEstate.Location = new System.Drawing.Point(45, 393);
            this.button_AddEstate.Name = "button_AddEstate";
            this.button_AddEstate.Size = new System.Drawing.Size(99, 32);
            this.button_AddEstate.TabIndex = 26;
            this.button_AddEstate.Text = "Add";
            this.button_AddEstate.UseVisualStyleBackColor = false;
            this.button_AddEstate.Click += new System.EventHandler(this.button_AddEstate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_ShutDown
            // 
            this.button_ShutDown.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_ShutDown.FlatAppearance.BorderSize = 0;
            this.button_ShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShutDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShutDown.ForeColor = System.Drawing.Color.White;
            this.button_ShutDown.Image = ((System.Drawing.Image)(resources.GetObject("button_ShutDown.Image")));
            this.button_ShutDown.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_ShutDown.Location = new System.Drawing.Point(757, 14);
            this.button_ShutDown.Name = "button_ShutDown";
            this.button_ShutDown.Size = new System.Drawing.Size(42, 40);
            this.button_ShutDown.TabIndex = 28;
            this.button_ShutDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ShutDown.UseVisualStyleBackColor = true;
            this.button_ShutDown.Click += new System.EventHandler(this.button_ShutDown_Click);
            // 
            // textBox_IdEstate
            // 
            this.textBox_IdEstate.Location = new System.Drawing.Point(699, 405);
            this.textBox_IdEstate.Name = "textBox_IdEstate";
            this.textBox_IdEstate.Size = new System.Drawing.Size(100, 20);
            this.textBox_IdEstate.TabIndex = 29;
            this.textBox_IdEstate.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_EditEstate
            // 
            this.button_EditEstate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_EditEstate.FlatAppearance.BorderSize = 0;
            this.button_EditEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditEstate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditEstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_EditEstate.Location = new System.Drawing.Point(41, 393);
            this.button_EditEstate.Name = "button_EditEstate";
            this.button_EditEstate.Size = new System.Drawing.Size(103, 32);
            this.button_EditEstate.TabIndex = 30;
            this.button_EditEstate.Text = "Edit";
            this.button_EditEstate.UseVisualStyleBackColor = false;
            this.button_EditEstate.Click += new System.EventHandler(this.button_EditEstate_Click);
            // 
            // FormAddEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.button_EditEstate);
            this.Controls.Add(this.textBox_IdEstate);
            this.Controls.Add(this.button_ShutDown);
            this.Controls.Add(this.button_AddEstate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_OwnerID);
            this.Controls.Add(this.date_Add);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.dgv_Estate);
            this.Name = "FormAddEstate";
            this.Text = "FormAddEstate";
            this.Load += new System.EventHandler(this.FormAddEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Estate;
        public System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ComboBox comboBox_Type;
        public System.Windows.Forms.DateTimePicker date_Add;
        private System.Windows.Forms.ComboBox comboBox_OwnerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_AddEstate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_ShutDown;
        public System.Windows.Forms.TextBox textBox_IdEstate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_EditEstate;
    }
}