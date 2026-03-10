-- Join is a query that combines rows from two or more tables
--based on a related column between them. 
--It allows you to retrieve data from multiple tables in a single query
--by specifying the join condition.
select * from tbl_developers
select * from tbl_project

select d.dev_name,p.projectname from tbl_developers d,
tbl_project p where d.project_id=p.project_id

--inner join will fetch only the matching records from both tables based on the join 
--condition
-- join or inner join will give the same result
select d.dev_name,p.projectname from tbl_developers d inner join
tbl_project p on d.project_id=p.project_id

-- Outer Join
-- Left Outer Join will fetch all records from the left table
--and matching records from the right table based on the join condition
-- non matching records from the right table will have null values
select d.dev_name,p.projectname from tbl_developers d left outer join
tbl_project p on d.project_id=p.project_id

-- Right Outer Join will fetch all records from the right table
--and matching records from the left table based on the join condition
-- non matching records from the left table will have null values
select d.dev_name,p.projectname from tbl_developers d right outer join
tbl_project p on d.project_id=p.project_id

-- Full Outer Join will fetch all records from both tables
--and matching records from both tables based on the join condition
-- non matching records from both tables will have null values
select d.dev_name,p.projectname from tbl_developers d full outer join
tbl_project p on d.project_id=p.project_id


select * from tbl_developers
select * from tbl_project
select * from tbl_tasks

alter table tbl_tasks drop column project_id

select d.dev_name, p.projectname, t.task_name, t.status from tbl_tasks t
inner join tbl_developers d on t.assigned_to=d.developerid 
inner join tbl_project p on d.project_id=p.project_id order by d.dev_name

select * from tbl_developers
select * from tbl_project
select * from tbl_tasks
-- cross join will give the cartesian product of both tables
select * from tbl_developers cross join tbl_project


create table tbl_employee(empid int constraint pk_id primary key,
name varchar(20),salary int,managerid int constraint fk_managerid
foreign key references tbl_employee(empid))

insert into tbl_employee values(1,'Jyostna',50000,null),
(2,'Rinu',40000,1),
(3,'Raflan',30000,2),
(4,'Prem',20000,3),
(5,'Akhil',10000,3),
(6,'Rishika',65768,3),
(7,'Sanjay',45000,3),
(8,'Anjali',35000,4),
(9,'Vikram',25000,5),
(10,'Neha',15000,5)


select * from tbl_employee

-- selef join is a join that joins a table to itself

select e.name + '   Reports to     ' + m.name 'selfjoindemo' from tbl_employee e join tbl_employee m
on e.managerid=m.empid