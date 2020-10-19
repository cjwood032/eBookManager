namespace eBookManager
{
    partial class ImportBooks
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
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tvFoundBooks = new System.Windows.Forms.TreeView();
            this.VSS = new System.Windows.Forms.GroupBox();
            this.lblStorageSpaceDescription = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.dlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddeBookToStrorageSpace = new System.Windows.Forms.Button();
            this.VSS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(5, 2);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(128, 23);
            this.btnSelectSourceFolder.TabIndex = 0;
            this.btnSelectSourceFolder.Text = "Select source folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // tvFoundBooks
            // 
            this.tvFoundBooks.Location = new System.Drawing.Point(5, 29);
            this.tvFoundBooks.Name = "tvFoundBooks";
            this.tvFoundBooks.Size = new System.Drawing.Size(527, 193);
            this.tvFoundBooks.TabIndex = 1;
            // 
            // VSS
            // 
            this.VSS.Controls.Add(this.lblStorageSpaceDescription);
            this.VSS.Controls.Add(this.lblBookCount);
            this.VSS.Controls.Add(this.btnCancel);
            this.VSS.Controls.Add(this.btnSaveNewStorageSpace);
            this.VSS.Controls.Add(this.textBox1);
            this.VSS.Controls.Add(this.btnAddNewStorageSpace);
            this.VSS.Controls.Add(this.dlVirtualStorageSpaces);
            this.VSS.Location = new System.Drawing.Point(5, 228);
            this.VSS.Name = "VSS";
            this.VSS.Size = new System.Drawing.Size(527, 240);
            this.VSS.TabIndex = 2;
            this.VSS.TabStop = false;
            this.VSS.Text = "Virtual storage spaces";
            // 
            // lblStorageSpaceDescription
            // 
            this.lblStorageSpaceDescription.AutoSize = true;
            this.lblStorageSpaceDescription.Location = new System.Drawing.Point(191, 65);
            this.lblStorageSpaceDescription.Name = "lblStorageSpaceDescription";
            this.lblStorageSpaceDescription.Size = new System.Drawing.Size(147, 15);
            this.lblStorageSpaceDescription.TabIndex = 8;
            this.lblStorageSpaceDescription.Text = "Storage Space Description:";
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Location = new System.Drawing.Point(7, 65);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(80, 15);
            this.lblBookCount.TabIndex = 7;
            this.lblBookCount.Text = "lblBookCount";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveNewStorageSpace
            // 
            this.btnSaveNewStorageSpace.Location = new System.Drawing.Point(339, 22);
            this.btnSaveNewStorageSpace.Name = "btnSaveNewStorageSpace";
            this.btnSaveNewStorageSpace.Size = new System.Drawing.Size(39, 23);
            this.btnSaveNewStorageSpace.TabIndex = 6;
            this.btnSaveNewStorageSpace.Text = "save";
            this.btnSaveNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 5;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(161, 22);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(24, 24);
            this.btnAddNewStorageSpace.TabIndex = 4;
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // dlVirtualStorageSpaces
            // 
            this.dlVirtualStorageSpaces.FormattingEnabled = true;
            this.dlVirtualStorageSpaces.Location = new System.Drawing.Point(7, 22);
            this.dlVirtualStorageSpaces.Name = "dlVirtualStorageSpaces";
            this.dlVirtualStorageSpaces.Size = new System.Drawing.Size(147, 23);
            this.dlVirtualStorageSpaces.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddeBookToStrorageSpace);
            this.groupBox1.Location = new System.Drawing.Point(547, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book details";
            // 
            // btnAddeBookToStrorageSpace
            // 
            this.btnAddeBookToStrorageSpace.Location = new System.Drawing.Point(339, 210);
            this.btnAddeBookToStrorageSpace.Name = "btnAddeBookToStrorageSpace";
            this.btnAddeBookToStrorageSpace.Size = new System.Drawing.Size(21, 24);
            this.btnAddeBookToStrorageSpace.TabIndex = 0;
            this.btnAddeBookToStrorageSpace.Text = "+";
            this.btnAddeBookToStrorageSpace.UseVisualStyleBackColor = true;
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VSS);
            this.Controls.Add(this.tvFoundBooks);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.Load += new System.EventHandler(this.ImportBooks_Load);
            this.VSS.ResumeLayout(false);
            this.VSS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView tvFoundBooks;
        private System.Windows.Forms.GroupBox VSS;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.ComboBox dlVirtualStorageSpaces;
        private System.Windows.Forms.Label lblStorageSpaceDescription;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddeBookToStrorageSpace;
    }
}