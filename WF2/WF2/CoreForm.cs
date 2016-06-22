using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class CoreForm : Form
    {
        private int _bikeId = 1;
        private List<Bike> _bikes = new List<Bike>(); 
        public CoreForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike(_bikeId);
            if (ab.ShowDialog() == DialogResult.OK)
            {
                var bike = ab.GetCreatedBike();
                _bikes.Add(bike);

                var item = new ListViewItem(bike.Name);
                item.SubItems.Add(bike.Size.ToString());
                item.SubItems.Add(_bikeId.ToString());

                lvBikes.Items.Add(item);

                _bikeId ++;
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

        private void lvBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView) sender;
            if (listView.SelectedItems.Count > 0)
            {
                var listViewItem = listView.SelectedItems[0];

                int id = listViewItem.SubItems[2].Text.GetInt();

                foreach (var bike in _bikes)
                {
                    if (bike.Id == id)
                    {
                        scContent.Panel2.Controls.Clear();
                        scContent.Panel2.Controls.Add(new UcCross((Cross)bike) {Dock = DockStyle.Fill});
                        break;
                    }
                }
            }
        }

        private void bikeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(((ToolStripMenuItem)sender).ToolTipText, mainMenuStrip);
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveToFileStreamSafe();
                MessageBox.Show("Information", "File saved", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveToFileSimple()
        {
            try
            {
                string result = String.Empty;

                foreach (var bike in _bikes)
                {
                    result += bike + Environment.NewLine;
                }

                File.WriteAllText(@"D:\Work\ITA\base.txt", result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        private void SaveToFileStreamSafe()
        {
            try
            {
                using (var st = new FileStream(@"D:\Work\ITA\base.txt",
                            FileMode.CreateNew))
                {
                    using (var sw = new StreamWriter(st))
                    {
                        foreach (var bike in _bikes)
                        {
                            sw.Write(bike + Environment.NewLine);
                        }
                        sw.Close();
                    }
                    st.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void SaveToFileStream()
        {
            Stream st = null;
            StreamWriter sw = null;
            try
            {
                st = new FileStream(@"D:\Work\ITA\base.txt",
                    FileMode.CreateNew);
                sw = new StreamWriter(st);
                foreach (var bike in _bikes)
                {
                    sw.Write(bike + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
                if (st != null)
                {
                    st.Close();
                    st.Dispose();
                }
            }
        }
    }
}
