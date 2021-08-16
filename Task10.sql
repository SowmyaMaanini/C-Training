create table Customer(
CustomerID int primary key,
Name varchar(30),
City varchar(30),
Email varchar(50),
Phone varchar(10)
);
select*from Customer
insert into Customer values(101,'Vivek','Karimnagar','paagalvivek@gmail.com','9898989899')
insert into Customer values(102,'Karthik','Hyderabad','kartheeeeek@gmail.com','9898989898')
insert into Customer values(103,'Kaushik','Warangal','mikeychan@gmail.com','9898989897')
insert into Customer values(104,'Shilpa','Bangalore','shilpa2000@gmail.com','9898989896')
insert into Customer values(105,'Tharun','Siddipet','tharunbhasckar@gmail.com','9898989895')
insert into Customer values(106,'Upender','Khammam','uppicanon@gmail.com','9898989894')

create table Products(
ProductCode int primary key,
Name varchar(20),
Price money
)
select*from Products
insert into Products values(1234,'Munch',10)
insert into Products values(9374,'DairyMilk',160)
insert into Products values(8136,'Twix',50)
insert into Products values(7316,'Kitkat',40)
insert into Products values(7214,'Gems',30)

create table Orderr(
OrderID int primary key,
CustomerID int foreign key references Customer(CustomerID),
Orderdate  date
)
select*from Orderr
insert into Orderr values(1347,'101',getdate())
 insert into Orderr values(4562,'102',getdate())
insert into Orderr values(8493,'103',getdate())
insert into Orderr values(7446,'105',getdate())

create table orderitems(
Tno int primary key,
Orderid int foreign key references Orderr(OrderID),
productcode int foreign key references Products(ProductCode),
Quantity int
);
select*from orderitems
insert into orderitems values(1,1347,1234,10)
insert into orderitems values(2,4562,7214,20)
insert into orderitems values(3,7446,7316,15)
insert into orderitems values(4,8493,9374,5)
update Customer set Name='Shirley' where CustomerID=104
select*from Customer where CustomerID=105
SELECT*FROM Customer INNER JOIN Orderr ON Customer.CustomerID=Orderr.CustomerID
SELECT*FROM Customer  LEFT OUTER JOIN Orderr ON  Customer.CustomerID=Orderr.CustomerID
SELECT*FROM Customer  RIGHT OUTER JOIN Orderr ON  Customer.CustomerID=Orderr.CustomerID
SELECT*FROM Customer  FULL OUTER JOIN Orderr ON  Customer.CustomerID=Orderr.CustomerID


select* from Customer 
join Orderr on Customer.CustomerID=Orderr.CustomerID
 join orderitems on Orderr.OrderID=orderitems.Orderid
 join Products on orderitems.productcode=Products.ProductCode;
 select CONCAT(Orderid,productcode) AS batchnumber 
 from orderitems
 select LOWER('SHREYAS') AS lcase
 select SUBSTRING('Shreyasiyer',1,7)
 select UPPER('shreyas') AS Ucase
 select TRIM('Shreyas  Iyer')
select POWER(3,2)
select ROUND(2789.839789476,2)
select SIGN(-78)
select SQRT(225)
select MONTH('2000-06-11')
select YEAR('2000-06-11')
select SYSDATETIME();
