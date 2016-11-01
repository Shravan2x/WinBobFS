using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BobFS.NET;

namespace WinBobFS
{
    public partial class MainForm : Form
    {
        private RawImageSource _rawImageSource;
        private BobFs _bobFs;
        private BobFsNode _curDirectory;
        private TreeNode _rootNode;
        private int _currentDirTotalSize;

        public MainForm()
        {
            InitializeComponent();

            if (CreateGraphics().DpiX < 120)
            {
                ExplorerTree.ImageList = ExplorerTreeImages16;
                OpenButton.ImageList = ControlImages16;
                SaveButton.ImageList = ControlImages16;
                NewFileButton.ImageList = ControlImages16;
                NewDirectoryButton.ImageList = ControlImages16;
                NewLinkButton.ImageList = ControlImages16;
                DeleteButton.ImageList = ControlImages16;
                InfoButton.ImageList = ControlImages16;
            }
        }

        private void OpenMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenImg();
        }

        private void OpenImg()
        {
            OpenFileDialog imgOpenDialog = new OpenFileDialog();
            imgOpenDialog.Filter = "Image files (*.img)|*.img";
            imgOpenDialog.FilterIndex = 0;
            imgOpenDialog.CheckFileExists = true;
            imgOpenDialog.Multiselect = false;

            if (imgOpenDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                _rawImageSource = new RawImageSource(imgOpenDialog.FileName);
                _bobFs = BobFs.Mount(_rawImageSource);
                Text = $"WinBobFS - {imgOpenDialog.SafeFileName}";
            }
            catch (Exception)
            {
                MessageBox.Show(this, "BobFS image is not valid.", "WinBobFS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PopulateExplorerTree();
            PopulateExplorerList(_bobFs.Root);

            NewFileButton.Enabled = true;
            NewDirectoryButton.Enabled = true;
            //NewLinkButton.Enabled = true;
            //InfoButton.Enabled = true;
            ExplorerList.AllowDrop = true;
        }

        private void SaveImg()
        {
            SaveFileDialog imgSaveDialog = new SaveFileDialog();
            imgSaveDialog.Filter = "Image files (*.img)|*.img";
            imgSaveDialog.FilterIndex = 0;
            imgSaveDialog.CheckFileExists = false;

            if (imgSaveDialog.ShowDialog(this) == DialogResult.OK)
                _rawImageSource.Save(imgSaveDialog.FileName);
        }

        private void PopulateExplorerTree()
        {
            ExplorerTree.Nodes.Clear();

            AddressBox.Text = "/";
            _rootNode = ExplorerTree.Nodes.Add("root", "/ <root>", 0);
            _rootNode.Tag = new KeyValuePair<string, BobFsNode>("root", _bobFs.Root);
            AddAllDirectoriesToTree(_rootNode, _bobFs.Root);
            ExplorerTree.ExpandAll();
        }

        private static void AddAllDirectoriesToTree(TreeNode parent, BobFsNode node)
        {
            foreach (KeyValuePair<string, BobFsNode> childNode in node.Contents)
            {
                if (!childNode.Value.IsDirectory)
                    continue;

                TreeNode currentNode = new TreeNode(childNode.Key, 0, 0);
                currentNode.Tag = childNode;
                parent.Nodes.Add(currentNode);

                AddAllDirectoriesToTree(currentNode, childNode.Value);
            }
        }

        private void ExplorerTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            AddressBox.Text = e.Node != _rootNode ? e.Node.FullPath.Substring(_rootNode.Text.Length) : "/";
            PopulateExplorerList(((KeyValuePair<string, BobFsNode>) e.Node.Tag).Value);
        }

        private void PopulateExplorerList(BobFsNode directory)
        {
            _curDirectory = directory;

            _currentDirTotalSize = 0;
            ExplorerList.Items.Clear();
            foreach (KeyValuePair<string, BobFsNode> childNode in directory.Contents)
            {
                ListViewItem currentItem = new ListViewItem(new string[] {childNode.Key, childNode.Value.Size.ToString(), childNode.Value.NumLinks.ToString()}, (int) childNode.Value.Type - 1);
                currentItem.Tag = childNode;
                ExplorerList.Items.Add(currentItem);

                _currentDirTotalSize += (int) childNode.Value.Size;
            }

            RecalculateStatus();
        }

        private void ExplorerList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            
            string tempRoot = Path.Combine(Path.GetTempPath(), "winbobfs\\");
            if (!File.Exists(tempRoot))
                Directory.CreateDirectory(tempRoot);
            
            List<string> tempPaths = new List<string>();
            foreach (ListViewItem currentItem in ExplorerList.SelectedItems)
            {
                KeyValuePair<string, BobFsNode> currentNodeInfo = (KeyValuePair<string, BobFsNode>) currentItem.Tag;
                string tempFile = Path.Combine(tempRoot, currentNodeInfo.Key);
                byte[] tempBytes = new byte[currentNodeInfo.Value.Size];
                currentNodeInfo.Value.ReadAll(0, tempBytes, 0, (int) currentNodeInfo.Value.Size);
                File.WriteAllBytes(tempFile, tempBytes);

                tempPaths.Add(tempFile);
            }

            DataObject data = new DataObject(DataFormats.FileDrop, tempPaths.ToArray());
            DoDragDrop(data, DragDropEffects.Copy);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            _rawImageSource.Save();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveImg();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExplorerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InfoButton.Enabled = (ExplorerList.SelectedItems.Count > 0);
            RecalculateStatus();
        }

        private void RecalculateStatus()
        {
            int selectedTotalSize = ExplorerList.SelectedItems.Cast<ListViewItem>().Sum(currentItem => (int) ((KeyValuePair<string, BobFsNode>) currentItem.Tag).Value.Size);
            StatusLabel.Text = $"{selectedTotalSize} B of {_currentDirTotalSize} B in {ExplorerList.SelectedItems.Count} of {ExplorerList.Items.Count}";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenImg();
            ActiveControl = null;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            string body = "Nodes: 1\n" +
                          "I-number: 3\n" +
                          "Type: 1 (Directory)\n" +
                          "Total size: 6072 B\n" +
                          "Size on disk: 7000 B\n" +
                          "Num links: 3\n" +
                          "Direct block: 131\n" +
                          "Indirect block: 132";

            string title = $"About {ExplorerList.SelectedItems.Count} node" + (ExplorerList.SelectedItems.Count > 1 ? "s" : "");
            MessageBox.Show(this, body, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActiveControl = null;
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            string newFileName = InputBox.Show("File name:");
            if (newFileName == null)
                return;

            _curDirectory.NewFile(newFileName);
            _curDirectory.Commit();
            PopulateExplorerList(_curDirectory);

            ActiveControl = null;
        }

        private void NewDirectoryButton_Click(object sender, EventArgs e)
        {
            string newDirName = InputBox.Show("Directory name:");
            if (newDirName == null)
                return;

            _curDirectory.NewDirectory(newDirName);
            _curDirectory.Commit();
            PopulateExplorerList(_curDirectory);

            PopulateExplorerTree();

            ActiveControl = null;
        }

        private void NewLinkButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void ExplorerList_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (string filePath in filePaths)
                AddContents(_curDirectory, filePath);
            _curDirectory.Commit();

            PopulateExplorerList(_curDirectory);
            PopulateExplorerTree();
        }

        // Requires caller to commit changes to parent
        private void AddContents(BobFsNode parent, string path)
        {
            if (File.Exists(path))
            {
                BobFsNode newFile = parent.NewFile(Path.GetFileName(path));
                byte[] fileContents = File.ReadAllBytes(path);
                newFile.WriteAll(0, fileContents, 0, fileContents.Length);
                newFile.Commit();
            }
            else if (Directory.Exists(path))
            {
                BobFsNode newDir = parent.NewDirectory(Path.GetFileName(path));
                foreach (string dirEntry in Directory.EnumerateFileSystemEntries(path))
                    AddContents(newDir, dirEntry);
                newDir.Commit();
            }
        }

        private void ExplorerList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveImg();


            ActiveControl = null;
        }
    }
}
