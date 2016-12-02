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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        //public string SubjectName
        //{
        //    get
        //    {
        //        return tbSubjectName.Text.Trim();
        //    }
        //}

        public string SubjectName => tbSubjectName.Text.Trim();
    }
}
