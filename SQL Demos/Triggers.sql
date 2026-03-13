-- Trigger
-- It is a special type of stored procedure that automatically executes
-- when a specific event occurs in the database.

-- event can be insert, update, delete operations on a table or view.
-- timing can be AFTER, INSTEAD OF
-- On an Obect can be a table or view

--syntax:
-- create trigger trigger_name on table_name
-- after insert, update, delete
-- as
-- begin
--     -- SQL statements go here
-- end

create trigger trg_after_insert_trainee on tbl_trainees
after insert
as
begin
	print 'A new trainee has been added to the database.'
end

insert into tbl_trainees values(112, 'Sneha', 'Web Development', 88)

-- we have 2 importnt tables in triggers
-- 1. inserted: It is a virtual table/Dummy table/conceptual table that holds the new data that is being
--inserted into the table.
-- 2. deleted: It is a virtual table/Dummy table/conceptual table that holds the old data that is being 
--deleted from the table.
-- these tables can be used in the trigger to perform operations based on the data that is being inserted, updated, or deleted.
select * from tbl_project

alter trigger trg_after_insert_project on tbl_project
after insert, update, delete
as
begin
 select * from inserted
 select * from deleted
end

insert into tbl_project values(45, 'AI INtegration')
delete from tbl_project where project_id=45

update tbl_project set projectname='MALAYSIAN PROJ' where project_id=11

create trigger trg_after_insert_employee on tbl_employee
after insert
as
begin
	declare @empname varchar(50)
	select @empname = name from inserted
	print 'A new employee named ' + @empname + ' has been added to the database.'
end

insert into tbl_employee values(104, 'Krishna', 35000, 2)

alter trigger trg_after_insert_employee on tbl_employee
after insert
as
begin
     declare @empid int
	 select @empid = empid from inserted
	insert employee_audit values(@empid,'INSERT',getdate())
end

create table employee_audit(empid int, action varchar(50), action_date datetime)
select * from employee_audit

-- to prevent some actions on the table we can use instead of trigger

create trigger trg_instead_of_delete_employee on tbl_employee
instead of delete
as
begin
	print 'Delete operation is not allowed on tbl_employee table.'
end

delete from tbl_employee where empid=104