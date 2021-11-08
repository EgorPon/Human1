using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human1
{
    class Student : Human
    {
            
        Random rnd = new Random();
        private marks rating;
        public string Mark { 
            get { return rating.ToString(); }
        }

        public Student(string Name, string Surname, int Age, int ID, int mark, Address Address) :base(Name, Surname, Age, ID, Address)
        {
          
            switch (mark)
            {
                case 2:
                    rating = marks.D;
                    break;
                case 3:
                    rating = marks.C;
                    break;
                case 4:
                    rating = marks.B;
                    break;
                case 5:
                    rating = marks.A;
                    break;
            }
        }

        enum marks
        {
            A = 5,
            B = 4,
            C = 3,
            D = 2
        }
    }
}
