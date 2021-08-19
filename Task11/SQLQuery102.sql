create table Candidate(
Code int primary key,
Name char(20),
DOJ Date, 
);
insert into Candidate values(1001,'S.Raman','1997-06-12')
insert into Candidate values(1002,'M.Sushil','1997-11-12')
insert into Candidate values(1003,'Mohan','1997-07-30')
select*from Candidate
update Candidate set Name='R.Krishnan' where Code=1001; 
drop table Candidate