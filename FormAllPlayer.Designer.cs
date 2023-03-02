namespace CISesport
{
    partial class FormAllPlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Displayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlayerToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openPlayerToolStripMenuItem
            // 
            this.openPlayerToolStripMenuItem.Name = "openPlayerToolStripMenuItem";
            this.openPlayerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openPlayerToolStripMenuItem.Text = "Open";
            this.openPlayerToolStripMenuItem.Click += new System.EventHandler(this.openPlayerToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem1});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem1
            // 
            this.newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            this.newPlayerToolStripMenuItem1.Size = new System.Drawing.Size(196, 34);
            this.newPlayerToolStripMenuItem1.Text = "NewPlayer";
            this.newPlayerToolStripMenuItem1.Click += new System.EventHandler(this.newPlayerToolStripMenuItem1_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Lastname,
            this.Studentid,
            this.Major,
            this.Displayname,
            this.Mail,
            this.Phone,
            this.Age});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "ชื่อ";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "นามสกุล";
            this.Lastname.MinimumWidth = 8;
            this.Lastname.Name = "Lastname";
            this.Lastname.Width = 150;
            // 
            // Studentid
            // 
            this.Studentid.HeaderText = "รหัสนักศึกษา";
            this.Studentid.MinimumWidth = 8;
            this.Studentid.Name = "Studentid";
            this.Studentid.Width = 150;
            // 
            // Major
            // 
            this.Major.HeaderText = "สาขา";
            this.Major.MinimumWidth = 8;
            this.Major.Name = "Major";
            this.Major.Width = 150;
            // 
            // Displayname
            // 
            this.Displayname.HeaderText = "ชื่อในเกม";
            this.Displayname.MinimumWidth = 8;
            this.Displayname.Name = "Displayname";
            this.Displayname.Width = 150;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "เมล";
            this.Mail.MinimumWidth = 8;
            this.Mail.Name = "Mail";
            this.Mail.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "เบอร์โทรศัพท์";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "อายุ";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // FormAllPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "FormAllPlayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openPlayerToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Studentid;
        private DataGridViewTextBoxColumn Major;
        private DataGridViewTextBoxColumn Displayname;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Age;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem managerToolStripMenuItem;
    }
}