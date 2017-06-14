namespace OIS12_Hotel {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweBoekingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOverviewRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewBreakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvOverviewDinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToDeleteRows = false;
            this.dgvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOverviewRoom,
            this.dgvOverviewName,
            this.dgvOverviewStartDate,
            this.dgvOverviewEndDate,
            this.dgvOverviewBreakfast,
            this.dgvOverviewDinner});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverview.Location = new System.Drawing.Point(-4, 90);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.ReadOnly = true;
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverview.Size = new System.Drawing.Size(946, 496);
            this.dgvOverview.TabIndex = 2;
            this.dgvOverview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverview_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grand Hotel D\'n Gaarkeuken";
            // 
            // pnLogo
            // 
            this.pnLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogo.Location = new System.Drawing.Point(831, 32);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(100, 50);
            this.pnLogo.TabIndex = 5;
            this.pnLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogo_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exporterenToolStripMenuItem.Text = "Exporteren";
            this.exporterenToolStripMenuItem.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuweBoekingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // nieuweBoekingToolStripMenuItem
            // 
            this.nieuweBoekingToolStripMenuItem.Name = "nieuweBoekingToolStripMenuItem";
            this.nieuweBoekingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nieuweBoekingToolStripMenuItem.Text = "Nieuwe Boeking";
            this.nieuweBoekingToolStripMenuItem.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // dgvOverviewRoom
            // 
            this.dgvOverviewRoom.FillWeight = 60F;
            this.dgvOverviewRoom.HeaderText = "Kamer";
            this.dgvOverviewRoom.Name = "dgvOverviewRoom";
            this.dgvOverviewRoom.ReadOnly = true;
            this.dgvOverviewRoom.Width = 130;
            // 
            // dgvOverviewName
            // 
            this.dgvOverviewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvOverviewName.HeaderText = "Naam";
            this.dgvOverviewName.Name = "dgvOverviewName";
            this.dgvOverviewName.ReadOnly = true;
            // 
            // dgvOverviewStartDate
            // 
            this.dgvOverviewStartDate.FillWeight = 80F;
            this.dgvOverviewStartDate.HeaderText = "Start Datum";
            this.dgvOverviewStartDate.Name = "dgvOverviewStartDate";
            this.dgvOverviewStartDate.ReadOnly = true;
            // 
            // dgvOverviewEndDate
            // 
            this.dgvOverviewEndDate.FillWeight = 80F;
            this.dgvOverviewEndDate.HeaderText = "Eind Datum";
            this.dgvOverviewEndDate.Name = "dgvOverviewEndDate";
            this.dgvOverviewEndDate.ReadOnly = true;
            // 
            // dgvOverviewBreakfast
            // 
            this.dgvOverviewBreakfast.FillWeight = 40F;
            this.dgvOverviewBreakfast.HeaderText = "Ontbijt";
            this.dgvOverviewBreakfast.Name = "dgvOverviewBreakfast";
            this.dgvOverviewBreakfast.ReadOnly = true;
            this.dgvOverviewBreakfast.Width = 50;
            // 
            // dgvOverviewDinner
            // 
            this.dgvOverviewDinner.FillWeight = 40F;
            this.dgvOverviewDinner.HeaderText = "Diner";
            this.dgvOverviewDinner.Name = "dgvOverviewDinner";
            this.dgvOverviewDinner.ReadOnly = true;
            this.dgvOverviewDinner.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 585);
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.dgvOverview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Grand Hotel D\'n Gaarkeuken";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweBoekingToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewEndDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvOverviewBreakfast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvOverviewDinner;
    }
}

