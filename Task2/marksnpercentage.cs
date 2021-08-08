using System;
public class marks
{
 public static void Main()
{
   int[] marks = new int[5];
   Console.WriteLine("Enter the marks:");
    for(int i=0;i<5;i++)
     {
         marks[i]=Convert.ToInt32(Console.ReadLine());
     }
     int total=0;
     for(int j=0;j<5;j++)
     {
      total=total+marks[j];
     }
      Console.WriteLine(" Total marks -{0}",total);
     
     int percent=0;
     percent=((total/500)*100);
     Console.WriteLine("Percentage-{0}%",percent);
     
}
}