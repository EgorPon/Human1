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
    public partial class Treeview : Form
    {
        public Treeview()
        {
            InitializeComponent();
        }
        private void CreateTree()
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "Teacher";
            root.Name = "Teachers";
            treeView1.Nodes.Add(root);
            for (int i = 0; i < staticlist.teachers.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(staticlist.teachers[i].Name + " " + staticlist.teachers[i].Surname);
                for (int j = 0; j < staticlist.teachers[i].getList().Count(); j++)
                {
                    List<Student> list = staticlist.teachers[i].getList();
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(list[j].Name + " " + list[j].Surname);
                }
            }
        }

        private void Treeview_Load(object sender, EventArgs e)
        {
            CreateTree();
        }
    }
}
