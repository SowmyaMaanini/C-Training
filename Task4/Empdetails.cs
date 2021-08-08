using System;
class EmpDetails
{
public int EmpID;
public String EmpName;
public String gender; 
public int exp;
public int salary;
public EmpDetails(int ID, String name, String gen,int yof,int sal)
{
EmpID=ID;
EmpName=name;
gender=gen;
exp=yof;
salary=sal;
}
}
class EmpDept
{
double bonus=0;
String depart;
public EmpDetails edobj;
public EmpDept(String dept,EmpDetails empDetails)
{
depart=dept;
edobj = empDetails;
if(depart=="SM"){
    bonus=0.2*edobj.salary;
}
if(depart=="PD")
    bonus=0.1*edobj.salary;
}
public void Display()
{
Console.WriteLine($"Employee ID : {edobj.EmpID} ,Employee Name :{edobj.EmpName}, Gender:{edobj.gender}, Experience:{edobj.exp} Salary :{edobj.salary} and Bonus is : {bonus}");
}
public static void Main()
{
EmpDetails adj = new EmpDetails(1001,"Shreyas","Male" , 3,1000);
EmpDept eobj = new EmpDept("PD", adj);
eobj.Display();
}

 

}