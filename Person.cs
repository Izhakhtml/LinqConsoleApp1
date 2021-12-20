using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp1
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int birthYear;
        public int age;
        public string city;
        public Person(string firstName, string lastName, int birthYear, int age, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.age = age;
            this.city = city;
        }
        //public Person() { }
    }
}
