using System;
public class Campusrecruitment{
public static void Main()
{
Console.WriteLine("Enter the GPA:");
double gpa = Convert.ToDouble(Console.ReadLine());
int score1;
int score2;
int score3;
if(gpa>=7)
{
    Console.WriteLine("Eligible for Aptitute test");
    Console.WriteLine("Enter score1:");
     score1=Convert.ToInt32(Console.ReadLine());
    if(score1>=7)
    {
      Console.WriteLine("Eligible for Technical Interview");
      Console.WriteLine("Enter score2:");
       score2=Convert.ToInt32(Console.ReadLine());
       if(score2>=7)
         {
          Console.WriteLine("Eligible for HR Interview");
          Console.WriteLine("Enter score3:");
           score3=Convert.ToInt32(Console.ReadLine());
            if(score3>=7)
              {
               Console.WriteLine("Selected");
              }
              else
              {
               Console.WriteLine("Not Selected");
              }
         }
       else
        { 
         Console.WriteLine("Try after 3 months");
        }
        
      
    }
    else
    {
     Console.WriteLine("Try after six months");
    }
}
else
{
  Console.WriteLine("Not Eligible");
}


}
} 