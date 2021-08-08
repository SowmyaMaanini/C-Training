using System;
public class Products
{
public static void Main()
{
 string[][]proname=new string[3][];
proname[0]=new string[4]{"Dark Fantasy","Oreo","GoodDay","Bourbon"};
proname[1]=new string[5]{"Dairymilk","Twix","Munch","Kitkat","Fivestar"};
proname[2]=new string[6]{"Cococola","Sprite","Mountain dew","Red bull","Fanta","Sting"};
for(int i =0;i<proname.Length;i++)
   {
	for(int j=0;j<proname[i].Length;j++)
	Console.Write(proname[i][j] +"\t");
    Console.WriteLine();
    }
}
}