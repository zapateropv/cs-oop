using System;
class HelloWorld {
  static void Main() {
    //params keyword = a method parameter that takes a variable number of arguments
    //                 the parameter type must be a single dimensional array
    
   double total = CheckOut(4.33, 9.12, 7.44, 5.17);
   Console.WriteLine(total);
  }
  
  static double CheckOut(params double[] prices)
  {
      double total = 0;
      
      foreach(double price in prices)
      {
          total += price;
      }
      
      return total;
  }
}
