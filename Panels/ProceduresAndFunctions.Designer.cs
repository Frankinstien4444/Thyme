namespace Thyme.Panels
{
    partial class ProceduresAndFunctions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProceduresAndFunctions));
            this.grpProcedures = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboProcedures = new System.Windows.Forms.ComboBox();
            this.dgrdParams = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPlaceToEditWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProcedures.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdParams)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcedures
            // 
            this.grpProcedures.Controls.Add(this.tableLayoutPanel3);
            this.grpProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProcedures.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProcedures.Location = new System.Drawing.Point(0, 24);
            this.grpProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.grpProcedures.Name = "grpProcedures";
            this.grpProcedures.Padding = new System.Windows.Forms.Padding(4);
            this.grpProcedures.Size = new System.Drawing.Size(683, 475);
            this.grpProcedures.TabIndex = 39;
            this.grpProcedures.TabStop = false;
            this.grpProcedures.Text = "Stored Procedures";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cboProcedures, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgrdParams, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.251563F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.74844F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(675, 449);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // cboProcedures
            // 
            this.cboProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProcedures.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcedures.FormattingEnabled = true;
            this.cboProcedures.Location = new System.Drawing.Point(3, 3);
            this.cboProcedures.Name = "cboProcedures";
            this.cboProcedures.Size = new System.Drawing.Size(669, 25);
            this.cboProcedures.TabIndex = 14;
            this.cboProcedures.SelectedIndexChanged += new System.EventHandler(this.cboProcs_SelectedIndexChanged);
            // 
            // dgrdParams
            // 
            this.dgrdParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdParams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrdParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdParams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrdParams.EnableHeadersVisualStyles = false;
            this.dgrdParams.Location = new System.Drawing.Point(3, 31);
            this.dgrdParams.Name = "dgrdParams";
            this.dgrdParams.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrdParams.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdParams.RowTemplate.Height = 24;
            this.dgrdParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdParams.Size = new System.Drawing.Size(669, 415);
            this.dgrdParams.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlaceToEditWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPlaceToEditWindow
            // 
            this.mnuPlaceToEditWindow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuPlaceToEditWindow.Name = "mnuPlaceToEditWindow";
            this.mnuPlaceToEditWindow.Size = new System.Drawing.Size(128, 20);
            this.mnuPlaceToEditWindow.Text = "Place in edit window";
            this.mnuPlaceToEditWindow.Click += new System.EventHandler(this.mnuPlaceToEditWindow_Click);
            // 
            // ProceduresAndFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 499);
            this.Controls.Add(this.grpProcedures);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProceduresAndFunctions";
            this.Text = "Stored Procedures And Functions";
            this.grpProcedures.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdParams)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcedures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cboProcedures;
        private System.Windows.Forms.DataGridView dgrdParams;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPlaceToEditWindow;
    }
}