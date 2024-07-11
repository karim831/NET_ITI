use company_db;

select * from Employee;

select Fname,Lname,Salary,Dno from Employee;

select Pname,Plocation,Dnum from project;

select Fname + ' ' + Lname as full_name, salary * 12 * .1 as ANNUAL_COMM from Employee;

select SSN,Fname + ' ' + Lname as full_name from Employee where salary > 1000;

select SSN,Fname + ' ' + Lname as full_name from Employee where salary * 12 > 10000;

select Fname + ' ' + Lname as full_name,Salary from Employee where Sex = 'F';

select Dnum,Dname from Departments where MGRSSN = 968574;


select Pnumber,Pname,Plocation from Project where Dnum = 10;