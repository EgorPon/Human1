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

        private List<Teacher> teacher= new List<Teacher>();
        private List<Student> student=new List<Student>();
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

            teacher.Add(pop);
            teacher.Add(pop1);

            teacher[0].Add(pip1);
            teacher[1].Add(pip1);
            teacher[0].Add(pip3);       
            teacher[1].Add(pip4);

            student.Add(pip1);
            student.Add(pip2);
            student.Add(pip3);
            student.Add(pip4);

        }
        private void CreateChart(List<Teacher> tch)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < tch.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(tch[i].Name, tch[i].Age);
            }
        }

        private void CreateChart(List<Student> std)
        {   

            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < std.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(std[i].Name, std[i].Age);
            }
        }
        private void dtCreate(List<Student> std)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("ID");
            dt.Columns.Add("Mark");
            dt.Columns.Add("Country");
            dt.Columns.Add("Region");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
           

            foreach (Student i in std)
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Mark, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);
            }
            dataGridView1.DataSource = dt;
        }

        private void dtCreate(List<Teacher> tch)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("ID");
            dt.Columns.Add("Country"); 
            dt.Columns.Add("Region");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
           

            foreach (Teacher i in tch)
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);
                
            }
            dataGridView2.DataSource = dt;
        }
        private void CreaateComboBox()
        {
 
            for (int i=0;i<teacher.Count;i++)
            {   
                comboBox1.Items.Add(teacher[i].Name + " " + teacher[i].Surname);
            }
        }
        private void CreateTree()
        {
            TreeNode root = new TreeNode();
            root.Text = "Teacher";
            root.Name = "Teachers";
            treeView1.Nodes.Add(root);
            for(int i=0;i< teacher.Count;i++)
            {
                treeView1.Nodes[0].Nodes.Add(teacher[i].Name + " " + teacher[i].Surname);
                for(int j=0;j<teacher[i].getList().Count();j++)
                {
                    List<Student> list = teacher[i].getList();
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(list[j].Name + " " + list[j].Surname);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeacher();
            CreateChart(teacher);
            dtCreate(student);
            dtCreate(teacher);
            CreaateComboBox();
            CreateTree();
        }
    }
}
