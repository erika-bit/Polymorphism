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

  public class Epson : PrinterWindows
  {
      public override void Show()
      {
          Console.WriteLine("\nEpson display dimension: 10*11");
      }
      public override void Print()
      {
          Console.WriteLine("\nEpson printer printing.......");
      }
  }

  public class Canon : PrinterWindows
  {
      public override void Show()
      {
          Console.WriteLine("\nCanon display dimension: 9.5*12");
      }
      public override void Print()
      {
          Console.WriteLine("\nCanon printer printing.......");
      }
  }

  public class LaserJet : PrinterWindows
  {
      public override void Show()
      {
          Console.WriteLine("\nLaser Jet display dimension: 12*12");
      }
      public override void Print()
      {
          Console.WriteLine("\nLaser Jet printer printing......");
      }
  }

    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet");

            Console.Write("\nNomor Printer [1..3] : ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
                printer = new Epson();
            else if (nomorprinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
