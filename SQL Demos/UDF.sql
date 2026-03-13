-- User Defined Functions
-- Which is similar to the methods in programming languages.
--It is a reusable code that can be called from other queries or stored procedures. 
--It can take parameters and return data or value.
-- Rule : A user-defined function must return a value. 
--It can return a scalar value, a table, or a table variable.
-- It cannot modify the database state, 
--which means it cannot perform insert, update, delete operations on the tables.

-- Functions can be used in the select statement, where clause, join clause, order by clause, etc.
-- 2 types of user defined functions:
-- 1. Scalar functions: It returns a single value of any data type.
-- 2. Table-valued functions: It returns a table data type.

select * from tbl_trainees

alter function ufn_get_trainee_count_by_stream(@stream varchar(50))
returns int
as
begin
  declare @count int
 --   set @count = 0
	--set @count = @count + 1
	select @count = count(*) from tbl_trainees where stream = @stream
	return @count
end

select dbo.ufn_get_trainee_count_by_stream('Data Science') as Data_Science_Trainee_Count

select dbo.ufn_get_trainee_count_by_stream('Web Development') as Web_Development_Trainee_Count

select distinct stream,dbo.ufn_get_trainee_count_by_stream(stream) from tbl_trainees

-- table valued function
create function ufn_get_trainees_by_stream(@stream varchar(25))
returns table
as
return(select * from tbl_trainees where stream=@stream)

select * from dbo.ufn_get_trainees_by_stream('Data Science')







create schema UST


create table UST.tbl_sample
(
id int, name varchar(50)
	
)

	


