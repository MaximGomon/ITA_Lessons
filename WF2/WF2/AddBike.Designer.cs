namespace WF2
{
    partial class AddBike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBike));
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.lbBikeType = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(270, 246);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(351, 246);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Location = new System.Drawing.Point(59, 16);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(121, 24);
            this.cbBikeType.TabIndex = 2;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // lbBikeType
            // 
            this.lbBikeType.AutoSize = true;
            this.lbBikeType.Location = new System.Drawing.Point(13, 19);
            this.lbBikeType.Name = "lbBikeType";
            this.lbBikeType.Size = new System.Drawing.Size(40, 17);
            this.lbBikeType.TabIndex = 3;
            this.lbBikeType.Text = "Tyoe";
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(16, 55);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(410, 185);
            this.panelContent.TabIndex = 4;
            // 
            // AddBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 281);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lbBikeType);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 328);
            this.Name = "AddBike";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbBikeType;
        private System.Windows.Forms.Label lbBikeType;
        private System.Windows.Forms.Panel panelContent;
    }
}