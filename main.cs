using System;
class HelloWorld 
{
  static void Main() 
  {
    #region rectangle
     
    Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for(int j=0;j<5;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    #endregion

    #region triangle1
     
    Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for(int j=0;j<=i;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    #endregion
    
    #region triangle2
      
    Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for(int j=5;j>i;j--)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    #endregion
  
    #region triangle3
         
        Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for (int j=5;j>i;j--)
        {
             Console.Write(" ");
        }
        for(int j=0;j<=i;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    #endregion
    
    #region triangle4
         
        Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for (int j=0;j<=i;j++)
        {
             Console.Write(" ");
        }
        for(int j=5;j>i;j--)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    #endregion
    
    #region rombus
    
    Console.WriteLine();
    for(int i=0; i<5; i++)
    {
        for(int j=i; j<5; j++)
        {
            Console.Write(" ");
        }
        Console.Write("/");
        for(int j=0; j < i*2; j++)
        {
            Console.Write(" ");
        }
        Console.Write("\\");
        Console.WriteLine();
    }
     for (int i=0; i < 5; i++)
	{
		for (int j=0; j <= i; j++)
		{
		Console.Write(" ");
		}
	Console.Write("\\");
	
		for (int j = (i + 1) * 2; j < (5) * 2; j++)
		{
		Console.Write(" ");
		}
		Console.Write("/");

        Console.WriteLine();
    }
      #endregion
      
      #region rectangle2
    Console.WriteLine();
    for(int i=0;i<5;i++)
    {
        for(int j=0;j<5;j++)
        {
            if((i+j)%2==0)
            Console.Write("+ ");
            else
            Console.Write("- ");
        }
        Console.WriteLine();
    }
    #endregion
    
    #region chess
    Console.WriteLine();
    Console.WriteLine();
    for(int i=0;i<5;i++)
     {
        for (int j=0;j<5;j++)
         {
            for (int k=0;k<5;k++)
                for (int f=0;f<5;f++)
                    if((i+k)%2 == 0)
                        Console.Write("* ");
                    else 
                        Console.Write("  ");
                        Console.WriteLine();
         }
        Console.WriteLine();
     }
    #endregion
  }
}