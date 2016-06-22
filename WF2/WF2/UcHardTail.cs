using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class UcHardTail : UserControl
    {
        private readonly int Id;
        public UcHardTail(int bikeId)
        {
            InitializeComponent();
            Id = bikeId;
        }

        public UcHardTail(HardTail bike)
        {
            InitializeComponent();
            tbSIze.Text = bike.Size.ToString();
            tbName.Text = bike.Name;
            this.Enabled = false;
        }

        public HardTail GetHardTail()
        {
            return new HardTail(Id) { Name = tbName.Text, Size = tbSIze.Text.GetInt()};
        }
    }
}
