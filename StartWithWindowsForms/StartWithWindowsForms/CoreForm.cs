using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StartWithWindowsForms
{
    public partial class CoreForm : Form
    {
        List<Subject> _subjects = new List<Subject>(); 
        public CoreForm()
        {
            InitializeComponent();

            _subjects.Add(new Subject
            {
                Name = "C#",
                Id = 4
            });
            _subjects.Add(new Subject
            {
                Name = "Database",
                Id = 2
            });
            FillComboBox();
        }

        private void FillComboBox()
        {
            cbSubjects.Items.Clear();
            cbSubjects.Items.AddRange(_subjects.ToArray());
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
            if (cbSubjects.SelectedItem is Subject)
            {
                var elemebt = cbSubjects.SelectedItem as Subject;
            }

            tbTask.Text = $"Task for {cbSubjects.SelectedItem}";
        }

        private void btAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm addForm  = new AddSubjectForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _subjects.Add(addForm.Subject);
                FillComboBox();
            }
        }

        private void btViewAllSubject_Click(object sender, EventArgs e)
        {
            //List<Subject> list = cbSubjects.Items.Cast<Subject>().ToList();
            ListDisplayForm displayForm = new ListDisplayForm(_subjects);
            displayForm.ShowDialog();
        }
    }
}
