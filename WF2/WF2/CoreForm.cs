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

                AddItemToListView(bike);

                _bikeId ++;
            }
        }

        private void AddItemToListView(Bike bike)
        {
            var item = new ListViewItem(bike.Name);
            item.SubItems.Add(bike.Size.ToString());
            item.SubItems.Add(bike.Id.ToString());

            lvBikes.Items.Add(item);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files|*.txt";
            openFile.Multiselect = false;
            openFile.InitialDirectory = Directory.GetCurrentDirectory();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string fileText = File.ReadAllText(openFile.FileName);

                List<string> stringBikes = fileText.Split(Environment.NewLine.ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                _bikes.Clear();
                lvBikes.Items.Clear();

                foreach (var stringBike in stringBikes)
                {
                    var stringBikeType = stringBike.Split(';').ToList()[3];
                    BikeType type;
                    Enum.TryParse(stringBikeType, true, out type);

                    switch (type)
                    {
                            case BikeType.Cross:
                            Cross bike;
                            if(Cross.TryParse(stringBike, out bike))
                            {
                                _bikes.Add(bike);
                                AddItemToListView(bike);
                            }
                            break;
                        case BikeType.Mountain:
                            Mountain mbike;
                            if (Mountain.TryParse(stringBike, out mbike))
                            {
                                _bikes.Add(mbike);
                                AddItemToListView(mbike);
                            }
                            break;
                        case BikeType.HardTail:
                            HardTail hbike;
                            if (HardTail.TryParse(stringBike, out hbike))
                            {
                                _bikes.Add(hbike);
                                AddItemToListView(hbike);
                            }
                            break;
                    }
                    
                }
            }
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
                        
                        if (bike.GetType() == typeof (Cross))
                        {
                            scContent.Panel2.Controls.Add(new UcCross((Cross)bike) {Dock = DockStyle.Fill});
                        }
                        else if (bike.GetType() == typeof (Mountain))
                        {
                            scContent.Panel2.Controls.Add(new UcMountain((Mountain)bike) { Dock = DockStyle.Fill });
                        }
                        else if (bike.GetType() == typeof(HardTail))
                        {
                            scContent.Panel2.Controls.Add(new UcHardTail((HardTail)bike) { Dock = DockStyle.Fill });
                        }
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
                SaveToFileSimple();
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
