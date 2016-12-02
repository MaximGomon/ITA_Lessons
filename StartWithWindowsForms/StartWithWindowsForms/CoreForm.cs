using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StartWithWindowsForms
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
        }

        private void cbTaskDone_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox source = (CheckBox) sender;
            if (source.Checked)
            {
                MessageBox.Show("This is info", "Task is DONE!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                tbTask.Text = "Current task is done";
                tbTask.Enabled = false;
            }
            else
            {
                tbTask.Enabled = true;
                tbTask.Text = String.Empty;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTask.Text = $"Task for {cbSubjects.SelectedItem}";
        }

        private void btAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm addForm  = new AddSubjectForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string newSubject = addForm.SubjectName;
                if (newSubject != String.Empty)
                {
                    cbSubjects.Items.Add(newSubject);
                }
            }
        }

        private void btViewAllSubject_Click(object sender, EventArgs e)
        {
            List<string> list = cbSubjects.Items.Cast<string>().ToList();
            ListDisplayForm displayForm = new ListDisplayForm(list);
            displayForm.ShowDialog();
        }
    }
}
