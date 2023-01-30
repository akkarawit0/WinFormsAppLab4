using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLab4
{
    public class Person
    {
        private string name;
        private int age;
        private int birthYear;




        public Person(string Name ,int bYear) 
        { 
            this.name = Name;
            this.birthYear = bYear;
            this.age = 2565 - bYear;

        }

        public int getAge()
        { 
            return this.age;
        }
        public string getName()
        {
            return name;
        
        }


    }
}
