namespace Quatre
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFamilyButton = new System.Windows.Forms.ToolStripButton();
            this.newIndividualButton = new System.Windows.Forms.ToolStripButton();
            this.loadGEDButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.listFamilies = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.panelChildren = new System.Windows.Forms.Panel();
            this.panelChildList = new System.Windows.Forms.Panel();
            this.lblChildren = new System.Windows.Forms.Label();
            this.panelFamilies = new System.Windows.Forms.Panel();
            this.linkNameSurname = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelChildren.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFamilyButton,
            this.newIndividualButton,
            this.loadGEDButton,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFamilyButton
            // 
            this.newFamilyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFamilyButton.Image = ((System.Drawing.Image)(resources.GetObject("newFamilyButton.Image")));
            this.newFamilyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFamilyButton.Name = "newFamilyButton";
            this.newFamilyButton.Size = new System.Drawing.Size(23, 22);
            this.newFamilyButton.Text = "New Family";
            this.newFamilyButton.Click += new System.EventHandler(this.newFamilyButton_Click);
            // 
            // newIndividualButton
            // 
            this.newIndividualButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newIndividualButton.Image = ((System.Drawing.Image)(resources.GetObject("newIndividualButton.Image")));
            this.newIndividualButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newIndividualButton.Name = "newIndividualButton";
            this.newIndividualButton.Size = new System.Drawing.Size(23, 22);
            this.newIndividualButton.Text = "New Person";
            this.newIndividualButton.Click += new System.EventHandler(this.newIndividualButton_Click);
            // 
            // loadGEDButton
            // 
            this.loadGEDButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loadGEDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadGEDButton.Image = ((System.Drawing.Image)(resources.GetObject("loadGEDButton.Image")));
            this.loadGEDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadGEDButton.Name = "loadGEDButton";
            this.loadGEDButton.Size = new System.Drawing.Size(23, 22);
            this.loadGEDButton.Text = "Load GED";
            this.loadGEDButton.Click += new System.EventHandler(this.loadGEDButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Backup";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "List Individuals";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Export HTML";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // listFamilies
            // 
            this.listFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listFamilies.FullRowSelect = true;
            this.listFamilies.GridLines = true;
            this.listFamilies.LargeImageList = this.imageList1;
            this.listFamilies.Location = new System.Drawing.Point(12, 67);
            this.listFamilies.MultiSelect = false;
            this.listFamilies.Name = "listFamilies";
            this.listFamilies.Size = new System.Drawing.Size(370, 351);
            this.listFamilies.SmallImageList = this.imageList1;
            this.listFamilies.TabIndex = 1;
            this.listFamilies.TileSize = new System.Drawing.Size(349, 30);
            this.listFamilies.UseCompatibleStateImageBehavior = false;
            this.listFamilies.View = System.Windows.Forms.View.Tile;
            this.listFamilies.SelectedIndexChanged += new System.EventHandler(this.listFamilies_SelectedIndexChanged);
            this.listFamilies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFamilies_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1370694315_agt_family.png");
            this.imageList1.Images.SetKeyName(1, "1370694414_emblem-people.png");
            this.imageList1.Images.SetKeyName(2, "1370696813_ark2.png");
            this.imageList1.Images.SetKeyName(3, "tredoux_logo.ico");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.lblDetails);
            this.groupBox1.Controls.Add(this.panelChildren);
            this.groupBox1.Controls.Add(this.panelFamilies);
            this.groupBox1.Controls.Add(this.linkNameSurname);
            this.groupBox1.Location = new System.Drawing.Point(388, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Family Details";
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(7, 86);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(48, 13);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Details...";
            this.lblDetails.Visible = false;
            // 
            // panelChildren
            // 
            this.panelChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildren.Controls.Add(this.panelChildList);
            this.panelChildren.Controls.Add(this.lblChildren);
            this.panelChildren.Location = new System.Drawing.Point(10, 181);
            this.panelChildren.Name = "panelChildren";
            this.panelChildren.Size = new System.Drawing.Size(368, 140);
            this.panelChildren.TabIndex = 3;
            this.panelChildren.Visible = false;
            // 
            // panelChildList
            // 
            this.panelChildList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildList.Location = new System.Drawing.Point(4, 17);
            this.panelChildList.Name = "panelChildList";
            this.panelChildList.Size = new System.Drawing.Size(361, 120);
            this.panelChildList.TabIndex = 1;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(-3, 0);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(157, 13);
            this.lblChildren.TabIndex = 0;
            this.lblChildren.Text = "They had the following children:";
            // 
            // panelFamilies
            // 
            this.panelFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFamilies.Location = new System.Drawing.Point(10, 39);
            this.panelFamilies.Name = "panelFamilies";
            this.panelFamilies.Size = new System.Drawing.Size(368, 44);
            this.panelFamilies.TabIndex = 1;
            // 
            // linkNameSurname
            // 
            this.linkNameSurname.AutoSize = true;
            this.linkNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNameSurname.Location = new System.Drawing.Point(7, 20);
            this.linkNameSurname.Name = "linkNameSurname";
            this.linkNameSurname.Size = new System.Drawing.Size(111, 15);
            this.linkNameSurname.TabIndex = 0;
            this.linkNameSurname.TabStop = true;
            this.linkNameSurname.Text = "Name & Surname";
            this.linkNameSurname.Visible = false;
            this.linkNameSurname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNameSurname_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(697, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Resize += new System.EventHandler(this.btnDelete_Resize);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(616, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quatre Family Editor is design and build by treXis.  Copyright ©  2013";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Family Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(88, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(357, 39);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(25, 23);
            this.buttonRefresh.TabIndex = 25;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFamilies);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Text = "Quatre Family Editor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelChildren.ResumeLayout(false);
            this.panelChildren.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newFamilyButton;
        private System.Windows.Forms.ToolStripButton newIndividualButton;
        private System.Windows.Forms.ListView listFamilies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton loadGEDButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelChildren;
        private System.Windows.Forms.Panel panelFamilies;
        private System.Windows.Forms.LinkLabel linkNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Panel panelChildList;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

