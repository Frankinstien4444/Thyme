namespace Thyme.Panels
{
    partial class SQLView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSQLTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSQLTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSQLTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExitSQLEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWDataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuildSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlViewMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.QueryView = new System.Windows.Forms.DataGridView();
            this.SQLStats = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEditor = new System.Windows.Forms.GroupBox();
            this.editBox = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.sqlViewMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLStats)).BeginInit();
            this.grpEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.mnuFormatSQL,
            this.mnuTestSQL,
            this.mnuBuildSQL,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1272, 26);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSQLTextFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveSQLTextToolStripMenuItem,
            this.saveAsSQLTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitWDataTableToolStripMenuItem,
            this.toolStripSeparator3,
            this.mnuExitSQLEdit,
            this.exitWoSaveToolStripMenuItem});
            this.filesToolStripMenuItem.Image = global::Thyme.Properties.Resources.mini_open_folder_full;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filesToolStripMenuItem.Text = "File";
            // 
            // openSQLTextFileToolStripMenuItem
            // 
            this.openSQLTextFileToolStripMenuItem.Name = "openSQLTextFileToolStripMenuItem";
            this.openSQLTextFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openSQLTextFileToolStripMenuItem.Text = "Open SQL Text File";
            this.openSQLTextFileToolStripMenuItem.Click += new System.EventHandler(this.openSQLTextFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // saveSQLTextToolStripMenuItem
            // 
            this.saveSQLTextToolStripMenuItem.Name = "saveSQLTextToolStripMenuItem";
            this.saveSQLTextToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.saveSQLTextToolStripMenuItem.Text = "Save SQL Text ";
            this.saveSQLTextToolStripMenuItem.Click += new System.EventHandler(this.saveSQLTextToolStripMenuItem_Click);
            // 
            // saveAsSQLTextToolStripMenuItem
            // 
            this.saveAsSQLTextToolStripMenuItem.Name = "saveAsSQLTextToolStripMenuItem";
            this.saveAsSQLTextToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.saveAsSQLTextToolStripMenuItem.Text = "Save as SQL Text";
            this.saveAsSQLTextToolStripMenuItem.Click += new System.EventHandler(this.saveAsSQLTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // mnuExitSQLEdit
            // 
            this.mnuExitSQLEdit.Name = "mnuExitSQLEdit";
            this.mnuExitSQLEdit.Size = new System.Drawing.Size(230, 22);
            this.mnuExitSQLEdit.Text = "Exit  copy SQL to clipboard";
            this.mnuExitSQLEdit.Click += new System.EventHandler(this.mnuExitSQLEdit_Click);
            // 
            // exitWDataTableToolStripMenuItem
            // 
            this.exitWDataTableToolStripMenuItem.Name = "exitWDataTableToolStripMenuItem";
            this.exitWDataTableToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.exitWDataTableToolStripMenuItem.Text = "Export Query Results and SQL";
            this.exitWDataTableToolStripMenuItem.Click += new System.EventHandler(this.exitWDataTableToolStripMenuItem_Click);
            // 
            // exitWoSaveToolStripMenuItem
            // 
            this.exitWoSaveToolStripMenuItem.Name = "exitWoSaveToolStripMenuItem";
            this.exitWoSaveToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.exitWoSaveToolStripMenuItem.Text = "Exit";
            this.exitWoSaveToolStripMenuItem.Click += new System.EventHandler(this.exitWoSaveToolStripMenuItem_Click);
            // 
            // mnuFormatSQL
            // 
            this.mnuFormatSQL.Image = global::Thyme.Properties.Resources.alt_parameters_icone_9469_64;
            this.mnuFormatSQL.Name = "mnuFormatSQL";
            this.mnuFormatSQL.Size = new System.Drawing.Size(97, 20);
            this.mnuFormatSQL.Text = "Format SQL";
            this.mnuFormatSQL.Click += new System.EventHandler(this.mnuFormatSQL_Click);
            // 
            // mnuTestSQL
            // 
            this.mnuTestSQL.Image = global::Thyme.Properties.Resources.miniPreview;
            this.mnuTestSQL.Name = "mnuTestSQL";
            this.mnuTestSQL.Size = new System.Drawing.Size(79, 20);
            this.mnuTestSQL.Text = "Test SQL";
            this.mnuTestSQL.Click += new System.EventHandler(this.mnuTestSQL_Click);
            // 
            // mnuBuildSQL
            // 
            this.mnuBuildSQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mnuBuildSQL.Image = global::Thyme.Properties.Resources.NewProject;
            this.mnuBuildSQL.Name = "mnuBuildSQL";
            this.mnuBuildSQL.Size = new System.Drawing.Size(86, 20);
            this.mnuBuildSQL.Text = "Build SQL";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Image = global::Thyme.Properties.Resources.help;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // sqlViewMainPanel
            // 
            this.sqlViewMainPanel.ColumnCount = 2;
            this.sqlViewMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.sqlViewMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.sqlViewMainPanel.Controls.Add(this.QueryView, 0, 1);
            this.sqlViewMainPanel.Controls.Add(this.SQLStats, 1, 0);
            this.sqlViewMainPanel.Controls.Add(this.grpEditor, 0, 0);
            this.sqlViewMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlViewMainPanel.Location = new System.Drawing.Point(0, 26);
            this.sqlViewMainPanel.Name = "sqlViewMainPanel";
            this.sqlViewMainPanel.RowCount = 3;
            this.sqlViewMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.sqlViewMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.sqlViewMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sqlViewMainPanel.Size = new System.Drawing.Size(1272, 513);
            this.sqlViewMainPanel.TabIndex = 39;
            // 
            // QueryView
            // 
            this.QueryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QueryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.QueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlViewMainPanel.SetColumnSpan(this.QueryView, 2);
            this.QueryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryView.Location = new System.Drawing.Point(2, 297);
            this.QueryView.Margin = new System.Windows.Forms.Padding(2);
            this.QueryView.Name = "QueryView";
            this.QueryView.RowHeadersVisible = false;
            this.QueryView.RowTemplate.Height = 24;
            this.QueryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueryView.Size = new System.Drawing.Size(1268, 173);
            this.QueryView.TabIndex = 33;
            // 
            // SQLStats
            // 
            this.SQLStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SQLStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.Alias});
            this.SQLStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SQLStats.Location = new System.Drawing.Point(911, 3);
            this.SQLStats.MultiSelect = false;
            this.SQLStats.Name = "SQLStats";
            this.SQLStats.ReadOnly = true;
            this.SQLStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SQLStats.RowHeadersVisible = false;
            this.SQLStats.RowTemplate.Height = 24;
            this.SQLStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SQLStats.Size = new System.Drawing.Size(358, 289);
            this.SQLStats.TabIndex = 32;
            // 
            // Table
            // 
            this.Table.HeaderText = "Table";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            // 
            // grpEditor
            // 
            this.grpEditor.Controls.Add(this.editBox);
            this.grpEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEditor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditor.Location = new System.Drawing.Point(3, 3);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(902, 289);
            this.grpEditor.TabIndex = 0;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "Editor";
            // 
            // editBox
            // 
            this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBox.Location = new System.Drawing.Point(3, 21);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(896, 265);
            this.editBox.TabIndex = 0;
            this.editBox.Text = "";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // SQLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 539);
            this.Controls.Add(this.sqlViewMainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLView";
            this.Text = "SQLView";
            this.Load += new System.EventHandler(this.SQLView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sqlViewMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLStats)).EndInit();
            this.grpEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSQLTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSQLTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsSQLTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitSQLEdit;
        private System.Windows.Forms.ToolStripMenuItem exitWoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatSQL;
        private System.Windows.Forms.ToolStripMenuItem mnuTestSQL;
        private System.Windows.Forms.ToolStripMenuItem mnuBuildSQL;
        private System.Windows.Forms.TableLayoutPanel sqlViewMainPanel;
        private System.Windows.Forms.GroupBox grpEditor;
        private System.Windows.Forms.DataGridView SQLStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridView QueryView;
        private System.Windows.Forms.RichTextBox editBox;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWDataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}