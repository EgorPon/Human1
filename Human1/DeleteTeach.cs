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
    public partial class DeleteTeach : Form
    {
        public DeleteTeach()
        {
            InitializeComponent();
        }
        private void createcomboBox()
        {
            for(int i=0;i<staticlist.teachers.Count;i++)
            {
                comboBox1.Items.Add(staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {

                if (comboBox1.SelectedItem.ToString() == staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname)
                {
                    staticlist.teachers.RemoveAt(i);
                    MessageBox.Show("Successfully removed");
                }
            }
        }

            private void DeleteTeach_Load(object sender, EventArgs e)
        {
            createcomboBox();
        }
    }
}
