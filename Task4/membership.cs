 using System;
interface memship1
{
 void Silver();

}
interface memship2
{
   void Gold();
}
interface memship3
{
  void Platinum();
}
class Memship : memship1,memship2,memship3
{
public void Silver()
   {
       Console.WriteLine("We offer 3days accomodation at the resort");
   }
public void Gold()
   {
       Console.WriteLine("We offer 5days accomodation at the resort and 2 dinners on the house");
   }
public void Platinum()
   {
       Console.WriteLine("We offer 7days accomodation at the resort and 5 dinners on the house");
   }
}
public class Interfaceprog
{
 public static void Main()
  {
     Memship mobj = new Memship();
     mobj.Silver();
     mobj.Gold();
     mobj.Platinum();
   }

}