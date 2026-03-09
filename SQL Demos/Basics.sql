create database Db_UST_Batch2_Demos

use Db_UST_Batch2_Demos

-- Data Integrity
--1. Entity Integrity => Primary Key, Unique Key
--2. Referential Integrity
--3. Domain Integrity

-- 1. Entity Integrity

create table tbl_trainees(traineeid int, name varchar(25),stream varchar(25),score int)
insert tbl_trainees values(11,'aaa','dotnet',90)

select * from tbl_trainees

alter table tbl_trainees alter column traineeid int not null
delete from tbl_trainees
alter table tbl_trainees add constraint pk_traineeid Primary key(traineeid)

-- Referential Integrity
create table tbl_project(project_id int constraint pk_proj_id primary key,
projectname varchar(25))

insert tbl_project values(11,'ASIS'),(12,'MDU'),(13,'ELEARN'),(14,'MOBILE'),
(15,'AI'),(16,'IOT'),(17,'CYBERSECURITY'),(18,'DATA SCIENCE'),(19,'CLOUD COMPUTING'),
(20,'BLOCKCHAIN')

create table tbl_developers(developerid int constraint pk_developerid primary key,
developername varchar(25), project_id int constraint fk_proj_id foreign key references
tbl_project(project_id)	
)
drop table tbl_developers

create table tbl_developers(developerid int constraint pk_developerid primary key,
developername varchar(25), project_id int constraint fk_proj_id foreign key references
tbl_project(project_id)	on delete set null on update cascade
)


insert tbl_developers values(1,'Rinu',11),(2,'Prem',11),(3,'Raflan',12),(4,'Jyostna',15),(5,'Rishika',15),
(6,'Prabhu',16),(7,'Shabaz',17),(8,'Akil',18),(9,'Karthik',19),(10,'MSP',20),
(11,'Sathish',20),(12,'Suresh',20), (13,'Sanjay',20),(14,'Sathish',20),(15,'Suresh',20), (16,'Sanjay',20)

select * from tbl_developers
select * from tbl_project


delete from tbl_project where project_id=20

update tbl_project set project_id=151515, projectname='Artificial Intlgnce' where project_id=15

select * from tbl_trainees

insert tbl_trainees values(12,'bbb','java',80),(13,'ccc','python',85),(14,'ddd','dotnet',90),(15,'eee','java',6544487)

delete from tbl_trainees where traineeid=15
alter table tbl_trainees add constraint ck_score check(score>=0 and score<=100)

insert tbl_trainees values(15,'eee','java',99)

-- Normalization (Splitting a table into multiple tables to eliminate data redundancy and to avoid data anomalies)
-- Main Goal => To eliminate data redundancy and to avoid data anomalies
          -- => ensure data integrity and consistency

          -- Normal Forms
          -- 1NF => Atomicity of data (Each column should have atomic values, and there should be no repeating groups)
          -- 2NF => 1NF + No Partial Dependency (All non-key attributes should be fully functionally dependent on the primary key)
          -- 3NF => 2NF + No Transitive Dependency (All non-key attributes should be non-transitively dependent on the primary key)
--Upto 3NF is generally considered sufficient for most database designs, 
--although there are higher normal forms (like BCNF, 4NF, 5NF) that address more specific types of anomalies.


-- SQL Language Categories
-- 1. DDL (Data Definition Language) => create, alter, drop, truncate
-- 2. DML (Data Manipulation Language) => insert, update, delete, merge
-- 3. DCL (Data Control Language) => grant, revoke
-- 4. TCL (Transaction Control Language) => commit, rollback, savepoint
-- 5. DQL (Data Query Language) => select

select * from tbl_developers

alter table tbl_developers add  experience int, salary int

alter table tbl_developers alter column experience varchar(25)

alter table tbl_developers add constraint ck_experience check(experience in ('Fresher','1-3 years','3-5 years','5+ years'))

alter table tbl_developers add constraint ck_salary check(salary>=0)

alter table tbl_developers drop column experience

exec sp_rename 'tbl_developers.developername', 'dev_name', 'COLUMN'


create table tbl_employees(employeeid int constraint pk_employeeid primary key,
employee_name varchar(25), department varchar(25), salary int)

insert tbl_employees values(1,'Rinu','IT',50000),(2,'Prem','HR',40000),(3,'Raflan','Finance',45000),(4,'Jyostna','IT',55000),(5,'Rishika','HR',42000),
(6,'Prabhu','Finance',48000),(7,'Shabaz','IT',60000),(8,'Akil','HR',43000),(9,'Karthik','Finance',47000),(10,'MSP','IT',65000),
(11,'Sathish','HR',41000),(12,'Suresh','Finance',46000), (13,'Sanjay','IT',62000),(14,'Sathish','HR',41500),(15,'Suresh','Finance',45500), (16,'Sanjay','IT',63000)



select * into tbl_employees_regional from tbl_employees_chennai

exec sp_rename 'tbl_employees','tbl_employees_chennai'



select * from tbl_employees_chennai
select * from tbl_employees_regional

insert tbl_employees_chennai values(17,'Ramesh','IT',70000),(18,'Suresh','HR',45000),(19,'Kumar','Finance',50000)
update tbl_employees_chennai set department='IT' where employeeid in (11,12)
delete from tbl_employees_chennai where employeeid in (1,2)

merge into tbl_employees_regional t using tbl_employees_chennai s
on t.employeeid=s.employeeid
when matched then update set t.employee_name=s.employee_name, t.department=s.department, t.salary=s.salary
when not matched by target then insert values(s.employeeid, s.employee_name, s.department, s.salary)
when not matched by source then delete;