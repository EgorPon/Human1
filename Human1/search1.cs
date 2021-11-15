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
    public partial class search1 : Form
    {
        public search1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                if (textBox1.Text.ToString() == staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname)
                {

                    MessageBox.Show(" Name: " + staticlist.teachers[i].Name + "; Surname: " + staticlist.teachers[i].Surname +"; Age: "+ staticlist.teachers[i].Age + "; ID: " + staticlist.teachers[i].ID + "; Address: " + staticlist.teachers[i].Adress.Country + " " + staticlist.teachers[i].Adress.Region + " " + staticlist.teachers[i].Adress.City + " " + staticlist.teachers[i].Adress.Street);
                }
            }
        }
    }
}
