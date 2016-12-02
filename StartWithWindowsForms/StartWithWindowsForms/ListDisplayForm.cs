using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithWindowsForms
{
    public partial class ListDisplayForm : Form
    {
        public ListDisplayForm(List<string> sources)
        {
            InitializeComponent();
            foreach (var item in sources)
            {
                lvSubjects.Items.Add(item);
            }
        }

        private void lvSubjects_Resize(object sender, EventArgs e)
        {
            lvSubjects.Columns[0].Width = lvSubjects.Size.Width - 5;
        }
    }
}
