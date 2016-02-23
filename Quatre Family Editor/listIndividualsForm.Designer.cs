namespace Quatre
{
    partial class listIndividualsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listIndividualsForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listIndividuals = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelFamilies = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFromFamily = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDateOfDeath = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewFamily = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(611, 335);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search:";
            // 
            // listIndividuals
            // 
            this.listIndividuals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listIndividuals.FullRowSelect = true;
            this.listIndividuals.GridLines = true;
            this.listIndividuals.Location = new System.Drawing.Point(9, 36);
            this.listIndividuals.MultiSelect = false;
            this.listIndividuals.Name = "listIndividuals";
            this.listIndividuals.Size = new System.Drawing.Size(313, 293);
            this.listIndividuals.TabIndex = 15;
            this.listIndividuals.TileSize = new System.Drawing.Size(349, 30);
            this.listIndividuals.UseCompatibleStateImageBehavior = false;
            this.listIndividuals.View = System.Windows.Forms.View.Tile;
            this.listIndividuals.SelectedIndexChanged += new System.EventHandler(this.listIndividuals_SelectedIndexChanged);
            this.listIndividuals.DoubleClick += new System.EventHandler(this.listIndividuals_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelDetails);
            this.groupBox1.Location = new System.Drawing.Point(328, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 327);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.panelFamilies);
            this.panelDetails.Controls.Add(this.label11);
            this.panelDetails.Controls.Add(this.lblFromFamily);
            this.panelDetails.Controls.Add(this.label10);
            this.panelDetails.Controls.Add(this.lblDateOfDeath);
            this.panelDetails.Controls.Add(this.lblProfession);
            this.panelDetails.Controls.Add(this.lblSex);
            this.panelDetails.Controls.Add(this.lblPlaceOfBirth);
            this.panelDetails.Controls.Add(this.lblDateOfBirth);
            this.panelDetails.Controls.Add(this.lblSurname);
            this.panelDetails.Controls.Add(this.lblGivenName);
            this.panelDetails.Controls.Add(this.lblName);
            this.panelDetails.Controls.Add(this.label9);
            this.panelDetails.Controls.Add(this.label8);
            this.panelDetails.Controls.Add(this.label7);
            this.panelDetails.Controls.Add(this.label6);
            this.panelDetails.Controls.Add(this.label5);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Location = new System.Drawing.Point(14, 15);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(338, 306);
            this.panelDetails.TabIndex = 16;
            this.panelDetails.Visible = false;
            // 
            // panelFamilies
            // 
            this.panelFamilies.Location = new System.Drawing.Point(112, 228);
            this.panelFamilies.Name = "panelFamilies";
            this.panelFamilies.Size = new System.Drawing.Size(223, 75);
            this.panelFamilies.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Own Families:";
            // 
            // lblFromFamily
            // 
            this.lblFromFamily.Location = new System.Drawing.Point(109, 202);
            this.lblFromFamily.Name = "lblFromFamily";
            this.lblFromFamily.Size = new System.Drawing.Size(226, 25);
            this.lblFromFamily.TabIndex = 33;
            this.lblFromFamily.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "From Family:";
            // 
            // lblDateOfDeath
            // 
            this.lblDateOfDeath.AutoSize = true;
            this.lblDateOfDeath.Location = new System.Drawing.Point(109, 177);
            this.lblDateOfDeath.Name = "lblDateOfDeath";
            this.lblDateOfDeath.Size = new System.Drawing.Size(41, 13);
            this.lblDateOfDeath.TabIndex = 31;
            this.lblDateOfDeath.Text = "label17";
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(109, 152);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(41, 13);
            this.lblProfession.TabIndex = 30;
            this.lblProfession.Text = "label16";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(109, 128);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 13);
            this.lblSex.TabIndex = 29;
            this.lblSex.Text = "label15";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(109, 105);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(41, 13);
            this.lblPlaceOfBirth.TabIndex = 28;
            this.lblPlaceOfBirth.Text = "label14";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(109, 81);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(41, 13);
            this.lblDateOfBirth.TabIndex = 27;
            this.lblDateOfBirth.Text = "label13";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(109, 58);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(41, 13);
            this.lblSurname.TabIndex = 26;
            this.lblSurname.Text = "label12";
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Location = new System.Drawing.Point(109, 35);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(41, 13);
            this.lblGivenName.TabIndex = 25;
            this.lblGivenName.Text = "label11";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Date of Death:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Profession:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Place of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Givenname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(530, 335);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 20;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(9, 335);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(102, 23);
            this.buttonNew.TabIndex = 21;
            this.buttonNew.Text = "New Individual";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(117, 335);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete Individual";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewFamily
            // 
            this.buttonNewFamily.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewFamily.Image")));
            this.buttonNewFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewFamily.Location = new System.Drawing.Point(358, 335);
            this.buttonNewFamily.Name = "buttonNewFamily";
            this.buttonNewFamily.Size = new System.Drawing.Size(95, 23);
            this.buttonNewFamily.TabIndex = 23;
            this.buttonNewFamily.Text = "New Family";
            this.buttonNewFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewFamily.UseVisualStyleBackColor = true;
            this.buttonNewFamily.Click += new System.EventHandler(this.buttonNewFamily_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(297, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(25, 23);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listIndividualsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 364);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNewFamily);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listIndividuals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listIndividualsForm";
            this.ShowInTaskbar = false;
            this.Text = "Individuals Search";
            this.Load += new System.EventHandler(this.listIndividualsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listIndividuals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblDateOfDeath;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFromFamily;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonNewFamily;
        private System.Windows.Forms.Panel panelFamilies;
        private System.Windows.Forms.Button buttonRefresh;
    }
}