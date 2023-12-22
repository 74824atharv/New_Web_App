namespace Drawing;

public abstract class Shape{

public string Colorname{get;set;}
public int Width{get;set;}

public Shape()
{
    this.Colorname="Red";
    this.Width=50;

}
public Shape(string col,int w )
{
  this.Colorname=col;
  this.Width=w;
  
}
 public abstract void Draw();

    public override string ToString()
    {
        return "Colour is "+this.Colorname+" Width is "+this.Width;
    }

}