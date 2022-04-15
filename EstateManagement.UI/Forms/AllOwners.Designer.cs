
namespace EstateManagement.UI.Forms
{
    partial class AllOwners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOwners));
            this.dgv_Owners = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ShutDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owners)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Owners
            // 
            this.dgv_Owners.AllowUserToAddRows = false;
            this.dgv_Owners.AllowUserToDeleteRows = false;
            this.dgv_Owners.AllowUserToResizeColumns = false;
            this.dgv_Owners.AllowUserToResizeRows = false;
            this.dgv_Owners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Owners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Owners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Owners.Location = new System.Drawing.Point(78, 90);
            this.dgv_Owners.Name = "dgv_Owners";
            this.dgv_Owners.ReadOnly = true;
            this.dgv_Owners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Owners.Size = new System.Drawing.Size(628, 313);
            this.dgv_Owners.TabIndex = 0;
            this.dgv_Owners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Owners_CellContentClick);
            this.dgv_Owners.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Owners_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(78, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 13;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.button_ShutDown.Location = new System.Drawing.Point(744, 12);
            this.button_ShutDown.Name = "button_ShutDown";
            this.button_ShutDown.Size = new System.Drawing.Size(42, 40);
            this.button_ShutDown.TabIndex = 12;
            this.button_ShutDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ShutDown.UseVisualStyleBackColor = true;
            this.button_ShutDown.Click += new System.EventHandler(this.button_ShutDown_Click);
            // 
            // AllOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ShutDown);
            this.Controls.Add(this.dgv_Owners);
            this.Name = "AllOwners";
            this.Text = "AllOwners";
            this.Load += new System.EventHandler(this.AllOwners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Owners;
        private System.Windows.Forms.Button button_ShutDown;
        private System.Windows.Forms.Button button1;
    }
}