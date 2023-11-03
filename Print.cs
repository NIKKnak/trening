using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace trening
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name = "неизвестно", int age = 0)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age}");
           
        }
    }

    
}
