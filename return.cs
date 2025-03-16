using System;
class HelloWorld {
  static void Main()
  {
  
  
  //return = returns data back to the place where a method is invoked
      double x;
      double y;
      double result;
      
      Console.WriteLine("Enter first no: ");
      x = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("Enter second no: ");
      y = Convert.ToDouble(Console.ReadLine());
      
      result = Multiply(x, y);
      Console.WriteLine(result);
  
  }
  
  static double Multiply(double x, double y)
  {
  
    
    return x * y;
  }
}
