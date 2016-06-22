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
        private UcCross ucCross;
        private UcHardTail ucHardTail;
        private UcMountain ucMountain;
        public AddBike(int bikeId)
        {
            InitializeComponent();

            ucMountain = new UcMountain(bikeId);
            ucCross = new UcCross(bikeId);
            ucMountain = new UcMountain(bikeId);

            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.Items.Add(BikeType.HardTail);
            cbBikeType.Items.Add(BikeType.Mountain);
            cbBikeType.SelectedIndex = 0;
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Helper.GetSelectedBikeType(cbBikeType.SelectedItem.ToString());
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
            var type = Helper.GetSelectedBikeType(cbBikeType.SelectedItem.ToString());
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

        private void AddBike_FormClosing(object sender, FormClosingEventArgs e)
        {
            var eventSource = (Form) sender;
            if(eventSource.DialogResult != DialogResult.Cancel)
            {
                if (!ValidateControls())
                {
                    MessageBox.Show("Please input correct value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private bool ValidateControls()
        {
            var type = Helper.GetSelectedBikeType(cbBikeType.SelectedItem.ToString());
            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.ValidateControls();
                //case BikeType.Mountain:
                //    return ucMountain.GetMountain();
                //case BikeType.HardTail:
                //    return ucHardTail.GetHardTail();
                default:
                    return true;
            }
        }
    }
}
