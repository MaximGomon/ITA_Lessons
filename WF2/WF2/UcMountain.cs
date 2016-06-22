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

        public UcMountain(Mountain bike)
        {
            InitializeComponent();
            tbSIze.Text = bike.Size.ToString();
            tbName.Text = bike.Name;
            this.Enabled = false;
        }

        public Mountain GetMountain()
        {
            return new Mountain(Id) { Name = tbName.Text, Size = tbSIze.Text.GetInt()};
        }
    }
}
