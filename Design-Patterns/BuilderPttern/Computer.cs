using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPttern
{
    public class Computer //  فقط داده ها را نگه میدار 
    {
        public  string CPU { get; set; }
        public  string RAM { get; set; }
        public  string Storage { get; set; }
        public  string GPU { get; set; }

        public void DisplaySpecs()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"GPU: {(GPU ?? "Integrated")}");
        }
    }
}
