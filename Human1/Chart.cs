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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
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
        private void CreateChart(List<Teacher> tch)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < tch.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(tch[i].Name, tch[i].Age);
            }
        }

        private void CreateChart()
        {
            List<Student> std1 = std();

            chart2.Series["Series1"].Points.Clear();
            for (int i = 0; i < std1.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY(std1[i].Name, std1[i].Age);
            }
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            CreateChart();
            CreateChart(staticlist.teachers);
        }
    }
}
