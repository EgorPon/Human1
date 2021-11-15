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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateTeacher()
        {
            Address address = new Address("Ukraine", "Donetskaya", "Donetsk", "Debal`cevo");
            Teacher pop = new Teacher("Vitaliy", "Gromyako", 35, 421, address);
            Teacher pop1 = new Teacher("Tolya", "Got", 40, 325, address);


            Student pip1 = new Student("Grisha", "Zabugrovich", 19, 12, 4, address);
            Student pip2 = new Student("Misha", "Hohol", 21, 13, 3, address);
            Student pip3 = new Student("Kolya", "Vodniy", 17, 14, 5, address);
            Student pip4 = new Student("Maxim", "Chornozub", 18, 15, 2, address);

            staticlist.teachers.Add(pop);
            staticlist.teachers.Add(pop1);

            staticlist.teachers[0].Add(pip1);
            staticlist.teachers[1].Add(pip2);
            staticlist.teachers[0].Add(pip3);
            staticlist.teachers[1].Add(pip4);


        }
      

       
        private void CreateDT()
        {
            List<Student> std1 = std();

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


            foreach (Student i in std1)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Mark, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);
            }
            dataGridView1.DataSource = tab;
        }

        private void CreateDT(List<Teacher> tch)
        {
            DataTable tab = new DataTable();
            tab.Columns.Add("Name");
            tab.Columns.Add("Surname");
            tab.Columns.Add("Age");
            tab.Columns.Add("ID");
            tab.Columns.Add("Country");
            tab.Columns.Add("Region");
            tab.Columns.Add("City");
            tab.Columns.Add("Street");


            foreach (Teacher i in tch)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);

            }
            dataGridView2.DataSource = tab;
        }
        

        private List<Student> std()
        {

            List<Student> std = new List<Student>();
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                List<Student> list = staticlist.teachers[i].getList();
                for (int j = 0; j < list.Count; j++)
                {
                    std.Add(list[j]);
                }
            }
            return std;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeacher();
           
            CreateDT(staticlist.teachers);
       
            CreateDT();
         
        }





       

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent newForm = new CreateStudent();
            newForm.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTeach newForm = new CreateTeach();
            newForm.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteStudent newForm = new DeleteStudent();
            newForm.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteTeach newForm = new DeleteTeach();
            newForm.Show();
        }

        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            search newForm = new search();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDT();
         
            CreateDT(staticlist.teachers);
          
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string a = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(a);
            pictureBox1.BackgroundImage = Image.FromFile("C:/Users/Admin/source/repos/Human1/Human1/User_icon.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string a = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(a);
            pictureBox1.BackgroundImage = Image.FromFile("C:/Users/Admin/source/repos/Human1/Human1/2.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void groupsOfTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group newForm = new Group();
            newForm.Show();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treeview newForm = new Treeview();
            newForm.Show();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart newForm = new Chart();
            newForm.Show();
        }

        private void teacherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            search1 newForm = new search1();
            newForm.Show();
        }
    }
}

