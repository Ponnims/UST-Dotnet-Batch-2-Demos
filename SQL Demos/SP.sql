-- Programmability 
-- Stored procedure is a precompiled collection of one or more SQL statements 
-- that can be executed as a single unit.

-- Benefits of stored procedures:
-- 1. Performance: Stored procedures are precompiled, which means that the SQL Server engine can optimize the execution plan for the procedure, resulting in faster execution times.
-- 2. Security: Stored procedures can help to improve security by allowing you to control access to the underlying data. You can grant permissions to execute the stored procedure without granting permissions to the underlying tables.
-- 3. Reusability: Stored procedures can be reused across multiple applications and can help to reduce code duplication.

-- Syntax for creating a stored procedure:
-- CREATE PROCEDURE procedure_name
-- AS
-- BEGIN
--     -- SQL statements go here
-- END

-- Example of creating a stored procedure to fetch all trainee details
create procedure usp_get_all_trainees
as
begin
	select * from tbl_trainees
end


-- execute the stored procedure
exec usp_get_all_trainees

-- Example of creating a stored procedure to fetch trainee details by stream

create proc usp_get_trainees_by_stream @stream varchar(50)
as
begin
	select * from tbl_trainees where stream=@stream
end

exec usp_get_trainees_by_stream 'Data Science'
exec usp_get_trainees_by_stream 'Web Development'

create proc usp_add_trainee @id int, @name varchar(50), @stream varchar(50), @score int
as
begin
	insert into tbl_trainees values(@id, @name, @stream, @score)
	print 'Trainee added successfully'
	
end

alter proc usp_add_trainee @id int, @name varchar(50), @stream varchar(50), @score int
as
begin
   begin try
	insert into tbl_trainees values(@id, @name, @stream, @score)
	print 'Trainee added successfully'
	end try
   begin catch
	print 'Duplicate Trainee data is not allowed'
   end catch
end



exec usp_add_trainee 11, 'Rohit', 'Data Science', 85

create proc usp_update_trainee_score @id int, @score int
as
begin
	update tbl_trainees set score=@score where traineeid=@id
	print 'Trainee score updated successfully'
end

exec usp_update_trainee_score 11, 90

create proc usp_delete_trainee @id int
as
begin
	delete from tbl_trainees where traineeid=@id
	print 'Trainee deleted successfully'
end

alter proc usp_get_trainee_count @totaltrainees int output
as
begin
	select @totaltrainees=count(*)  from tbl_trainees
end

declare @result int
exec usp_get_trainee_count @result output
--select @result as TotalTrainees
print 'Total number of trainees: ' + cast(@result as varchar(10))

-- Built-in Stored Procedure
exec sp_helptext 'usp_get_trainee_count'
exec sp_tables
exec sp_columns 'tbl_project'
