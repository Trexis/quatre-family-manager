namespace Quatre
{
    partial class htmlExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(htmlExportForm));
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.txtExportFolderLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioComplete = new System.Windows.Forms.RadioButton();
            this.radioIndex = new System.Windows.Forms.RadioButton();
            this.radioGenerations = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(157, 206);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.txtExportFolderLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioComplete);
            this.groupBox1.Controls.Add(this.radioIndex);
            this.groupBox1.Controls.Add(this.radioGenerations);
            this.groupBox1.Location = new System.Drawing.Point(8, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
            this.buttonBrowse.Location = new System.Drawing.Point(270, 34);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(29, 23);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // txtExportFolderLocation
            // 
            this.txtExportFolderLocation.Location = new System.Drawing.Point(6, 36);
            this.txtExportFolderLocation.Name = "txtExportFolderLocation";
            this.txtExportFolderLocation.Size = new System.Drawing.Size(258, 20);
            this.txtExportFolderLocation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Export folder location:";
            // 
            // radioComplete
            // 
            this.radioComplete.AutoSize = true;
            this.radioComplete.Checked = true;
            this.radioComplete.Location = new System.Drawing.Point(10, 66);
            this.radioComplete.Name = "radioComplete";
            this.radioComplete.Size = new System.Drawing.Size(102, 17);
            this.radioComplete.TabIndex = 4;
            this.radioComplete.TabStop = true;
            this.radioComplete.Text = "Export Complete";
            this.radioComplete.UseVisualStyleBackColor = true;
            // 
            // radioIndex
            // 
            this.radioIndex.AutoSize = true;
            this.radioIndex.Location = new System.Drawing.Point(10, 89);
            this.radioIndex.Name = "radioIndex";
            this.radioIndex.Size = new System.Drawing.Size(84, 17);
            this.radioIndex.TabIndex = 3;
            this.radioIndex.TabStop = true;
            this.radioIndex.Text = "Export Index";
            this.radioIndex.UseVisualStyleBackColor = true;
            // 
            // radioGenerations
            // 
            this.radioGenerations.AutoSize = true;
            this.radioGenerations.Location = new System.Drawing.Point(10, 112);
            this.radioGenerations.Name = "radioGenerations";
            this.radioGenerations.Size = new System.Drawing.Size(115, 17);
            this.radioGenerations.TabIndex = 2;
            this.radioGenerations.Text = "Export Generations";
            this.radioGenerations.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 206);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "This export utility will create a export of the individuals and families in HTML " +
    "format.  These exported HTML files can then be used to publish the information o" +
    "nline.";
            // 
            // htmlExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 233);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "htmlExportForm";
            this.ShowInTaskbar = false;
            this.Text = "HTML Export";
            this.Load += new System.EventHandler(this.htmlExportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox txtExportFolderLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioComplete;
        private System.Windows.Forms.RadioButton radioIndex;
        private System.Windows.Forms.RadioButton radioGenerations;
        private System.Windows.Forms.Label label2;
    }
}