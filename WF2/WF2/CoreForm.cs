using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
            //scContent.Panel2.Controls.Add(new UcCross());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike();
            if (ab.ShowDialog() == DialogResult.OK)
            {
                lvBikes.Items.Add(ab.GetCreatedBike().ToString());
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goob bue!", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
