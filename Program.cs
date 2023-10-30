using System.Diagnostics;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\nik88\OneDrive\Desktop\Текстовый документ.txt";

        string text = "sdfdsfdsf";


        using (StreamWriter stream = new StreamWriter(path, true))
        {
            stream.WriteLine(text);
        }






    }


}