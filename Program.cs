﻿using System.Diagnostics;
using System.Net;
using System.Text;
using System.Xml.Linq;
using trening;


namespace trening
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person(age:20);
            Person person1 = new Person("Tom", 20);
            Person person2 = new Person("Max");
            Person person4 = new Person();

            Struct.PersonStruct personStruct;

            personStruct.age = 20;
            personStruct.name = "Tom";
            personStruct.Print();

            
            person.Print();
            person1.Print();
            person2.Print();
            person4.Print();


            // тест печатной машинки
            string a = "asdsadsadsdsdsadsadssadsa";

            TypeWriter typeWriter = new TypeWriter();
            typeWriter.PrintTypeWriters(a);


        }

       

    }
}