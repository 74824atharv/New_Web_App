using Drawing;
using Drivers;

public class Line:Shape,MyPrinter{
   // aggregation used ---- Line has Point

   public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

   public Line():base()
   {
    this.StartPoint=new Point(0,0);
    this.EndPoint=new Point(0,0);
   }
   public Line(Point StartPoint,Point Endpoint,string Colorname,int Width):base(Colorname,Width)
   {
    this.StartPoint=StartPoint;
    this.EndPoint=Endpoint;
   }
   
   public void print()
   {
    Console.WriteLine("Printing....");
    Console.WriteLine(this);
   }

    public override void Draw()
    {
    Console.WriteLine("Writting...");
    Console.WriteLine(this);
    }

    public override string ToString()
    {
        return base.ToString()+ " Start Point is "+this.StartPoint+" End Point is"+ this.EndPoint;
    }
}


