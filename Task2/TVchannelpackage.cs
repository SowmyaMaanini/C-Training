using System;
public class Tvpackage
{ 
  public static void Main()
 {
  string pack;
  Console.WriteLine("Enter the package-");
  pack= Console.ReadLine();
  switch(pack)
{
 case "A": Console.WriteLine("Rate=Rs.250");
         break;
 case "B": Console.WriteLine("Rate=Rs.450");
         break;
 case "C": Console.WriteLine("Rate=Rs.350");
         break;
 default: Console.WriteLine("Please select a valid package");
         break;




}

 }
}
