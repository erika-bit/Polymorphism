using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string namaprinter { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\nPrinter display dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("\nPrinter printing.......");
        }
    }
}
