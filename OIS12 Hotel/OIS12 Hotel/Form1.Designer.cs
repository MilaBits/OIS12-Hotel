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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvOverviewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOverviewDinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvOverviewBreakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweBoekingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOverviewName,
            this.dgvOverviewRoom,
            this.dgvOverviewDinner,
            this.dgvOverviewBreakfast});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(692, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvOverviewName
            // 
            this.dgvOverviewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvOverviewName.HeaderText = "Naam";
            this.dgvOverviewName.Name = "dgvOverviewName";
            this.dgvOverviewName.ReadOnly = true;
            // 
            // dgvOverviewRoom
            // 
            this.dgvOverviewRoom.HeaderText = "Kamer";
            this.dgvOverviewRoom.Name = "dgvOverviewRoom";
            this.dgvOverviewRoom.ReadOnly = true;
            // 
            // dgvOverviewDinner
            // 
            this.dgvOverviewDinner.HeaderText = "Diner";
            this.dgvOverviewDinner.Name = "dgvOverviewDinner";
            this.dgvOverviewDinner.ReadOnly = true;
            // 
            // dgvOverviewBreakfast
            // 
            this.dgvOverviewBreakfast.HeaderText = "Ontbijt";
            this.dgvOverviewBreakfast.Name = "dgvOverviewBreakfast";
            this.dgvOverviewBreakfast.ReadOnly = true;
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
            this.pnLogo.Location = new System.Drawing.Point(575, 32);
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
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
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
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Grand Hotel D\'n Gaarkeuken";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOverviewRoom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvOverviewDinner;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvOverviewBreakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweBoekingToolStripMenuItem;
    }
}

