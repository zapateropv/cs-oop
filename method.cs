using System;
class HelloWorld {
  static void Main()
  {
  
    //method = performs a secteion of code, whenever it's called "invoked" (usability)
    
    String name = "Bro";
    int age = 21;
    
    singHappyBirthDay(name, age);
    
  
  }
  
  public static void singHappyBirthDay(String name, int age)
  {
      Console.WriteLine("Happy Birthday to you!");
      Console.WriteLine("Happy Birthday to you!");
      Console.WriteLine("Happy Birthday Dear " + name);
      Console.WriteLine("Happy Birthday to you!");
      Console.WriteLine("Your age is " + age);
  }
}
