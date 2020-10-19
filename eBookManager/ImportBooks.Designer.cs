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
            this.txtStorageSpaceDescription = new System.Windows.Forms.TextBox();
            this.lblStorageSpaceDescription = new System.Windows.Forms.Label();
            this.lbleBookCount = new System.Windows.Forms.Label();
            this.btnCancelNewStorageSpaceSave = new System.Windows.Forms.Button();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.txtNewStorageSpaceName = new System.Windows.Forms.TextBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.dlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.lblBookDatePublished = new System.Windows.Forms.Label();
            this.txtBookDatePublished = new System.Windows.Forms.TextBox();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.lblBookCategory = new System.Windows.Forms.Label();
            this.lblBookClassification = new System.Windows.Forms.Label();
            this.txtBookClassification = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnAddeBookToStrorageSpace = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileCreated = new System.Windows.Forms.TextBox();
            this.lblFileCreated = new System.Windows.Forms.Label();
            this.txtFileLastAccessed = new System.Windows.Forms.TextBox();
            this.lblFileLastAccessed = new System.Windows.Forms.Label();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.VSS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tvFoundBooks.Size = new System.Drawing.Size(527, 268);
            this.tvFoundBooks.TabIndex = 1;
            // 
            // VSS
            // 
            this.VSS.Controls.Add(this.txtStorageSpaceDescription);
            this.VSS.Controls.Add(this.lblStorageSpaceDescription);
            this.VSS.Controls.Add(this.lbleBookCount);
            this.VSS.Controls.Add(this.btnCancelNewStorageSpaceSave);
            this.VSS.Controls.Add(this.btnSaveNewStorageSpace);
            this.VSS.Controls.Add(this.txtNewStorageSpaceName);
            this.VSS.Controls.Add(this.btnAddNewStorageSpace);
            this.VSS.Controls.Add(this.dlVirtualStorageSpaces);
            this.VSS.Location = new System.Drawing.Point(5, 309);
            this.VSS.Name = "VSS";
            this.VSS.Size = new System.Drawing.Size(527, 240);
            this.VSS.TabIndex = 2;
            this.VSS.TabStop = false;
            this.VSS.Text = "Virtual storage spaces";
            // 
            // txtStorageSpaceDescription
            // 
            this.txtStorageSpaceDescription.Location = new System.Drawing.Point(191, 84);
            this.txtStorageSpaceDescription.Multiline = true;
            this.txtStorageSpaceDescription.Name = "txtStorageSpaceDescription";
            this.txtStorageSpaceDescription.ReadOnly = true;
            this.txtStorageSpaceDescription.Size = new System.Drawing.Size(320, 105);
            this.txtStorageSpaceDescription.TabIndex = 9;
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
            // lbleBookCount
            // 
            this.lbleBookCount.AutoSize = true;
            this.lbleBookCount.Location = new System.Drawing.Point(7, 65);
            this.lbleBookCount.Name = "lbleBookCount";
            this.lbleBookCount.Size = new System.Drawing.Size(86, 15);
            this.lbleBookCount.TabIndex = 7;
            this.lbleBookCount.Text = "lbleBookCount";
            // 
            // btnCancelNewStorageSpaceSave
            // 
            this.btnCancelNewStorageSpaceSave.Location = new System.Drawing.Point(384, 22);
            this.btnCancelNewStorageSpaceSave.Name = "btnCancelNewStorageSpaceSave";
            this.btnCancelNewStorageSpaceSave.Size = new System.Drawing.Size(52, 23);
            this.btnCancelNewStorageSpaceSave.TabIndex = 6;
            this.btnCancelNewStorageSpaceSave.Text = "cancel";
            this.btnCancelNewStorageSpaceSave.UseVisualStyleBackColor = true;
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
            // txtNewStorageSpaceName
            // 
            this.txtNewStorageSpaceName.Location = new System.Drawing.Point(191, 22);
            this.txtNewStorageSpaceName.Name = "txtNewStorageSpaceName";
            this.txtNewStorageSpaceName.Size = new System.Drawing.Size(142, 23);
            this.txtNewStorageSpaceName.TabIndex = 5;
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
            this.dlVirtualStorageSpaces.SelectedIndexChanged += new System.EventHandler(this.dlVirtualStorageSpaces_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBookIsbn);
            this.groupBox1.Controls.Add(this.lblBookIsbn);
            this.groupBox1.Controls.Add(this.lblBookDatePublished);
            this.groupBox1.Controls.Add(this.txtBookDatePublished);
            this.groupBox1.Controls.Add(this.txtBookCategory);
            this.groupBox1.Controls.Add(this.lblBookCategory);
            this.groupBox1.Controls.Add(this.lblBookClassification);
            this.groupBox1.Controls.Add(this.txtBookClassification);
            this.groupBox1.Controls.Add(this.txtBookPrice);
            this.groupBox1.Controls.Add(this.lblBookPrice);
            this.groupBox1.Controls.Add(this.txtBookPublisher);
            this.groupBox1.Controls.Add(this.lblBookPublisher);
            this.groupBox1.Controls.Add(this.lblBookAuthor);
            this.groupBox1.Controls.Add(this.txtBookAuthor);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.btnAddeBookToStrorageSpace);
            this.groupBox1.Location = new System.Drawing.Point(547, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book details";
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(106, 134);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(292, 23);
            this.txtBookIsbn.TabIndex = 2;
            // 
            // lblBookIsbn
            // 
            this.lblBookIsbn.AutoSize = true;
            this.lblBookIsbn.Location = new System.Drawing.Point(6, 139);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(35, 15);
            this.lblBookIsbn.TabIndex = 1;
            this.lblBookIsbn.Text = "ISBN:";
            // 
            // lblBookDatePublished
            // 
            this.lblBookDatePublished.AutoSize = true;
            this.lblBookDatePublished.Location = new System.Drawing.Point(6, 168);
            this.lblBookDatePublished.Name = "lblBookDatePublished";
            this.lblBookDatePublished.Size = new System.Drawing.Size(89, 15);
            this.lblBookDatePublished.TabIndex = 1;
            this.lblBookDatePublished.Text = "Date published:";
            // 
            // txtBookDatePublished
            // 
            this.txtBookDatePublished.Location = new System.Drawing.Point(106, 162);
            this.txtBookDatePublished.Name = "txtBookDatePublished";
            this.txtBookDatePublished.Size = new System.Drawing.Size(292, 23);
            this.txtBookDatePublished.TabIndex = 2;
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(106, 190);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(292, 23);
            this.txtBookCategory.TabIndex = 2;
            // 
            // lblBookCategory
            // 
            this.lblBookCategory.AutoSize = true;
            this.lblBookCategory.Location = new System.Drawing.Point(6, 195);
            this.lblBookCategory.Name = "lblBookCategory";
            this.lblBookCategory.Size = new System.Drawing.Size(58, 15);
            this.lblBookCategory.TabIndex = 1;
            this.lblBookCategory.Text = "Category:";
            // 
            // lblBookClassification
            // 
            this.lblBookClassification.AutoSize = true;
            this.lblBookClassification.Location = new System.Drawing.Point(6, 224);
            this.lblBookClassification.Name = "lblBookClassification";
            this.lblBookClassification.Size = new System.Drawing.Size(80, 15);
            this.lblBookClassification.TabIndex = 1;
            this.lblBookClassification.Text = "Classification:";
            // 
            // txtBookClassification
            // 
            this.txtBookClassification.Location = new System.Drawing.Point(106, 218);
            this.txtBookClassification.Name = "txtBookClassification";
            this.txtBookClassification.Size = new System.Drawing.Size(292, 23);
            this.txtBookClassification.TabIndex = 2;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(106, 107);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(292, 23);
            this.txtBookPrice.TabIndex = 2;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(6, 113);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(36, 15);
            this.lblBookPrice.TabIndex = 1;
            this.lblBookPrice.Text = "Price:";
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(106, 79);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(292, 23);
            this.txtBookPublisher.TabIndex = 2;
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Location = new System.Drawing.Point(6, 84);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(59, 15);
            this.lblBookPublisher.TabIndex = 1;
            this.lblBookPublisher.Text = "Publisher:";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(6, 57);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblBookAuthor.TabIndex = 1;
            this.lblBookAuthor.Text = "Author:";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(106, 51);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(292, 23);
            this.txtBookAuthor.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(106, 23);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(292, 23);
            this.txtBookTitle.TabIndex = 2;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(6, 28);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(32, 15);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title:";
            // 
            // btnAddeBookToStrorageSpace
            // 
            this.btnAddeBookToStrorageSpace.Location = new System.Drawing.Point(44, 254);
            this.btnAddeBookToStrorageSpace.Name = "btnAddeBookToStrorageSpace";
            this.btnAddeBookToStrorageSpace.Size = new System.Drawing.Size(21, 24);
            this.btnAddeBookToStrorageSpace.TabIndex = 0;
            this.btnAddeBookToStrorageSpace.Text = "+";
            this.btnAddeBookToStrorageSpace.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(106, 134);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(292, 23);
            this.txtFilePath.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.lblFilePath);
            this.groupBox2.Controls.Add(this.lblFileSize);
            this.groupBox2.Controls.Add(this.txtFileSize);
            this.groupBox2.Controls.Add(this.txtFileCreated);
            this.groupBox2.Controls.Add(this.lblFileCreated);
            this.groupBox2.Controls.Add(this.txtFileLastAccessed);
            this.groupBox2.Controls.Add(this.lblFileLastAccessed);
            this.groupBox2.Controls.Add(this.lblFileExtension);
            this.groupBox2.Controls.Add(this.txtFileExtension);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.lblFileName);
            this.groupBox2.Location = new System.Drawing.Point(547, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book details";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 139);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(55, 15);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File path:";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(6, 168);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(30, 15);
            this.lblFileSize.TabIndex = 1;
            this.lblFileSize.Text = "Size:";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(106, 162);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(292, 23);
            this.txtFileSize.TabIndex = 2;
            // 
            // txtFileCreated
            // 
            this.txtFileCreated.Location = new System.Drawing.Point(106, 107);
            this.txtFileCreated.Name = "txtFileCreated";
            this.txtFileCreated.Size = new System.Drawing.Size(292, 23);
            this.txtFileCreated.TabIndex = 2;
            // 
            // lblFileCreated
            // 
            this.lblFileCreated.AutoSize = true;
            this.lblFileCreated.Location = new System.Drawing.Point(6, 113);
            this.lblFileCreated.Name = "lblFileCreated";
            this.lblFileCreated.Size = new System.Drawing.Size(51, 15);
            this.lblFileCreated.TabIndex = 1;
            this.lblFileCreated.Text = "Created:";
            // 
            // txtFileLastAccessed
            // 
            this.txtFileLastAccessed.Location = new System.Drawing.Point(106, 79);
            this.txtFileLastAccessed.Name = "txtFileLastAccessed";
            this.txtFileLastAccessed.Size = new System.Drawing.Size(292, 23);
            this.txtFileLastAccessed.TabIndex = 2;
            // 
            // lblFileLastAccessed
            // 
            this.lblFileLastAccessed.AutoSize = true;
            this.lblFileLastAccessed.Location = new System.Drawing.Point(6, 84);
            this.lblFileLastAccessed.Name = "lblFileLastAccessed";
            this.lblFileLastAccessed.Size = new System.Drawing.Size(81, 15);
            this.lblFileLastAccessed.TabIndex = 1;
            this.lblFileLastAccessed.Text = "Last accessed:";
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(6, 57);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(82, 15);
            this.lblFileExtension.TabIndex = 1;
            this.lblFileExtension.Text = "File extension:";
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Location = new System.Drawing.Point(106, 51);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(292, 23);
            this.txtFileExtension.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(292, 23);
            this.txtFileName.TabIndex = 2;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 28);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 15);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File name:";
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 567);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lbleBookCount;
        private System.Windows.Forms.Button btnCancelNewStorageSpaceSave;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.TextBox txtNewStorageSpaceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddeBookToStrorageSpace;
        private System.Windows.Forms.TextBox txtStorageSpaceDescription;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.Label lblBookDatePublished;
        private System.Windows.Forms.TextBox txtBookDatePublished;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.Label lblBookCategory;
        private System.Windows.Forms.Label lblBookClassification;
        private System.Windows.Forms.TextBox txtBookClassification;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFileCreated;
        private System.Windows.Forms.Label lblFileCreated;
        private System.Windows.Forms.TextBox txtFileLastAccessed;
        private System.Windows.Forms.Label lblFileLastAccessed;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
    }
}