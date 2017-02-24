namespace StartWithWindowsForms
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
            this.btOk = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.cbTaskDone = new System.Windows.Forms.CheckBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.btAddSubject = new System.Windows.Forms.Button();
            this.lbTask = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.btViewAllSubject = new System.Windows.Forms.Button();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(308, 177);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(389, 177);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbSubjects
            // 
            this.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(83, 33);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(288, 24);
            this.cbSubjects.TabIndex = 2;
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbSubjects_SelectedIndexChanged);
            // 
            // cbTaskDone
            // 
            this.cbTaskDone.AutoSize = true;
            this.cbTaskDone.Location = new System.Drawing.Point(83, 100);
            this.cbTaskDone.Name = "cbTaskDone";
            this.cbTaskDone.Size = new System.Drawing.Size(106, 21);
            this.cbTaskDone.TabIndex = 3;
            this.cbTaskDone.Text = "Is task done";
            this.cbTaskDone.UseVisualStyleBackColor = true;
            this.cbTaskDone.CheckedChanged += new System.EventHandler(this.cbTaskDone_CheckedChanged);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.btAddSubject);
            this.mainGroupBox.Controls.Add(this.lbTask);
            this.mainGroupBox.Controls.Add(this.tbTask);
            this.mainGroupBox.Controls.Add(this.lbSubject);
            this.mainGroupBox.Controls.Add(this.cbTaskDone);
            this.mainGroupBox.Controls.Add(this.cbSubjects);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(452, 129);
            this.mainGroupBox.TabIndex = 4;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "General elements";
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(377, 33);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(69, 24);
            this.btAddSubject.TabIndex = 8;
            this.btAddSubject.Text = "Add";
            this.btAddSubject.UseVisualStyleBackColor = true;
            this.btAddSubject.Click += new System.EventHandler(this.btAddSubject_Click);
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Location = new System.Drawing.Point(22, 75);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(39, 17);
            this.lbTask.TabIndex = 7;
            this.lbTask.Text = "Task";
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(83, 72);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(363, 22);
            this.tbTask.TabIndex = 6;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(22, 35);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(55, 17);
            this.lbSubject.TabIndex = 5;
            this.lbSubject.Text = "Subject";
            // 
            // btViewAllSubject
            // 
            this.btViewAllSubject.Location = new System.Drawing.Point(308, 148);
            this.btViewAllSubject.Name = "btViewAllSubject";
            this.btViewAllSubject.Size = new System.Drawing.Size(156, 23);
            this.btViewAllSubject.TabIndex = 5;
            this.btViewAllSubject.Text = "View all subjects";
            this.btViewAllSubject.UseVisualStyleBackColor = true;
            this.btViewAllSubject.Click += new System.EventHandler(this.btViewAllSubject_Click);
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 209);
            this.Controls.Add(this.btViewAllSubject);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My first form";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.CheckBox cbTaskDone;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btAddSubject;
        private System.Windows.Forms.Button btViewAllSubject;
    }
}

