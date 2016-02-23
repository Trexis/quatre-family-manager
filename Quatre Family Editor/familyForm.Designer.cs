namespace Quatre
{
    partial class formFamily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFamily));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveWife = new System.Windows.Forms.Button();
            this.buttonSelectWife = new System.Windows.Forms.Button();
            this.lblWife = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveHusband = new System.Windows.Forms.Button();
            this.buttonAddHusband = new System.Windows.Forms.Button();
            this.lblHusband = new System.Windows.Forms.Label();
            this.txtDateDivorsed = new System.Windows.Forms.TextBox();
            this.txtPlaceMarried = new System.Windows.Forms.TextBox();
            this.txtDateMarried = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveChild = new System.Windows.Forms.Button();
            this.buttonAddChild = new System.Windows.Forms.Button();
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtDateDivorsed);
            this.groupBox1.Controls.Add(this.txtPlaceMarried);
            this.groupBox1.Controls.Add(this.txtDateMarried);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRemoveWife);
            this.groupBox4.Controls.Add(this.buttonSelectWife);
            this.groupBox4.Controls.Add(this.lblWife);
            this.groupBox4.Location = new System.Drawing.Point(3, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 57);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wife";
            // 
            // buttonRemoveWife
            // 
            this.buttonRemoveWife.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveWife.Image")));
            this.buttonRemoveWife.Location = new System.Drawing.Point(231, 18);
            this.buttonRemoveWife.Name = "buttonRemoveWife";
            this.buttonRemoveWife.Size = new System.Drawing.Size(28, 23);
            this.buttonRemoveWife.TabIndex = 11;
            this.buttonRemoveWife.UseVisualStyleBackColor = true;
            this.buttonRemoveWife.Click += new System.EventHandler(this.buttonRemoveWife_Click);
            // 
            // buttonSelectWife
            // 
            this.buttonSelectWife.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectWife.Image")));
            this.buttonSelectWife.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectWife.Location = new System.Drawing.Point(205, 18);
            this.buttonSelectWife.Name = "buttonSelectWife";
            this.buttonSelectWife.Size = new System.Drawing.Size(26, 23);
            this.buttonSelectWife.TabIndex = 10;
            this.buttonSelectWife.UseVisualStyleBackColor = true;
            this.buttonSelectWife.Click += new System.EventHandler(this.buttonSelectWife_Click);
            // 
            // lblWife
            // 
            this.lblWife.AutoSize = true;
            this.lblWife.Location = new System.Drawing.Point(5, 19);
            this.lblWife.MaximumSize = new System.Drawing.Size(195, 30);
            this.lblWife.Name = "lblWife";
            this.lblWife.Size = new System.Drawing.Size(68, 13);
            this.lblWife.TabIndex = 0;
            this.lblWife.Text = "Select a wife";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRemoveHusband);
            this.groupBox3.Controls.Add(this.buttonAddHusband);
            this.groupBox3.Controls.Add(this.lblHusband);
            this.groupBox3.Location = new System.Drawing.Point(4, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 57);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Husband";
            // 
            // buttonRemoveHusband
            // 
            this.buttonRemoveHusband.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveHusband.Image")));
            this.buttonRemoveHusband.Location = new System.Drawing.Point(231, 18);
            this.buttonRemoveHusband.Name = "buttonRemoveHusband";
            this.buttonRemoveHusband.Size = new System.Drawing.Size(28, 23);
            this.buttonRemoveHusband.TabIndex = 11;
            this.buttonRemoveHusband.UseVisualStyleBackColor = true;
            this.buttonRemoveHusband.Click += new System.EventHandler(this.buttonRemoveHusband_Click);
            // 
            // buttonAddHusband
            // 
            this.buttonAddHusband.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddHusband.Image")));
            this.buttonAddHusband.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddHusband.Location = new System.Drawing.Point(205, 18);
            this.buttonAddHusband.Name = "buttonAddHusband";
            this.buttonAddHusband.Size = new System.Drawing.Size(26, 23);
            this.buttonAddHusband.TabIndex = 10;
            this.buttonAddHusband.UseVisualStyleBackColor = true;
            this.buttonAddHusband.Click += new System.EventHandler(this.buttonAddHusband_Click);
            // 
            // lblHusband
            // 
            this.lblHusband.AutoSize = true;
            this.lblHusband.Location = new System.Drawing.Point(5, 19);
            this.lblHusband.MaximumSize = new System.Drawing.Size(195, 30);
            this.lblHusband.Name = "lblHusband";
            this.lblHusband.Size = new System.Drawing.Size(90, 13);
            this.lblHusband.TabIndex = 0;
            this.lblHusband.Text = "Select a husband";
            // 
            // txtDateDivorsed
            // 
            this.txtDateDivorsed.Location = new System.Drawing.Point(88, 161);
            this.txtDateDivorsed.Name = "txtDateDivorsed";
            this.txtDateDivorsed.Size = new System.Drawing.Size(182, 20);
            this.txtDateDivorsed.TabIndex = 10;
            // 
            // txtPlaceMarried
            // 
            this.txtPlaceMarried.Location = new System.Drawing.Point(88, 134);
            this.txtPlaceMarried.Name = "txtPlaceMarried";
            this.txtPlaceMarried.Size = new System.Drawing.Size(182, 20);
            this.txtPlaceMarried.TabIndex = 9;
            // 
            // txtDateMarried
            // 
            this.txtDateMarried.Location = new System.Drawing.Point(88, 108);
            this.txtDateMarried.Name = "txtDateMarried";
            this.txtDateMarried.Size = new System.Drawing.Size(182, 20);
            this.txtDateMarried.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date Divorsed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Place Married:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Married:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(486, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(405, 270);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveChild);
            this.groupBox2.Controls.Add(this.buttonAddChild);
            this.groupBox2.Controls.Add(this.lstChildren);
            this.groupBox2.Location = new System.Drawing.Point(299, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Children:";
            // 
            // buttonRemoveChild
            // 
            this.buttonRemoveChild.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveChild.Image")));
            this.buttonRemoveChild.Location = new System.Drawing.Point(228, 43);
            this.buttonRemoveChild.Name = "buttonRemoveChild";
            this.buttonRemoveChild.Size = new System.Drawing.Size(28, 23);
            this.buttonRemoveChild.TabIndex = 17;
            this.buttonRemoveChild.UseVisualStyleBackColor = true;
            this.buttonRemoveChild.Click += new System.EventHandler(this.buttonRemoveChild_Click);
            // 
            // buttonAddChild
            // 
            this.buttonAddChild.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddChild.Image")));
            this.buttonAddChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddChild.Location = new System.Drawing.Point(230, 19);
            this.buttonAddChild.Name = "buttonAddChild";
            this.buttonAddChild.Size = new System.Drawing.Size(26, 23);
            this.buttonAddChild.TabIndex = 16;
            this.buttonAddChild.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddChild.UseVisualStyleBackColor = true;
            this.buttonAddChild.Click += new System.EventHandler(this.buttonAddChild_Click);
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Location = new System.Drawing.Point(8, 19);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(216, 121);
            this.lstChildren.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNotes);
            this.groupBox5.Location = new System.Drawing.Point(300, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 96);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(7, 20);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(248, 70);
            this.txtNotes.TabIndex = 0;
            // 
            // formFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 303);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formFamily";
            this.ShowInTaskbar = false;
            this.Text = "Family";
            this.Load += new System.EventHandler(this.formFamily_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateDivorsed;
        private System.Windows.Forms.TextBox txtPlaceMarried;
        private System.Windows.Forms.TextBox txtDateMarried;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRemoveWife;
        private System.Windows.Forms.Button buttonSelectWife;
        private System.Windows.Forms.Label lblWife;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRemoveHusband;
        private System.Windows.Forms.Button buttonAddHusband;
        private System.Windows.Forms.Label lblHusband;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRemoveChild;
        private System.Windows.Forms.Button buttonAddChild;
        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.TextBox txtNotes;
    }
}