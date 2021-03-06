﻿using eBookManager.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static eBookManager.Helper.ExtensionMethods;
using static System.Math;
namespace eBookManager
{
    public partial class ImportBooks : Form
    {
        private string _jsonPath;
        private List<StorageSpace> _spaces;
        private enum _storageSpaceSelection {  New = -9999, NoSelection = -1}
        public ImportBooks()
        {
            InitializeComponent();
            _jsonPath = Path.Combine(Application.StartupPath, "bookData.txt");
        }

        private async void ImportBooks_Load(object sender, EventArgs e)
        {
            _spaces = await _spaces.ReadFromDataStore(_jsonPath);
            PopulateStorageSpacesList();
            if (dlVirtualStorageSpaces.Items.Count == 0)
            {
                dlVirtualStorageSpaces.Items.Add("<create new storage space > ");
            }
            lbleBookCount.Text = "";
        }
        private HashSet<string> AllowedExtensions => new HashSet<string>(StringComparer.InvariantCultureIgnoreCase){ ".doc", ".docx", ".pdf", ".epub", ".lit"};
        private enum Extension {  doc = 0, docx = 1, pdf = 2, epub =3, lit=4}
        public void PopulateBookList (string paramDir, TreeNode paramNode)
        {
            DirectoryInfo dir = new DirectoryInfo(paramDir);
            foreach (DirectoryInfo dirInfo in dir.GetDirectories())
            {
                TreeNode node = new TreeNode(dirInfo.Name);
                node.ImageIndex = 4;
                node.SelectedImageIndex = 5;
                if (paramNode != null)
                    paramNode.Nodes.Add(node);
                else
                    tvFoundBooks.Nodes.Add(node);
                PopulateBookList(dirInfo.FullName, node);
            }
            foreach (FileInfo fleInfo in dir.GetFiles()
                .Where( x=> AllowedExtensions.Contains(x.Extension)).ToList())
            {
                TreeNode node =new TreeNode(fleInfo.Name);
                node.Tag = fleInfo.FullName;
                int iconIndex = Enum.Parse(typeof(Extension),
                    fleInfo.Extension.TrimStart('.'), true).GetHashCode();
                node.ImageIndex = iconIndex;
                if (paramNode != null)
                    paramNode.Nodes.Add(node);
                else
                    tvFoundBooks.Nodes.Add(node);
            }
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select the location of your eBooks and documents";
                DialogResult dlgResult = fbd.ShowDialog();
                if (dlgResult== DialogResult.OK)
                {
                    tvFoundBooks.Nodes.Clear();
                    string path = fbd.SelectedPath;
                    DirectoryInfo di = new DirectoryInfo(path);
                    TreeNode root = new TreeNode(di.Name);
                    root.ImageIndex = 4;
                    root.SelectedImageIndex = 5;
                    tvFoundBooks.Nodes.Add(root);
                    PopulateBookList(di.FullName, root);
                    tvFoundBooks.Sort();
                    root.Expand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateStorageSpacesList()
        {
            List<KeyValuePair<int, string>>  lstSpaces = new List<KeyValuePair<int, string>>();
            BindStorageSpaceList((int)_storageSpaceSelection.NoSelection, "Select Storage Space");
            void BindStorageSpaceList(int key, string value) => lstSpaces.Add(new KeyValuePair<int, string>(key, value));
            if(_spaces is null || _spaces.Count() ==0) //Pattern matching
            {
                BindStorageSpaceList((int)_storageSpaceSelection.New, " <create new> ");
            }
            else
            {
                foreach (var space in _spaces)
                {
                    BindStorageSpaceList(space.ID, space.Name);
                }
            }
            dlVirtualStorageSpaces.DataSource = new BindingSource(lstSpaces, null);
            dlVirtualStorageSpaces.DisplayMember = "Value";
            dlVirtualStorageSpaces.ValueMember = "Key";

        }

        private void dlVirtualStorageSpaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = dlVirtualStorageSpaces.SelectedValue.ToString().ToInt();
            if (selectedValue == (int)_storageSpaceSelection.New)
            {
                txtNewStorageSpaceName.Visible = true;
                lblStorageSpaceDescription.Visible = true;
                txtStorageSpaceDescription.ReadOnly = false;
                btnSaveNewStorageSpace.Visible = true;
                btnCancelNewStorageSpaceSave.Visible = true;
                dlVirtualStorageSpaces.Enabled = false;
                btnAddNewStorageSpace.Enabled = false;
                lbleBookCount.Text = "";
            }
            else if (selectedValue != (int)_storageSpaceSelection.NoSelection)
            {
                int contentCount = (
                    from c in _spaces
                    where c.ID == selectedValue
                    select c).Count();
                if (contentCount> 0)
                {
                    StorageSpace selectedSpace = (
                    from c in _spaces
                    where c.ID == selectedValue
                    select c).First();
                    txtStorageSpaceDescription.Text = selectedSpace.Description;
                    List<Document> eBooks = (selectedSpace.BookList == null) ? new List<Document> { } : selectedSpace.BookList;
                    lbleBookCount.Text = $"Storage Space contains { eBooks.Count()} {(eBooks.Count() == 1 ? "eBook" : "eBooks")}";
                }
            }
            else
            {
                lbleBookCount.Text = " ";
            }
        }

     

        
    }
}
