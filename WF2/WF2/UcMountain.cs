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
    public partial class UcMountain : UserControl
    {
        private readonly int Id;
        public UcMountain(int bikeId)
        {
            InitializeComponent();
            Id = bikeId;
        }

        public Mountain GetMountain()
        {
            return new Mountain(Id) { Name = tbName.Text, Size = tbSIze.Text.GetInt()};
        }
    }
}
