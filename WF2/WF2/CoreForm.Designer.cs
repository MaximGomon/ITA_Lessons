namespace WF2
{
    partial class CoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.bikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.openSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.lvBikes = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(661, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // bikeToolStripMenuItem
            // 
            this.bikeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.tsSeparator,
            this.openSavedToolStripMenuItem});
            this.bikeToolStripMenuItem.Name = "bikeToolStripMenuItem";
            this.bikeToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.bikeToolStripMenuItem.Text = "Bike";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // openSavedToolStripMenuItem
            // 
            this.openSavedToolStripMenuItem.Name = "openSavedToolStripMenuItem";
            this.openSavedToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openSavedToolStripMenuItem.Text = "Open saved";
            this.openSavedToolStripMenuItem.Click += new System.EventHandler(this.openSavedToolStripMenuItem_Click);
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scContent.IsSplitterFixed = true;
            this.scContent.Location = new System.Drawing.Point(0, 28);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.lvBikes);
            this.scContent.Size = new System.Drawing.Size(661, 345);
            this.scContent.SplitterDistance = 170;
            this.scContent.TabIndex = 1;
            // 
            // lvBikes
            // 
            this.lvBikes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize});
            this.lvBikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBikes.GridLines = true;
            this.lvBikes.Location = new System.Drawing.Point(0, 0);
            this.lvBikes.MultiSelect = false;
            this.lvBikes.Name = "lvBikes";
            this.lvBikes.Size = new System.Drawing.Size(170, 345);
            this.lvBikes.TabIndex = 0;
            this.lvBikes.UseCompatibleStateImageBehavior = false;
            this.lvBikes.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 373);
            this.Controls.Add(this.scContent);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(679, 420);
            this.Name = "CoreForm";
            this.Text = "Bike form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.coreForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripMenuItem openSavedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.ListView lvBikes;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
    }
}

