use company_db;


--Display (Using Union Function)
-- The name and the gender of the dependence that's gender is Female and depending on Female Employee.
-- And the male dependence that depends on Male Employee

select d.dependent_name , d.sex from dependent d where 
d.sex = 'f' and d.sex = 
(select e.sex from employee e where d.essn = e.ssn)
union 
select d.dependent_name ,  d.sex from dependent d where
d.sex = 'm' and d.sex = (select e.sex from employee e where d.essn = e.ssn);

-- For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.pname,w.hours from project p left outer join works_for w on
w.pno = p.Pnumber;

-- Display the data of the department which has the smallest employee ID over all employees' ID.
select d.* from employee e inner join departments d on
e.dno = d.dnum where e.ssn = (select min(ssn) from employee);

-- For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.dname,max(e.salary) as maximum,min(e.salary) as minimum,avg(e.salary) as average
from departments d inner join employee e on e.dno = d.dnum 
group by d.dname;


-- List the last name of all managers who have no dependents.
select m.lname from employee m, employee e
where m.ssn = e.superssn and m.ssn not in (select essn from dependent);


-- For each department if its average salary is less than the average salary of all 
-- employees display its number, name and number of its employees
select d.dname, avg(e.salary) as [average salary] from departments d inner join employee e on
e.dno = d.dnum group by d.dname
having(avg(e.salary) < (select avg(salary) from employee));


-- Retrieve a list of employees and the projects they are working on ordered by department 
-- and within each department, ordered alphabetically by last name, first name.
select e.* , p.* from employee e left outer join works_for w
on e.ssn = w.essn left outer join project p 
on w.pno = p.pnumber left outer join departments d
on e.dno = d.dnum order by d.dname , e.lname, e.fname;


-- Try to get the max 2 salaries using subquery
select salary from (select salary,row_number() over (order by salary desc) as row_num from
employee) as ranking_rows where row_num <= 2;



-- Get the names of employees that is similar to any dependent name
select e.fname + ' ' + e.lname from employee e inner join dependent d 
on d.essn = e.ssn where difference(e.fname + ' ' + e.lname,d.dependent_name) >= 3;

-- Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), 
-- and they give you(your SSN =102672) her position (Dept. 20 manager) 

-- First try to update her record in the department table
-- Update your record to be department 20 manager.
-- Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
insert into employee values('karim','osama',102672,NULL,NULL,'m',NULL,968574,NULL);


update departments set mgrssn = 968574 where dnum = 100;

update departments set mgrssn = 102672 where dnum = 20;

update employee set superssn = 102672 where ssn = 102660;


-- Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) 
--so try to delete his data from your database in case you know that you will be temporarily in his position.
-- Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

delete from dependent where essn = 223344;

update departments set mgrssn = 102672 where mgrssn = 223344;

update employee set superssn = 102672 where superssn = 223344;

update works_for set essn = 102672 from employee e inner join works_for w

on e.ssn = w.essn where e.ssn = 223344;

delete from employee where ssn = 223344;


-- Try to update all salaries of employees who work in Project ‘AlRabwah’ by 30% 

update employee set salary = salary * 1.3 from employee e inner join works_for w
on w.essn = e.ssn inner join project p 
on w.pno = p.pnumber where p.pname = 'Al Rabwah';

