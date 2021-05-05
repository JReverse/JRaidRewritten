
namespace JRaidRewritten
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SettingstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FriendFloodtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuildJoinertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageFloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guildLeaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMFloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCSpammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callSpammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(429, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingstoolStripMenuItem,
            this.FriendFloodtoolStripMenuItem,
            this.GuildJoinertoolStripMenuItem,
            this.messageFloodToolStripMenuItem,
            this.guildLeaverToolStripMenuItem,
            this.dMFloodToolStripMenuItem,
            this.vCSpammerToolStripMenuItem,
            this.callSpammerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // SettingstoolStripMenuItem
            // 
            this.SettingstoolStripMenuItem.Name = "SettingstoolStripMenuItem";
            this.SettingstoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingstoolStripMenuItem.Text = "Settings";
            this.SettingstoolStripMenuItem.Click += new System.EventHandler(this.SettingstoolStripMenuItem_Click);
            // 
            // FriendFloodtoolStripMenuItem
            // 
            this.FriendFloodtoolStripMenuItem.Name = "FriendFloodtoolStripMenuItem";
            this.FriendFloodtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FriendFloodtoolStripMenuItem.Text = "Friend Flood";
            this.FriendFloodtoolStripMenuItem.Click += new System.EventHandler(this.FriendFloodtoolStripMenuItem_Click);
            // 
            // GuildJoinertoolStripMenuItem
            // 
            this.GuildJoinertoolStripMenuItem.Name = "GuildJoinertoolStripMenuItem";
            this.GuildJoinertoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GuildJoinertoolStripMenuItem.Text = "Guild / Group Joiner";
            this.GuildJoinertoolStripMenuItem.Click += new System.EventHandler(this.GuildJoinertoolStripMenuItem_Click);
            // 
            // messageFloodToolStripMenuItem
            // 
            this.messageFloodToolStripMenuItem.Name = "messageFloodToolStripMenuItem";
            this.messageFloodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageFloodToolStripMenuItem.Text = "Message Flood";
            this.messageFloodToolStripMenuItem.Click += new System.EventHandler(this.messageFloodToolStripMenuItem_Click);
            // 
            // guildLeaverToolStripMenuItem
            // 
            this.guildLeaverToolStripMenuItem.Name = "guildLeaverToolStripMenuItem";
            this.guildLeaverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guildLeaverToolStripMenuItem.Text = "Guild Leaver";
            this.guildLeaverToolStripMenuItem.Click += new System.EventHandler(this.guildLeaverToolStripMenuItem_Click);
            // 
            // dMFloodToolStripMenuItem
            // 
            this.dMFloodToolStripMenuItem.Name = "dMFloodToolStripMenuItem";
            this.dMFloodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dMFloodToolStripMenuItem.Text = "DM Flood";
            this.dMFloodToolStripMenuItem.Click += new System.EventHandler(this.dMFloodToolStripMenuItem_Click);
            // 
            // vCSpammerToolStripMenuItem
            // 
            this.vCSpammerToolStripMenuItem.Name = "vCSpammerToolStripMenuItem";
            this.vCSpammerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vCSpammerToolStripMenuItem.Text = "VC Spammer";
            this.vCSpammerToolStripMenuItem.Click += new System.EventHandler(this.vCSpammerToolStripMenuItem_Click);
            // 
            // callSpammerToolStripMenuItem
            // 
            this.callSpammerToolStripMenuItem.Name = "callSpammerToolStripMenuItem";
            this.callSpammerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.callSpammerToolStripMenuItem.Text = "Call Spammer";
            this.callSpammerToolStripMenuItem.Click += new System.EventHandler(this.callSpammerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Status: Idle";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(0, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(429, 203);
            this.listBox1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 250);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem FriendFloodtoolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem SettingstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuildJoinertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageFloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guildLeaverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMFloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCSpammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callSpammerToolStripMenuItem;
    }
}