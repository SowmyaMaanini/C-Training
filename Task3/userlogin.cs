using System;
public class Userlogin
{
   public void optionA(string emailID , string password)
     {
         
         Console.WriteLine("user login successfull");
         Console.WriteLine(" Login credentials are {0} and {1}" , emailID,password);
          
     }
     public void optionB(string MemID , int pin)
     {
      Console.WriteLine("user login successfull"); 
      Console.WriteLine(" Login credentials are {0} and {1}" , MemID,pin);
      
     }
     public void optionC(string MobileNo , int pin)
     {
       Console.WriteLine("user login successfull"); 
       Console.WriteLine(" Login credentials are {0} and {1}" , MobileNo,pin);
     }
     
     
public static void Main()
    {
         Userlogin obj1= new Userlogin();
         obj1.optionA("sunny@gmail.com","sun");
         obj1.optionB("MEM1",1234);
         obj1.optionC( "9876543210",4321);
         
    }
   




} 
   