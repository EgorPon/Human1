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
    public partial class CreateStudent : Form
    {
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            createCombobox();
        }
        private void createCombobox()
        {

            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                comboBox1.Items.Add(staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int age = int.Parse(textBoxAge.Text);
            int id = int.Parse(textBoxID.Text);
            int mark = int.Parse(textBoxMark.Text);
            string country = textBoxCountry.Text;
            string region = textBoxRegion.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            Address address = new Address(country, region, city, street);
            Student std = new Student(name, surname, age, id, mark, address);
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                
                if(comboBox1.SelectedItem.ToString()== staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname)
                {
                    staticlist.teachers[i].Add(std);
                    MessageBox.Show("Successful added");
                }
                
            }
        }
    }
}
