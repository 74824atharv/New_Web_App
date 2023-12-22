using Drivers;

public class HPPrinter:MyPrinter,MyScanner{
  public void print()
  {
    Console.WriteLine("Printer is printing....");
  }
   public void scan()
  {
    Console.WriteLine("Scanner is scanning....");
  }

}