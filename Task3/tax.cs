using System;
class Tax1
{   
   public void VAT(int amt)
     {
         double t1=0;
         t1= 0.2*amt;
         Console.WriteLine("VAT tax is {0}", t1);
         
     }

}
class Tax2 : Tax1
{   

    public void GST(int amt)
    { 
      double t2=0;
      t2= 0.12*amt;
      Console.WriteLine("GST tax is {0}",t2);


    }
class ImplementTax
    {
      public static void Main()
       {
            
            Tax2 obj = new Tax2();
            obj.VAT(100);
            obj.GST(100);

       }



    }


}