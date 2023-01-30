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
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }


        public string SumYear()
        {
            int year = 0;
            foreach (Person y in persons)
            {
                int currentAge = year;
                int newTotalAge = currentAge + y.getAge();
                year = newTotalAge;
            }
            return year.ToString();

        }
            public string avgMaxGPA()
        {
            double GPA = 0;
            int cout = 0;
            foreach (Person p in this.persons)
            {
                GPA += p.getGPA();
                cout++;
            }
            double GpaAvg = GPA / cout;
            return GpaAvg.ToString();

        }
        public string MaxGPA()
        {
            double GPA = 0;
            int count = 0;
            double GpaMax = 0;
            string name = "";
            foreach (Person p in persons)
            {
                double currentGPA = p.getGPA();
                GPA += currentGPA;
                count++;
                if (currentGPA > GpaMax)
                {
                    GpaMax = currentGPA;
                    name = p.getName();
                }
            }
            return GpaMax.ToString();

        }
        public string MinGPA()
        {
            double GPA = 0;
            int count = 0;
            double GpaMin = double.MaxValue;
            string name = "";
            foreach (Person p in persons)
            {
                double currentGPA = p.getGPA();
                GPA += currentGPA;
                count++;
                if (currentGPA < GpaMin)
                {
                    GpaMin = currentGPA;
                    name = p.getName();
                }
            }
            return GpaMin.ToString();
        }

        public string GpaminName()
        {
            double GPA = 0;
            int count = 0;
            double Gpamin = double.MaxValue;
            string name = "";
            foreach (Person p in persons)
            {
                double currentGPA =  p.getGPA();
                GPA += currentGPA;
                count++;
                if (currentGPA < Gpamin)
                {
                    Gpamin = currentGPA;
                    name = p.getName();
                }
            }
            return name;

        }
        public string GpamaxName ()
        {
            double GPA = 0;
            int count = 0;
            double GpaMax = 0;
            string name = "";
            foreach (Person p in persons)
            {
                double currentGPA = p.getGPA();
                GPA += currentGPA;
                count++;
                if (currentGPA > GpaMax)
                {
                    GpaMax = currentGPA;
                    name = p.getName();
                }
            }
            return name;
        }
    } 


}
