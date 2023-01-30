using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLab4
{
    public class Classroow
    {
        private string name;
        private List<Person> persons = new List<Person>();

        public Classroow(string name)
        {
            this.name = name;
        }

        public void addPerson2Class(Person p)
        {

            this.persons.Add(p);
        }

        public string showAllPersoninClass()
        {
            string result = "0";
            foreach (Person p in this.persons)
            {
                result += p.getName + "\r\n";
            }
            return "";
        }
         public string ShowMaxGPA()
        {

        }
    }

     
}
