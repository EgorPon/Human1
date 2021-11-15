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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();

        }
        private void Createcombobox()
        {
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {   
                List<Student> std = staticlist.teachers[i].getList();
                for (int j = 0; j < std.Count; j++)
                {
                    
                    comboBox1.Items.Add(std[j].Name + " " + std[j].Surname);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                List<Student> std = staticlist.teachers[i].getList();
                for (int j = 0; j < std.Count; j++)
                {
                    if(comboBox1.SelectedItem.ToString()== std[j].Name + " " + std[j].Surname)
                    {
                        staticlist.teachers[i].RemoveStd(j);
                        MessageBox.Show("Successfully removed");
                    }
                }
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            Createcombobox();
        }
    }
}
