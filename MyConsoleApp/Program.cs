// See https://aka.ms/new-console-template for more information
using Drawing;

Line l1=new Line();
l1.StartPoint= new Drawing.Point(4,5);
l1.EndPoint= new Drawing.Point(2,6);
l1.Colorname="Orange";
l1.Width=88;

l1.Draw();
Console.WriteLine();

l1.print();
Console.WriteLine();
Console.WriteLine(l1);
