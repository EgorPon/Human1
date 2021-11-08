using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human1
{
    class Teacher : Human
    {
        private List<Student> studentlist = new List<Student>();
        public void Add(Student Pip)
        {
            studentlist.Add(Pip);
        }

        public Teacher(string Name, string Surname, int Age, int ID, Address adress) :
            base(Name, Surname, Age, ID, adress)
        {

        }   
        public List<Student> getList()
        {
            return studentlist;
        }
    }
}
