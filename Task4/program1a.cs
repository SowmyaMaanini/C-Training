using System;
public class NameandAge
  {
    
   public void Name()
     {
       
       Console.WriteLine("Enter name");
       string name=Console.ReadLine();
       Console.Write("Name of the person is {0}",name);
     }
   public void Age()
     {
       Console.WriteLine("Enter Age");
       int age = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Age of the person is {0}",age);
     }
  }
public class implementNameandAge
    {
     public static void Main()
     {
       NameandAge obj = new NameandAge();
       obj.Name();
       obj.Age();
      
      }
}