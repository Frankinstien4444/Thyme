namespace Thyme.Panels
{
    public partial class TablesAndViewsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesAndViewsUI));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpViews = new System.Windows.Forms.GroupBox();
            this.viewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkViews = new System.Windows.Forms.CheckedListBox();
            this.grpTables = new System.Windows.Forms.GroupBox();
            this.pnlTableList = new System.Windows.Forms.TableLayoutPanel();
            this.chkListTables = new System.Windows.Forms.CheckedListBox();
            this.grpFields = new System.Windows.Forms.GroupBox();
            this.chkListFields = new System.Windows.Forms.CheckedListBox();
            this.ctxSelection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBar2 = new Thyme.Controls.Search.SearchBar();
            this.searchBar1 = new Thyme.Controls.Search.SearchBar();
            this.viewSearchBar = new Thyme.Controls.Search.SearchBar();
            this.tableSearchBar = new Thyme.Controls.Search.SearchBar();
            this.mainPanel.SuspendLayout();
            this.grpViews.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.grpTables.SuspendLayout();
            this.pnlTableList.SuspendLayout();
            this.grpFields.SuspendLayout();
            this.ctxSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.mainPanel.Controls.Add(this.grpViews, 0, 1);
            this.mainPanel.Controls.Add(this.grpTables, 0, 0);
            this.mainPanel.Controls.Add(this.grpFields, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(791, 709);
            this.mainPanel.TabIndex = 0;
            // 
            // grpViews
            // 
            this.grpViews.Controls.Add(this.viewPanel);
            this.grpViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpViews.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViews.Location = new System.Drawing.Point(5, 359);
            this.grpViews.Margin = new System.Windows.Forms.Padding(5);
            this.grpViews.Name = "grpViews";
            this.grpViews.Padding = new System.Windows.Forms.Padding(5);
            this.grpViews.Size = new System.Drawing.Size(416, 345);
            this.grpViews.TabIndex = 42;
            this.grpViews.TabStop = false;
            this.grpViews.Text = "Views";
            // 
            // viewPanel
            // 
            this.viewPanel.ColumnCount = 1;
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewPanel.Controls.Add(this.chkViews, 0, 1);
            this.viewPanel.Controls.Add(this.searchBar2, 0, 0);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(5, 23);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowCount = 2;
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewPanel.Size = new System.Drawing.Size(406, 317);
            this.viewPanel.TabIndex = 19;
            // 
            // chkViews
            // 
            this.chkViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkViews.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkViews.FormattingEnabled = true;
            this.chkViews.Location = new System.Drawing.Point(4, 69);
            this.chkViews.Margin = new System.Windows.Forms.Padding(4);
            this.chkViews.Name = "chkViews";
            this.chkViews.Size = new System.Drawing.Size(398, 244);
            this.chkViews.Sorted = true;
            this.chkViews.TabIndex = 18;
            this.chkViews.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListTables_ItemCheck);
            this.chkViews.SelectedIndexChanged += new System.EventHandler(this.chkListTables_SelectedIndexChanged);
            // 
            // grpTables
            // 
            this.grpTables.Controls.Add(this.pnlTableList);
            this.grpTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTables.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTables.Location = new System.Drawing.Point(5, 5);
            this.grpTables.Margin = new System.Windows.Forms.Padding(5);
            this.grpTables.Name = "grpTables";
            this.grpTables.Padding = new System.Windows.Forms.Padding(5);
            this.grpTables.Size = new System.Drawing.Size(416, 344);
            this.grpTables.TabIndex = 41;
            this.grpTables.TabStop = false;
            this.grpTables.Text = "Tables";
            // 
            // pnlTableList
            // 
            this.pnlTableList.ColumnCount = 1;
            this.pnlTableList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTableList.Controls.Add(this.chkListTables, 0, 1);
            this.pnlTableList.Controls.Add(this.searchBar1, 0, 0);
            this.pnlTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableList.Location = new System.Drawing.Point(5, 23);
            this.pnlTableList.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTableList.Name = "pnlTableList";
            this.pnlTableList.RowCount = 2;
            this.pnlTableList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.pnlTableList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTableList.Size = new System.Drawing.Size(406, 316);
            this.pnlTableList.TabIndex = 2;
            // 
            // chkListTables
            // 
            this.chkListTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListTables.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListTables.FormattingEnabled = true;
            this.chkListTables.Location = new System.Drawing.Point(4, 69);
            this.chkListTables.Margin = new System.Windows.Forms.Padding(4);
            this.chkListTables.Name = "chkListTables";
            this.chkListTables.Size = new System.Drawing.Size(398, 243);
            this.chkListTables.Sorted = true;
            this.chkListTables.TabIndex = 1;
            this.chkListTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListTables_ItemCheck);
            this.chkListTables.SelectedIndexChanged += new System.EventHandler(this.chkListTables_SelectedIndexChanged);
            // 
            // grpFields
            // 
            this.grpFields.Controls.Add(this.chkListFields);
            this.grpFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFields.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFields.Location = new System.Drawing.Point(431, 5);
            this.grpFields.Margin = new System.Windows.Forms.Padding(5);
            this.grpFields.Name = "grpFields";
            this.grpFields.Padding = new System.Windows.Forms.Padding(5);
            this.mainPanel.SetRowSpan(this.grpFields, 2);
            this.grpFields.Size = new System.Drawing.Size(355, 699);
            this.grpFields.TabIndex = 43;
            this.grpFields.TabStop = false;
            this.grpFields.Text = "Fields";
            // 
            // chkListFields
            // 
            this.chkListFields.ContextMenuStrip = this.ctxSelection;
            this.chkListFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListFields.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListFields.FormattingEnabled = true;
            this.chkListFields.Location = new System.Drawing.Point(5, 23);
            this.chkListFields.Margin = new System.Windows.Forms.Padding(4);
            this.chkListFields.Name = "chkListFields";
            this.chkListFields.Size = new System.Drawing.Size(345, 671);
            this.chkListFields.Sorted = true;
            this.chkListFields.TabIndex = 0;
            this.chkListFields.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListFields_ItemCheck);
            // 
            // ctxSelection
            // 
            this.ctxSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.ctxSelection.Name = "ctxSelection";
            this.ctxSelection.Size = new System.Drawing.Size(136, 48);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // searchBar2
            // 
            this.searchBar2.ActOnCellSelection = null;
            this.searchBar2.ActOnSelection = null;
            this.searchBar2.ActOnTreeNodeSelection = null;
            this.searchBar2.AutoSize = true;
            this.searchBar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar2.Location = new System.Drawing.Point(6, 6);
            this.searchBar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.RightLabel = ((System.Drawing.Image)(resources.GetObject("searchBar2.RightLabel")));
            this.searchBar2.SearchableObject = null;
            this.searchBar2.SearchUsingExternalSource = null;
            this.searchBar2.Size = new System.Drawing.Size(394, 53);
            this.searchBar2.TabIndex = 19;
            // 
            // searchBar1
            // 
            this.searchBar1.ActOnCellSelection = null;
            this.searchBar1.ActOnSelection = null;
            this.searchBar1.ActOnTreeNodeSelection = null;
            this.searchBar1.AutoSize = true;
            this.searchBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar1.Location = new System.Drawing.Point(6, 6);
            this.searchBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.RightLabel = ((System.Drawing.Image)(resources.GetObject("searchBar1.RightLabel")));
            this.searchBar1.SearchableObject = null;
            this.searchBar1.SearchUsingExternalSource = null;
            this.searchBar1.Size = new System.Drawing.Size(394, 53);
            this.searchBar1.TabIndex = 2;
            // 
            // viewSearchBar
            // 
            this.viewSearchBar.ActOnCellSelection = null;
            this.viewSearchBar.ActOnSelection = null;
            this.viewSearchBar.ActOnTreeNodeSelection = null;
            this.viewSearchBar.AutoSize = true;
            this.viewSearchBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSearchBar.Location = new System.Drawing.Point(32759, 7199);
            this.viewSearchBar.Margin = new System.Windows.Forms.Padding(47202, 7199, 47202, 7199);
            this.viewSearchBar.Name = "viewSearchBar";
            this.viewSearchBar.RightLabel = ((System.Drawing.Image)(resources.GetObject("viewSearchBar.RightLabel")));
            this.viewSearchBar.SearchableObject = null;
            this.viewSearchBar.SearchUsingExternalSource = null;
            this.viewSearchBar.Size = new System.Drawing.Size(1, 1);
            this.viewSearchBar.TabIndex = 19;
            // 
            // tableSearchBar
            // 
            this.tableSearchBar.ActOnCellSelection = null;
            this.tableSearchBar.ActOnSelection = null;
            this.tableSearchBar.ActOnTreeNodeSelection = null;
            this.tableSearchBar.AutoSize = true;
            this.tableSearchBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableSearchBar.Location = new System.Drawing.Point(32759, 7199);
            this.tableSearchBar.Margin = new System.Windows.Forms.Padding(47202, 7199, 47202, 7199);
            this.tableSearchBar.Name = "tableSearchBar";
            this.tableSearchBar.RightLabel = ((System.Drawing.Image)(resources.GetObject("tableSearchBar.RightLabel")));
            this.tableSearchBar.SearchableObject = null;
            this.tableSearchBar.SearchUsingExternalSource = null;
            this.tableSearchBar.Size = new System.Drawing.Size(398, 57);
            this.tableSearchBar.TabIndex = 2;
            // 
            // TablesAndViewsUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(791, 709);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TablesAndViewsUI";
            this.Text = "Tables and Views";
            this.DockStateChanged += new System.EventHandler(this.TablesAndViewsUI_DockStateChanged);
            this.DockChanged += new System.EventHandler(this.TablesAndViewsUI_DockChanged);
            this.mainPanel.ResumeLayout(false);
            this.grpViews.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.grpTables.ResumeLayout(false);
            this.pnlTableList.ResumeLayout(false);
            this.pnlTableList.PerformLayout();
            this.grpFields.ResumeLayout(false);
            this.ctxSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.GroupBox grpTables;
        private System.Windows.Forms.TableLayoutPanel pnlTableList;
        private System.Windows.Forms.CheckedListBox chkListTables;
        private System.Windows.Forms.GroupBox grpViews;
        private System.Windows.Forms.TableLayoutPanel viewPanel;
        private System.Windows.Forms.CheckedListBox chkViews;       
        private System.Windows.Forms.GroupBox grpFields;
        private System.Windows.Forms.CheckedListBox chkListFields;
        private Controls.Search.SearchBar tableSearchBar;
        private Controls.Search.SearchBar viewSearchBar;
        private System.Windows.Forms.ContextMenuStrip ctxSelection;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private Controls.Search.SearchBar searchBar1;
        private Controls.Search.SearchBar searchBar2;
    }
}