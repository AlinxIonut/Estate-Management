
namespace EstateManagement.UI.Forms
{
    partial class AllEstates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEstates));
            this.dgv_Estates = new System.Windows.Forms.DataGridView();
            this.button_RefreshEstate = new System.Windows.Forms.Button();
            this.button_ShutDown = new System.Windows.Forms.Button();
            this.comboBox_OwnerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SearchByName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_PriceMin = new System.Windows.Forms.TextBox();
            this.textBox_PriceMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estates)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Estates
            // 
            this.dgv_Estates.AllowUserToAddRows = false;
            this.dgv_Estates.AllowUserToDeleteRows = false;
            this.dgv_Estates.AllowUserToResizeColumns = false;
            this.dgv_Estates.AllowUserToResizeRows = false;
            this.dgv_Estates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Estates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Estates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estates.Location = new System.Drawing.Point(76, 90);
            this.dgv_Estates.Name = "dgv_Estates";
            this.dgv_Estates.ReadOnly = true;
            this.dgv_Estates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Estates.Size = new System.Drawing.Size(628, 313);
            this.dgv_Estates.TabIndex = 1;
            this.dgv_Estates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estates_CellContentClick);
            this.dgv_Estates.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estates_CellContentDoubleClick);
            // 
            // button_RefreshEstate
            // 
            this.button_RefreshEstate.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_RefreshEstate.FlatAppearance.BorderSize = 0;
            this.button_RefreshEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RefreshEstate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RefreshEstate.ForeColor = System.Drawing.Color.White;
            this.button_RefreshEstate.Image = ((System.Drawing.Image)(resources.GetObject("button_RefreshEstate.Image")));
            this.button_RefreshEstate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_RefreshEstate.Location = new System.Drawing.Point(76, 44);
            this.button_RefreshEstate.Name = "button_RefreshEstate";
            this.button_RefreshEstate.Size = new System.Drawing.Size(42, 40);
            this.button_RefreshEstate.TabIndex = 14;
            this.button_RefreshEstate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_RefreshEstate.UseVisualStyleBackColor = true;
            this.button_RefreshEstate.Click += new System.EventHandler(this.button_RefreshEstate_Click);
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
            this.button_ShutDown.Location = new System.Drawing.Point(737, 12);
            this.button_ShutDown.Name = "button_ShutDown";
            this.button_ShutDown.Size = new System.Drawing.Size(42, 40);
            this.button_ShutDown.TabIndex = 15;
            this.button_ShutDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ShutDown.UseVisualStyleBackColor = true;
            this.button_ShutDown.Click += new System.EventHandler(this.button_ShutDown_Click);
            // 
            // comboBox_OwnerList
            // 
            this.comboBox_OwnerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_OwnerList.FormattingEnabled = true;
            this.comboBox_OwnerList.Location = new System.Drawing.Point(583, 63);
            this.comboBox_OwnerList.Name = "comboBox_OwnerList";
            this.comboBox_OwnerList.Size = new System.Drawing.Size(121, 21);
            this.comboBox_OwnerList.TabIndex = 16;
            this.comboBox_OwnerList.SelectedIndexChanged += new System.EventHandler(this.comboBox_OwnerList_SelectedIndexChanged);
            this.comboBox_OwnerList.SelectedValueChanged += new System.EventHandler(this.comboBox_OwnerList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Owner";
            // 
            // textBox_SearchByName
            // 
            this.textBox_SearchByName.Location = new System.Drawing.Point(293, 64);
            this.textBox_SearchByName.Name = "textBox_SearchByName";
            this.textBox_SearchByName.Size = new System.Drawing.Size(170, 20);
            this.textBox_SearchByName.TabIndex = 18;
            this.textBox_SearchByName.TextChanged += new System.EventHandler(this.textBox_SearchByName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_PriceMax);
            this.groupBox1.Controls.Add(this.textBox_PriceMin);
            this.groupBox1.Location = new System.Drawing.Point(257, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // textBox_PriceMin
            // 
            this.textBox_PriceMin.Location = new System.Drawing.Point(60, 26);
            this.textBox_PriceMin.Name = "textBox_PriceMin";
            this.textBox_PriceMin.Size = new System.Drawing.Size(51, 20);
            this.textBox_PriceMin.TabIndex = 0;
            // 
            // textBox_PriceMax
            // 
            this.textBox_PriceMax.Location = new System.Drawing.Point(187, 26);
            this.textBox_PriceMax.Name = "textBox_PriceMax";
            this.textBox_PriceMax.Size = new System.Drawing.Size(52, 20);
            this.textBox_PriceMax.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "max:";
            // 
            // button_Find
            // 
            this.button_Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Find.Location = new System.Drawing.Point(541, 430);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Find.TabIndex = 21;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // AllEstates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 462);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_SearchByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_OwnerList);
            this.Controls.Add(this.button_ShutDown);
            this.Controls.Add(this.button_RefreshEstate);
            this.Controls.Add(this.dgv_Estates);
            this.Name = "AllEstates";
            this.Text = "AllEstates";
            this.Load += new System.EventHandler(this.AllEstates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Estates;
        private System.Windows.Forms.Button button_RefreshEstate;
        private System.Windows.Forms.Button button_ShutDown;
        private System.Windows.Forms.ComboBox comboBox_OwnerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SearchByName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PriceMax;
        private System.Windows.Forms.TextBox textBox_PriceMin;
        private System.Windows.Forms.Button button_Find;
    }
}