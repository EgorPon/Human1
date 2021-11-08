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
    public partial class CreateTeach : Form
    {
        public CreateTeach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int age = int.Parse(textBoxAge.Text);
            int id = int.Parse(textBoxID.Text);
            string country = textBoxCountry.Text;
            string region = textBoxRegion.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            Address address = new Address(country, region, city, street);
            Teacher tcher = new Teacher(name, surname, age, id, address);
            
            staticlist.teachers.Add(tcher);
            MessageBox.Show("Successful added");
        }
    }
}
