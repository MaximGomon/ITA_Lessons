using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StartWithWindowsForms
{
    public partial class ListDisplayForm : Form
    {
        public ListDisplayForm(List<Subject> sources)
        {
            InitializeComponent();
            FillList(sources);
        }

        private void FillList(List<Subject> sources)
        {
            foreach (Subject item in sources)
            {
                //создаем елемент листвью и задаем значение для первой колонки
                var listViewItem = new ListViewItem(item.Name);
                //добавляем в елемент листвью поделемент (значение следующей колонки)
                listViewItem.SubItems.Add(item.Id.ToString());
                //добавляем в елемент листвью поделемент (значение следующей колонки)
                listViewItem.SubItems.Add(item.ToString());
                //добавляем созданніе елемент листвью в листвью
                lvSubjects.Items.Add(listViewItem);
            }
        }

        private void lvSubjects_Resize(object sender, EventArgs e)
        {
            lvSubjects.Columns[0].Width = lvSubjects.Size.Width - 155;
        }

        private void lvSubjects_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //var list = lvSubjects.Items;
            //list.
            List<Subject> list = new List<Subject>();
            foreach (ListViewItem item in lvSubjects.Items)
            {
                list.Add(new Subject
                {
                    Name = item.SubItems[0].Text,
                    Id = int.Parse(item.SubItems[1].Text)
                });
            }
            lvSubjects.Items.Clear();
            list.Sort();
            FillList(list);
            MessageBox.Show("Click");
        }

        private void ListDisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
