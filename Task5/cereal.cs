using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

 


namespace ConsoleApp
{
[Serializable]
class cereal
{
int ID;
String Name;
String gender;
int age;
public Seria(int ID, String Name, String gender, int age)
{
this.Name = Name;
this.ID = ID;
this.gender = gender;
this.age = age;
}


public static void Main()
{
cereal sclass = new cereal(101, "Shreyas Iyer", "Male", 26);

 

FileStream fs = new FileStream("E:\\Training\\Cereal.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
BinaryFormatter byf = new BinaryFormatter();
byf.Serialize(fs, sclass);
fs.Close();

 


FileStream fr = new FileStream("E:\\Training\\Cereal.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
BinaryFormatter byr = new BinaryFormatter();

 

cereal cs = (cereal)byr.Deserialize(fr);
Console.WriteLine(cs.name);
Console.WriteLine(cs.age);
Console.WriteLine(cs.gender);
Console.WriteLine(cs.id);
fs.Close();
Console.Read();
}
}
}