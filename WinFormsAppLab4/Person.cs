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
        private double gpa;




        public Person(string Name ,int bYear ,double GPA ) 
        { 
            this.name = Name;
            this.birthYear = bYear;
            this.age = 2565 - bYear;
            gpa = GPA;
           
        }

        public int getAge()
        { 
            return this.age;
        }
        public string getName()
        {
            return name;
        
        }
        public double getGPA()
        {
            return gpa;
        }
       

    }
}
