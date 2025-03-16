using System;
class HelloWorld {
  static void Main()
  {
  
  //method overloading = methods share same name but different parameters
  
  double total;
  total = Multiply(3, 6);
  
  Console.WriteLine(total);
  
  }
  
  static double Multiply(double a, double b)
  {
  
    return a * b;
    
  }
   static double Multiply(double a, double b, double c)
  {
  
    return a * b * c;
    
  }
}
