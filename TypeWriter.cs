using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace trening
{
    internal class TypeWriter
    {

        public void PrintTypeWriters(string value)
        {

            foreach (var chars in value)
            {
                Console.Write(chars);
                Thread.Sleep(50);
            }
        }

    }
}
