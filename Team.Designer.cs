namespace CISesport
{
    partial class Team
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.Member1,
            this.Member2,
            this.Member3,
            this.Member4,
            this.Member5});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(966, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeamName
            // 
            this.TeamName.HeaderText = "ชื่อทีม";
            this.TeamName.MinimumWidth = 8;
            this.TeamName.Name = "TeamName";
            this.TeamName.Width = 150;
            // 
            // Member1
            // 
            this.Member1.HeaderText = "สมาชิก1";
            this.Member1.MinimumWidth = 8;
            this.Member1.Name = "Member1";
            this.Member1.Width = 150;
            // 
            // Member2
            // 
            this.Member2.HeaderText = "สมาชิก2";
            this.Member2.MinimumWidth = 8;
            this.Member2.Name = "Member2";
            this.Member2.Width = 150;
            // 
            // Member3
            // 
            this.Member3.HeaderText = "สมาชิก3";
            this.Member3.MinimumWidth = 8;
            this.Member3.Name = "Member3";
            this.Member3.Width = 150;
            // 
            // Member4
            // 
            this.Member4.HeaderText = "สมาชิก4";
            this.Member4.MinimumWidth = 8;
            this.Member4.Name = "Member4";
            this.Member4.Width = 150;
            // 
            // Member5
            // 
            this.Member5.HeaderText = "สมาชิก5";
            this.Member5.MinimumWidth = 8;
            this.Member5.Name = "Member5";
            this.Member5.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // newTeamToolStripMenuItem
            // 
            this.newTeamToolStripMenuItem.Name = "newTeamToolStripMenuItem";
            this.newTeamToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newTeamToolStripMenuItem.Text = "New Team";
            this.newTeamToolStripMenuItem.Click += new System.EventHandler(this.newTeamToolStripMenuItem_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Team";
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TeamName;
        private DataGridViewTextBoxColumn Member1;
        private DataGridViewTextBoxColumn Member2;
        private DataGridViewTextBoxColumn Member3;
        private DataGridViewTextBoxColumn Member4;
        private DataGridViewTextBoxColumn Member5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newTeamToolStripMenuItem;
    }
}