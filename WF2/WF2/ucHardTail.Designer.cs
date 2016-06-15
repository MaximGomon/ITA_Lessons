namespace WF2
{
    partial class UcHardTail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSIze = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(90, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbSIze
            // 
            this.tbSIze.Location = new System.Drawing.Point(90, 80);
            this.tbSIze.Name = "tbSIze";
            this.tbSIze.Size = new System.Drawing.Size(100, 22);
            this.tbSIze.TabIndex = 11;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(36, 80);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(35, 17);
            this.lbSize.TabIndex = 10;
            this.lbSize.Text = "Size";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lbName);
            this.gbMain.Controls.Add(this.tbSIze);
            this.gbMain.Controls.Add(this.tbName);
            this.gbMain.Controls.Add(this.lbSize);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(226, 150);
            this.gbMain.TabIndex = 12;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "HardTail";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(36, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name";
            // 
            // UcHardTail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMain);
            this.Name = "UcHardTail";
            this.Size = new System.Drawing.Size(226, 150);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSIze;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbName;
    }
}
