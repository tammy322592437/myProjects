using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromFile r = new ReadFromFile();
            string textFile = @"TammarShveytza";
            r.ReadFromFileFunc(textFile);
            Console.ReadLine();
        }
    }
}
