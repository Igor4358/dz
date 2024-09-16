using System;
class Point 
{
  public int X {get;}
  public int Y {get;}
  
  public Point(int x,int y)
  {
      X =x;
      Y =y;
  }
  public double Distance(Point otherPoint)
  {
      int deltaX = X - otherPoint.X;
      int deltaY = Y - otherPoint.Y;
      return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
  }
  static void Main(string[]argc)
  {
      Point p1 = new Point(0,0);
      Point p2 = new Point(3,4);
      
      double distance = p1.Distance(p2);
      Console.WriteLine("Расстояние между точками p1 и p2 составляет: " + distance );
  }
}