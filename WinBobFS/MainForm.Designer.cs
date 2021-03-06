﻿namespace WinBobFS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CompactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExplorerTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.ExplorerTree = new System.Windows.Forms.TreeView();
            this.ExplorerTreeImages = new System.Windows.Forms.ImageList(this.components);
            this.ExplorerList = new System.Windows.Forms.ListView();
            this.ExplorerListNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExplorerListSizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExplorerListLinksColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewButton = new System.Windows.Forms.Button();
            this.ControlImages = new System.Windows.Forms.ImageList(this.components);
            this.OpenButton = new System.Windows.Forms.Button();
            this.CompactButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Separator1 = new System.Windows.Forms.Label();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.NewDirectoryButton = new System.Windows.Forms.Button();
            this.NewLinkButton = new System.Windows.Forms.Button();
            this.Separator2 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.Separator3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Separator4 = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ControlImages16 = new System.Windows.Forms.ImageList(this.components);
            this.ExplorerTreeImages16 = new System.Windows.Forms.ImageList(this.components);
            this.CompactToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewDirectoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ImportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RenameButton = new System.Windows.Forms.Button();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.ExplorerTable.SuspendLayout();
            this.AddressPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 564);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(878, 30);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 25);
            this.StatusLabel.Text = "Ready";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(878, 33);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.FileMenuSeparator1,
            this.CompactMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.FileMenuSeparator2,
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(50, 29);
            this.FileMenu.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(171, 30);
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(171, 30);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // FileMenuSeparator1
            // 
            this.FileMenuSeparator1.Name = "FileMenuSeparator1";
            this.FileMenuSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // CompactMenuItem
            // 
            this.CompactMenuItem.Name = "CompactMenuItem";
            this.CompactMenuItem.Size = new System.Drawing.Size(171, 30);
            this.CompactMenuItem.Text = "Compact";
            this.CompactMenuItem.Click += new System.EventHandler(this.CompactMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(171, 30);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(171, 30);
            this.SaveAsMenuItem.Text = "Save As...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // FileMenuSeparator2
            // 
            this.FileMenuSeparator2.Name = "FileMenuSeparator2";
            this.FileMenuSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(171, 30);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(61, 29);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(147, 30);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // ExplorerTable
            // 
            this.ExplorerTable.ColumnCount = 2;
            this.ExplorerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ExplorerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ExplorerTable.Controls.Add(this.AddressPanel, 0, 1);
            this.ExplorerTable.Controls.Add(this.ExplorerTree, 0, 2);
            this.ExplorerTable.Controls.Add(this.ExplorerList, 1, 2);
            this.ExplorerTable.Controls.Add(this.ControlsPanel, 0, 0);
            this.ExplorerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerTable.Location = new System.Drawing.Point(0, 33);
            this.ExplorerTable.Name = "ExplorerTable";
            this.ExplorerTable.RowCount = 3;
            this.ExplorerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ExplorerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ExplorerTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExplorerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ExplorerTable.Size = new System.Drawing.Size(878, 531);
            this.ExplorerTable.TabIndex = 2;
            // 
            // AddressPanel
            // 
            this.ExplorerTable.SetColumnSpan(this.AddressPanel, 2);
            this.AddressPanel.Controls.Add(this.AddressLabel);
            this.AddressPanel.Controls.Add(this.AddressBox);
            this.AddressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressPanel.Location = new System.Drawing.Point(3, 53);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(872, 34);
            this.AddressPanel.TabIndex = 2;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(9, 8);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 20);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address";
            // 
            // AddressBox
            // 
            this.AddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBox.Location = new System.Drawing.Point(83, 4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ReadOnly = true;
            this.AddressBox.Size = new System.Drawing.Size(780, 26);
            this.AddressBox.TabIndex = 3;
            // 
            // ExplorerTree
            // 
            this.ExplorerTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerTree.HideSelection = false;
            this.ExplorerTree.ImageIndex = 0;
            this.ExplorerTree.ImageList = this.ExplorerTreeImages;
            this.ExplorerTree.ItemHeight = 24;
            this.ExplorerTree.Location = new System.Drawing.Point(3, 93);
            this.ExplorerTree.Name = "ExplorerTree";
            this.ExplorerTree.PathSeparator = "/";
            this.ExplorerTree.SelectedImageIndex = 0;
            this.ExplorerTree.Size = new System.Drawing.Size(257, 435);
            this.ExplorerTree.TabIndex = 1;
            this.ExplorerTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ExplorerTree_NodeMouseClick);
            // 
            // ExplorerTreeImages
            // 
            this.ExplorerTreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ExplorerTreeImages.ImageStream")));
            this.ExplorerTreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ExplorerTreeImages.Images.SetKeyName(0, "directory.png");
            this.ExplorerTreeImages.Images.SetKeyName(1, "file.png");
            // 
            // ExplorerList
            // 
            this.ExplorerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExplorerListNameColumnHeader,
            this.ExplorerListSizeColumnHeader,
            this.ExplorerListLinksColumnHeader});
            this.ExplorerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerList.GridLines = true;
            this.ExplorerList.Location = new System.Drawing.Point(266, 93);
            this.ExplorerList.Name = "ExplorerList";
            this.ExplorerList.Size = new System.Drawing.Size(609, 435);
            this.ExplorerList.SmallImageList = this.ExplorerTreeImages;
            this.ExplorerList.TabIndex = 0;
            this.ExplorerList.UseCompatibleStateImageBehavior = false;
            this.ExplorerList.View = System.Windows.Forms.View.Details;
            this.ExplorerList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ExplorerList_ItemDrag);
            this.ExplorerList.SelectedIndexChanged += new System.EventHandler(this.ExplorerList_SelectedIndexChanged);
            this.ExplorerList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExplorerList_DragDrop);
            this.ExplorerList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExplorerList_DragEnter);
            // 
            // ExplorerListNameColumnHeader
            // 
            this.ExplorerListNameColumnHeader.Text = "Name";
            this.ExplorerListNameColumnHeader.Width = 400;
            // 
            // ExplorerListSizeColumnHeader
            // 
            this.ExplorerListSizeColumnHeader.Text = "Size";
            this.ExplorerListSizeColumnHeader.Width = 100;
            // 
            // ExplorerListLinksColumnHeader
            // 
            this.ExplorerListLinksColumnHeader.Text = "Links";
            this.ExplorerListLinksColumnHeader.Width = 100;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExplorerTable.SetColumnSpan(this.ControlsPanel, 2);
            this.ControlsPanel.Controls.Add(this.NewButton);
            this.ControlsPanel.Controls.Add(this.OpenButton);
            this.ControlsPanel.Controls.Add(this.CompactButton);
            this.ControlsPanel.Controls.Add(this.SaveButton);
            this.ControlsPanel.Controls.Add(this.Separator1);
            this.ControlsPanel.Controls.Add(this.NewFileButton);
            this.ControlsPanel.Controls.Add(this.NewDirectoryButton);
            this.ControlsPanel.Controls.Add(this.NewLinkButton);
            this.ControlsPanel.Controls.Add(this.Separator2);
            this.ControlsPanel.Controls.Add(this.RenameButton);
            this.ControlsPanel.Controls.Add(this.DeleteButton);
            this.ControlsPanel.Controls.Add(this.Separator3);
            this.ControlsPanel.Controls.Add(this.ImportButton);
            this.ControlsPanel.Controls.Add(this.ExportButton);
            this.ControlsPanel.Controls.Add(this.Separator4);
            this.ControlsPanel.Controls.Add(this.InfoButton);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(872, 44);
            this.ControlsPanel.TabIndex = 3;
            // 
            // NewButton
            // 
            this.NewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewButton.ImageIndex = 0;
            this.NewButton.ImageList = this.ControlImages;
            this.NewButton.Location = new System.Drawing.Point(3, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(36, 36);
            this.NewButton.TabIndex = 14;
            this.NewButton.TabStop = false;
            this.NewToolTip.SetToolTip(this.NewButton, "Create a new BobFS image");
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ControlImages
            // 
            this.ControlImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ControlImages.ImageStream")));
            this.ControlImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ControlImages.Images.SetKeyName(0, "new.png");
            this.ControlImages.Images.SetKeyName(1, "openfile.png");
            this.ControlImages.Images.SetKeyName(2, "compact.png");
            this.ControlImages.Images.SetKeyName(3, "save.png");
            this.ControlImages.Images.SetKeyName(4, "newfile.png");
            this.ControlImages.Images.SetKeyName(5, "newdir.png");
            this.ControlImages.Images.SetKeyName(6, "newlink.png");
            this.ControlImages.Images.SetKeyName(7, "rename.png");
            this.ControlImages.Images.SetKeyName(8, "delete.png");
            this.ControlImages.Images.SetKeyName(9, "import.png");
            this.ControlImages.Images.SetKeyName(10, "export.png");
            this.ControlImages.Images.SetKeyName(11, "info.png");
            // 
            // OpenButton
            // 
            this.OpenButton.ImageIndex = 1;
            this.OpenButton.ImageList = this.ControlImages;
            this.OpenButton.Location = new System.Drawing.Point(45, 3);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(36, 36);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.TabStop = false;
            this.OpenToolTip.SetToolTip(this.OpenButton, "Open a BobFS image");
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CompactButton
            // 
            this.CompactButton.ImageIndex = 2;
            this.CompactButton.ImageList = this.ControlImages;
            this.CompactButton.Location = new System.Drawing.Point(87, 3);
            this.CompactButton.Name = "CompactButton";
            this.CompactButton.Size = new System.Drawing.Size(36, 36);
            this.CompactButton.TabIndex = 9;
            this.CompactButton.TabStop = false;
            this.CompactToolTip.SetToolTip(this.CompactButton, "Remove empty sectors from the current image");
            this.CompactButton.UseVisualStyleBackColor = true;
            this.CompactButton.Click += new System.EventHandler(this.CompactButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ImageIndex = 3;
            this.SaveButton.ImageList = this.ControlImages;
            this.SaveButton.Location = new System.Drawing.Point(129, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(36, 36);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.TabStop = false;
            this.SaveToolTip.SetToolTip(this.SaveButton, "Save a BobFS image");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Separator1
            // 
            this.Separator1.AutoSize = true;
            this.Separator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Separator1.Location = new System.Drawing.Point(176, 9);
            this.Separator1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(2, 22);
            this.Separator1.TabIndex = 5;
            // 
            // NewFileButton
            // 
            this.NewFileButton.Enabled = false;
            this.NewFileButton.ImageIndex = 4;
            this.NewFileButton.ImageList = this.ControlImages;
            this.NewFileButton.Location = new System.Drawing.Point(189, 3);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(36, 36);
            this.NewFileButton.TabIndex = 1;
            this.NewFileButton.TabStop = false;
            this.NewFileToolTip.SetToolTip(this.NewFileButton, "Create a new file");
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // NewDirectoryButton
            // 
            this.NewDirectoryButton.Enabled = false;
            this.NewDirectoryButton.ImageIndex = 5;
            this.NewDirectoryButton.ImageList = this.ControlImages;
            this.NewDirectoryButton.Location = new System.Drawing.Point(231, 3);
            this.NewDirectoryButton.Name = "NewDirectoryButton";
            this.NewDirectoryButton.Size = new System.Drawing.Size(36, 36);
            this.NewDirectoryButton.TabIndex = 2;
            this.NewDirectoryButton.TabStop = false;
            this.NewDirectoryToolTip.SetToolTip(this.NewDirectoryButton, "Create a new directory");
            this.NewDirectoryButton.UseVisualStyleBackColor = true;
            this.NewDirectoryButton.Click += new System.EventHandler(this.NewDirectoryButton_Click);
            // 
            // NewLinkButton
            // 
            this.NewLinkButton.Enabled = false;
            this.NewLinkButton.ImageIndex = 6;
            this.NewLinkButton.ImageList = this.ControlImages;
            this.NewLinkButton.Location = new System.Drawing.Point(273, 3);
            this.NewLinkButton.Name = "NewLinkButton";
            this.NewLinkButton.Size = new System.Drawing.Size(36, 36);
            this.NewLinkButton.TabIndex = 3;
            this.NewLinkButton.TabStop = false;
            this.NewLinkButton.UseVisualStyleBackColor = true;
            this.NewLinkButton.Click += new System.EventHandler(this.NewLinkButton_Click);
            // 
            // Separator2
            // 
            this.Separator2.AutoSize = true;
            this.Separator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Separator2.Location = new System.Drawing.Point(320, 9);
            this.Separator2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(2, 22);
            this.Separator2.TabIndex = 8;
            // 
            // ImportButton
            // 
            this.ImportButton.Enabled = false;
            this.ImportButton.ImageIndex = 9;
            this.ImportButton.ImageList = this.ControlImages;
            this.ImportButton.Location = new System.Drawing.Point(435, 3);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(36, 36);
            this.ImportButton.TabIndex = 11;
            this.ImportButton.TabStop = false;
            this.ImportToolTip.SetToolTip(this.ImportButton, "Import files and directories to this folder");
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.ImageIndex = 10;
            this.ExportButton.ImageList = this.ControlImages;
            this.ExportButton.Location = new System.Drawing.Point(477, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(36, 36);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.TabStop = false;
            this.ExportToolTip.SetToolTip(this.ExportButton, "Export the selected files and directories");
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Separator3
            // 
            this.Separator3.AutoSize = true;
            this.Separator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Separator3.Location = new System.Drawing.Point(422, 9);
            this.Separator3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(2, 22);
            this.Separator3.TabIndex = 13;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.ImageIndex = 8;
            this.DeleteButton.ImageList = this.ControlImages;
            this.DeleteButton.Location = new System.Drawing.Point(375, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Separator4
            // 
            this.Separator4.AutoSize = true;
            this.Separator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Separator4.Location = new System.Drawing.Point(524, 9);
            this.Separator4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(2, 22);
            this.Separator4.TabIndex = 6;
            // 
            // InfoButton
            // 
            this.InfoButton.Enabled = false;
            this.InfoButton.ImageIndex = 11;
            this.InfoButton.ImageList = this.ControlImages;
            this.InfoButton.Location = new System.Drawing.Point(537, 3);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(36, 36);
            this.InfoButton.TabIndex = 7;
            this.InfoButton.TabStop = false;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ControlImages16
            // 
            this.ControlImages16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ControlImages16.ImageStream")));
            this.ControlImages16.TransparentColor = System.Drawing.Color.Transparent;
            this.ControlImages16.Images.SetKeyName(0, "new.png");
            this.ControlImages16.Images.SetKeyName(1, "openfile.png");
            this.ControlImages16.Images.SetKeyName(2, "compact.png");
            this.ControlImages16.Images.SetKeyName(3, "save.png");
            this.ControlImages16.Images.SetKeyName(4, "newfile.png");
            this.ControlImages16.Images.SetKeyName(5, "newdir.png");
            this.ControlImages16.Images.SetKeyName(6, "newlink.png");
            this.ControlImages16.Images.SetKeyName(7, "rename.png");
            this.ControlImages16.Images.SetKeyName(8, "delete.png");
            this.ControlImages16.Images.SetKeyName(9, "import.png");
            this.ControlImages16.Images.SetKeyName(10, "export.png");
            this.ControlImages16.Images.SetKeyName(11, "info.png");
            // 
            // ExplorerTreeImages16
            // 
            this.ExplorerTreeImages16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ExplorerTreeImages16.ImageStream")));
            this.ExplorerTreeImages16.TransparentColor = System.Drawing.Color.Transparent;
            this.ExplorerTreeImages16.Images.SetKeyName(0, "directory.png");
            this.ExplorerTreeImages16.Images.SetKeyName(1, "file.png");
            // 
            // CompactToolTip
            // 
            this.CompactToolTip.ToolTipTitle = "Compress";
            // 
            // OpenToolTip
            // 
            this.OpenToolTip.ToolTipTitle = "Open";
            // 
            // SaveToolTip
            // 
            this.SaveToolTip.ToolTipTitle = "Save";
            // 
            // NewFileToolTip
            // 
            this.NewFileToolTip.ToolTipTitle = "New file";
            // 
            // NewDirectoryToolTip
            // 
            this.NewDirectoryToolTip.ToolTipTitle = "New Directory";
            // 
            // ImportToolTip
            // 
            this.ImportToolTip.ToolTipTitle = "Import";
            // 
            // ExportToolTip
            // 
            this.ExportToolTip.ToolTipTitle = "Export";
            // 
            // NewToolTip
            // 
            this.NewToolTip.ToolTipTitle = "New";
            // 
            // RenameButton
            // 
            this.RenameButton.Enabled = false;
            this.RenameButton.ImageIndex = 7;
            this.RenameButton.ImageList = this.ControlImages;
            this.RenameButton.Location = new System.Drawing.Point(333, 3);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(36, 36);
            this.RenameButton.TabIndex = 15;
            this.RenameButton.TabStop = false;
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 594);
            this.Controls.Add(this.ExplorerTable);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinBobFS";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ExplorerTable.ResumeLayout(false);
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TableLayoutPanel ExplorerTable;
        private System.Windows.Forms.ListView ExplorerList;
        private System.Windows.Forms.TreeView ExplorerTree;
        private System.Windows.Forms.ImageList ExplorerTreeImages;
        private System.Windows.Forms.ColumnHeader ExplorerListNameColumnHeader;
        private System.Windows.Forms.ColumnHeader ExplorerListSizeColumnHeader;
        private System.Windows.Forms.ColumnHeader ExplorerListLinksColumnHeader;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.FlowLayoutPanel ControlsPanel;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ImageList ControlImages;
        private System.Windows.Forms.Label Separator1;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button NewDirectoryButton;
        private System.Windows.Forms.Button NewLinkButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Separator4;
        private System.Windows.Forms.Label Separator2;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button CompactButton;
        private System.Windows.Forms.ImageList ControlImages16;
        private System.Windows.Forms.ImageList ExplorerTreeImages16;
        private System.Windows.Forms.ToolStripMenuItem CompactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator1;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolTip CompactToolTip;
        private System.Windows.Forms.ToolTip OpenToolTip;
        private System.Windows.Forms.ToolTip SaveToolTip;
        private System.Windows.Forms.ToolTip NewFileToolTip;
        private System.Windows.Forms.ToolTip NewDirectoryToolTip;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label Separator3;
        private System.Windows.Forms.ToolTip ImportToolTip;
        private System.Windows.Forms.ToolTip ExportToolTip;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ToolTip NewToolTip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.Button RenameButton;
    }
}

