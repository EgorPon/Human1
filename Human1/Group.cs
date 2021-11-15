using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human1
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }
        private void CreateComboBox()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                comboBox1.Items.Add(staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int i = 0; i < staticlist.teachers.Count; i++)
            {

                if (comboBox1.SelectedItem.ToString() == staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname)
                {
                    List<Student> std1 = staticlist.teachers[i].getList();
                    DataTable tab = new DataTable();
                    tab.Columns.Add("Name");
                    tab.Columns.Add("Surname");
                    tab.Columns.Add("Age");
                    tab.Columns.Add("ID");
                    tab.Columns.Add("Mark");
                    tab.Columns.Add("Country");
                    tab.Columns.Add("Region");
                    tab.Columns.Add("City");
                    tab.Columns.Add("Street");


                    foreach (Student a in std1)
                    {
                        tab.Rows.Add(a.Name, a.Surname, a.Age, a.ID, a.Mark, a.Adress.Country, a.Adress.Region, a.Adress.City, a.Adress.Street);
                    }
                    dataGridView1.DataSource = tab;

                }

            }
        }

        private void Group_Load(object sender, EventArgs e)
        {
            CreateComboBox();
        }
    }
}
