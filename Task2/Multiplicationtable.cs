using System;
public class multiply
{
 public static void Main()
{
   Console.WriteLine("Enter the number-");
   int num= Convert.ToInt32(Console.ReadLine());
   for(int i=1;i<=20;i++)
     {
         Console.WriteLine("{0}*{1} =" +(num*i),num,i);
     }
}
}