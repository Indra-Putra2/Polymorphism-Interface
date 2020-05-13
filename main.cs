using System;

namespace Polymorphism  
{
	class Program
	{
		static void Main(string[] args)
		{
		    IPrinterWindows printer;
			Console.WriteLine("Choose a Printer: ");
			Console.WriteLine("1. Epson");
			Console.WriteLine("2. Canon");
			Console.WriteLine("3. LaserJet");
			
			Console.Write("Printer Number[1..3]: ");
			int printerNumber = Convert.ToInt32(Console.ReadLine());
			
			if (printerNumber == 1)
				printer = new Epson();
			else if (printerNumber == 2)
				printer = new Canon();
			else
				printer = new LaserJet();
			
			printer.Show();
			printer.Print();
			
			Console.ReadKey();
		}
	}

    interface IPrinterWindows
    {
        void Show();
        void Print();
    }

	public class Epson : IPrinterWindows
	{
		public void Show()
		
		{
			Console.WriteLine("Epson display dimension: 10*11");
		}
		
		public void Print()
		{
			Console.WriteLine("Epson printer printing....");
		}
	}
	
	public class Canon : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Canon display dimension: 9.5*12");
		}
		
		public void Print()
		{
			Console.WriteLine("Canon printer printing....");
		}
	}
	
	public class LaserJet : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("LaserJet display dimension: 12*12");
		}
		
		public void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}
}
