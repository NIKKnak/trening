﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trening
{
    public class Struct
    {
        public struct PersonStruct
        {
            public string name;
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
        }

        



    }
}
