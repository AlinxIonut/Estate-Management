
namespace EstateManagement.UI.Forms
{
    partial class AddOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOwner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_AddOwner = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ShutDown = new System.Windows.Forms.Button();
            this.dgv_Owner = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_CNP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddOwner
            // 
            this.btn_AddOwner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddOwner.FlatAppearance.BorderSize = 0;
            this.btn_AddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOwner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOwner.ForeColor = System.Drawing.Color.Red;
            this.btn_AddOwner.Location = new System.Drawing.Point(39, 388);
            this.btn_AddOwner.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddOwner.Name = "btn_AddOwner";
            this.btn_AddOwner.Size = new System.Drawing.Size(104, 28);
            this.btn_AddOwner.TabIndex = 1;
            this.btn_AddOwner.Text = "AddOwner";
            this.btn_AddOwner.UseVisualStyleBackColor = false;
            this.btn_AddOwner.Click += new System.EventHandler(this.btn_AddOwner_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Name.Location = new System.Drawing.Point(43, 109);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 13);
            this.textBox_Name.TabIndex = 3;
            this.textBox_Name.Validated += new System.EventHandler(this.textBox_Name_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.White;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Email.Location = new System.Drawing.Point(43, 181);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 13);
            this.textBox_Email.TabIndex = 5;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            this.textBox_Email.Validated += new System.EventHandler(this.textBox_Email_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.BackColor = System.Drawing.Color.White;
            this.textBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Phone.Location = new System.Drawing.Point(43, 250);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 13);
            this.textBox_Phone.TabIndex = 7;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            this.textBox_Phone.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "CNP";
            // 
            // button_ShutDown
            // 
            this.button_ShutDown.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_ShutDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ShutDown.FlatAppearance.BorderSize = 0;
            this.button_ShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShutDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShutDown.ForeColor = System.Drawing.Color.White;
            this.button_ShutDown.Image = ((System.Drawing.Image)(resources.GetObject("button_ShutDown.Image")));
            this.button_ShutDown.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_ShutDown.Location = new System.Drawing.Point(736, 0);
            this.button_ShutDown.Name = "button_ShutDown";
            this.button_ShutDown.Size = new System.Drawing.Size(36, 450);
            this.button_ShutDown.TabIndex = 11;
            this.button_ShutDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ShutDown.UseVisualStyleBackColor = true;
            this.button_ShutDown.Click += new System.EventHandler(this.button_ShutDown_Click);
            // 
            // dgv_Owner
            // 
            this.dgv_Owner.AllowUserToAddRows = false;
            this.dgv_Owner.AllowUserToDeleteRows = false;
            this.dgv_Owner.AllowUserToResizeColumns = false;
            this.dgv_Owner.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Owner.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Owner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Owner.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Owner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Owner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Owner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Owner.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Owner.EnableHeadersVisualStyles = false;
            this.dgv_Owner.Location = new System.Drawing.Point(214, 91);
            this.dgv_Owner.Name = "dgv_Owner";
            this.dgv_Owner.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Owner.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Owner.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Owner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Owner.Size = new System.Drawing.Size(523, 311);
            this.dgv_Owner.TabIndex = 12;
            this.dgv_Owner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Owner_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.BackColor = System.Drawing.Color.White;
            this.textBox_CNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CNP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_CNP.Location = new System.Drawing.Point(43, 326);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(100, 13);
            this.textBox_CNP.TabIndex = 13;
            this.textBox_CNP.Validated += new System.EventHandler(this.textBox_CNP_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(29, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.Color.White;
            this.textBox_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Id.Location = new System.Drawing.Point(615, 425);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 13);
            this.textBox_Id.TabIndex = 15;
            this.textBox_Id.Visible = false;
            // 
            // AddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_CNP);
            this.Controls.Add(this.dgv_Owner);
            this.Controls.Add(this.button_ShutDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.btn_AddOwner);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddOwner";
            this.Text = "AddOwner";
            this.Load += new System.EventHandler(this.AddOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddOwner;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ShutDown;
        public System.Windows.Forms.DataGridView dgv_Owner;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_Id;
    }
}