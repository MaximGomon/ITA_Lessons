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
    public partial class AddBike : Form
    {
        private UcCross ucCross = new UcCross();
        private UcHardTail ucHardTail = new UcHardTail();
        private UcMountain ucMountain = new UcMountain();
        public AddBike()
        {
            InitializeComponent();
            
            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.Items.Add(BikeType.HardTail);
            cbBikeType.Items.Add(BikeType.Mountain);
            cbBikeType.SelectedIndex = 0;
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BikeType type = (BikeType)Enum.Parse(
                typeof (BikeType), 
                cbBikeType.SelectedItem.ToString()
                );
            switch (type)
            {
                    case BikeType.Cross:
                        panelContent.Controls.Clear();
                        panelContent.Controls.Add(ucCross);
                        break;
                    case BikeType.Mountain:
                        panelContent.Controls.Clear();
                        panelContent.Controls.Add(ucMountain);
                        break;
                    case BikeType.HardTail:
                        panelContent.Controls.Clear();
                        panelContent.Controls.Add(ucHardTail);
                        break;
            }
        }

        public Bike GetCreatedBike()
        {
            BikeType type = (BikeType)Enum.Parse(
                typeof(BikeType),
                cbBikeType.SelectedItem.ToString()
                );
            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.GetCross();
                case BikeType.Mountain:
                    return ucMountain.GetMountain();
                case BikeType.HardTail:
                    return ucHardTail.GetHardTail();
                default:
                    return null;
            }
        }
    }
}
