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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                List<Student> std = staticlist.teachers[i].getList();
                for (int j = 0; j < std.Count; j++)
                {
                    if (textBox1.Text.ToString() == std[j].Name + " " + std[j].Surname)
                    {
                        
                        MessageBox.Show(" Name: " + std[j].Name + "; Surname: " + std[j].Surname + "; Age: "+ std[j].Age+ "; ID: " + std[j].ID + "; Mark: " + std[j].Mark + "; Address: " +std[j].Adress.Country +" "+ std[j].Adress.Region + " " + std[j].Adress.City + " " + std[j].Adress.Street);
                    }
                }
            }
        }
    }
}
