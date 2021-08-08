using System;
 class Name
  {
   string name;
   public Name(string name)
     {
       
       Console.Write("Name of the person is {0}",name);
      }

    }
class Age
{ 
   int age;
   public Age (int age)
     {
       
       Console.WriteLine("Age of the person is {0}",age);
     }
  }
 class implementNameandAge
    {
     public static void Main()
     {
      
                 Name obj1= new Name("Sunny");
		  Age obj = new Age(21);
                  
      
      }


    }