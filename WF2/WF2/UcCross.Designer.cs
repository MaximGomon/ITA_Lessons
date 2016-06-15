namespace WF2
{
    partial class UcCross
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
            this.lbWheel = new System.Windows.Forms.Label();
            this.tbWheel = new System.Windows.Forms.TextBox();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWheel
            // 
            this.lbWheel.AutoSize = true;
            this.lbWheel.Location = new System.Drawing.Point(34, 38);
            this.lbWheel.Name = "lbWheel";
            this.lbWheel.Size = new System.Drawing.Size(48, 17);
            this.lbWheel.TabIndex = 0;
            this.lbWheel.Text = "Wheel";
            // 
            // tbWheel
            // 
            this.tbWheel.Location = new System.Drawing.Point(88, 38);
            this.tbWheel.Name = "tbWheel";
            this.tbWheel.Size = new System.Drawing.Size(100, 22);
            this.tbWheel.TabIndex = 1;
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(130, 75);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(58, 22);
            this.tbSpeedCount.TabIndex = 3;
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Location = new System.Drawing.Point(34, 78);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(90, 17);
            this.lbSpeedCount.TabIndex = 2;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(34, 117);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(41, 17);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(81, 114);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(107, 24);
            this.cbColor.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 144);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 7;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(34, 144);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // UcCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.lbSpeedCount);
            this.Controls.Add(this.tbWheel);
            this.Controls.Add(this.lbWheel);
            this.Name = "UcCross";
            this.Size = new System.Drawing.Size(288, 209);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWheel;
        private System.Windows.Forms.TextBox tbWheel;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}
