using System;
class Calculator 
{
  static void Main(string[]args)
  {
      
    Console.WriteLine("Введите первое число");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите второе число");
    double num2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("выберите операцию ");
    Console.WriteLine("1. + ");
    Console.WriteLine("2. - ");
    Console.WriteLine("3. * ");
    Console.WriteLine("4. / ");
    
    char operation = Console.ReadKey().KeyChar;
    Console.WriteLine();
     
  
    
    double result = 0;
    
    switch(operation)
    {
        case '1':
        result = num1 + num2;
        break;
        case '2':
        result = num1 - num2;
        break;
        case '3':
        result = num1 * num2;
        break;
        case '4':
        if(num2 !=0)
        {
             result = num1 / num2;
        }
        else
        {
           Console.WriteLine("деление на ноль");
           return;
        }
        break;
        default:
        Console.WriteLine("неверная операция");
        return;
    }
    Console.WriteLine("Результат: " + result);
  }
}