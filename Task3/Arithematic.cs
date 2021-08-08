using System;
 class AddnSubtract
      {
                 
        public void Add(int x,int y)
         {
             int num1= x;
             int num2 = y;
			
            
		   
           Console.WriteLine("Sum is {0}" ,num1+num2);
           }
         public void Subtract(int x, int y)
         {
              int num1= x;
             int num2 = y;
            
        
			  
           Console.WriteLine("difference is {0}",num1-num2);
          }
	  
         
          }
//derived class
  class MultiplynDivide: AddnSubtract
  { 
	    public void Multiply(int x,int y)
		{ 
		   int num1= x;
             int num2 = y;
		  Console.WriteLine("product is" + num1*num2);
		  
		}
		 public void Divide(int x,int y)
		{ 
		   int num1= x;
             int num2 = y;
		  Console.WriteLine("dividend is" + num1/num2);
		  
		}
         
        }
public class ImplementInheritence
      {
     public static void Main()
     {
        MultiplynDivide obj=new MultiplynDivide();
        obj.Add(100,10);
        obj.Subtract(100,10);
		 obj.Multiply(100,10);
		 obj.Divide(100,10);
	
		
         Console.ReadLine();
       
        
        
      }
	 }