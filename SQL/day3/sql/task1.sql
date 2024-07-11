use company_db;

-- Display the Department id, name and id and the name of its manager.
select d.dnum , d.dname , e.fname + ' ' + e.lname as [manager name] from
departments as d left outer join  employee as e 
on d.mgrssn = e.ssn;



-- Display the name of the departments and the name of the projects under its control
select d.dname,p.pname from departments d left outer join project p
on d.dnum = p.dnum; 

-- Display the full data about all the dependence associated with the name of the employee they depend on him/her
select d.* ,e.fname + ' ' + e.lname as full_name from dependent d inner join employee e 
on d.essn = e.ssn;  


-- Display the Id, name and location of the projects in Cairo or Alex city
select pnumber,pname,plocation from project where city in ('cairo' , 'alex'); 

-- Display the Projects full data of the projects with a name starts with "a" letter
select * from project where pname like 'a%';

-- display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from employee where dno = 30 and salary between 1000 and 2000;


-- Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project
select e.fname + ' ' + e.lname from employee e inner join works_for w 
on w.essn = e.ssn inner join project p on w.pno = p.pnumber
where e.dno = 10 and w.hours >= 10 and p.pname = 'Al Rabwah';

-- Find the names of the employees who directly supervised with Kamel Mohamed.
select emp.fname + ' ' + emp.lname as full_name from employee emp, employee supervicor 
where supervicor.ssn = emp.Superssn 
and supervicor.fname + ' ' + supervicor.lname = 'Kamel Mohamed'; 

-- Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name
select e.fname + ' ' + e.lname as full_name , p.pname from employee e left outer join Works_for w
on e.ssn = w.essn left outer join project p 
on w.pno = p.pnumber order by p.pname;

-- For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate
select p.pnumber ,d.dname ,e.lname ,e.address , e.bdate from 
project p left outer join departments d on
p.pnumber = d.dnum left outer join employee e on
d.mgrssn = e.ssn where p.city = 'cairo';


-- Display All Data of the mangers
select mang.* from employee emp,employee mang 
where mang.ssn = emp.superssn; 


-- Display All Employees data and the data of their dependents even if they have no dependents
select * from employee e left outer join dependent d
on e.ssn = d.essn; 

-- Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233
insert into employee(dno,ssn,superssn) values(30,10672,112233);

-- Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or manager number to him
insert into employee(fname,lname,ssn,bdate,address,sex,dno) 
values('moaaz','osama',102660,1965-01-01,'44 Hilopolis.Cairo','male',30);--14

-- In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into departments 
values('DEPT IT',100,112233,1-11-2006);