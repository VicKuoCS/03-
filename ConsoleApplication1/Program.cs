﻿using SharedProject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Vic";
            Console.WriteLine(p.Name);
        }
    }
}
