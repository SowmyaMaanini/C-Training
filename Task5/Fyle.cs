using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

 

namespace ConsoleApp
{
    class Menu
    {

 


        static void Main(string[] args)
        {
            ArrayList dr = new ArrayList();
            dr.Add(" Key Lime Pie");
            dr.Add(" Lemon Cake");
            dr.Add("Cheesecake");
            dr.Add("Snickers pie");
            dr.Add("Texas chocolate cake");
            FileStream fs = new FileStream("E:\\Training\\data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter str = new StreamWriter(fs);
            foreach (var i in al)
                str.Write(i);
            str.Flush();
            str.Close();
            fs.Close();

 

            FileStream fr = new FileStream("E:\\Training\\data.txt", FileMode.Open, FileAccess.Read);
            StreamReader srr = new StreamReader(fr);
            srr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(
                srr.ReadToEnd());
            srr.Close();
            fr.Close();
            FileInfo fi = new FileInfo("E:\\Training\\data.txt");

 

            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }

 

 

    }

 

}