using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human1
{
    class Human
    {
        public string name;
        public string surname;
        public int age;
        public int id;
        private Address adress;

        public string Name { set { name = value; } get { return name; } }
        public string Surname { set { surname = value; } get { return surname; } }
        public int Age { set { age = value; } get { return age; } }
        public int ID { set { id = value; } get { return id; } }

        public Address Adress { get { return adress; } }

        public Human() { }
        public Human(string Name, string Surname, int Age, int ID, Address Adress)
        {
            name = Name;
            surname = Surname;
            age = Age;
            id = ID;
            adress = Adress;
        }
    }
}
