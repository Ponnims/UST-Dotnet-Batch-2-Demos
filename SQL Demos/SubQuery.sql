select * from tbl_employee where salary> 30000


-- Subquery is a query that is nested inside another query.
--It is used to retrieve data that will be used in the main query
--as a condition to filter the data.
select * from tbl_employee where salary>
(select salary from tbl_employee where name='Anjali')

select * from tbl_employee  where salary=
(select max(salary) from tbl_employee)

select * from tbl_developers
select * from tbl_project

select * from tbl_developers where project_id=
(select project_id from tbl_project where projectname='cybersecurity')

-- single row subquery will return only one row and one column
-- so we can use it in the where clause with operators like =, >, <, >=, <=

-- multi row subquery will return multiple rows and one column
-- so we can use it in the where clause with operators like in, not in, any, all

select * from tbl_employee where salary not in
(select salary from tbl_employee where managerid=3)

select * from tbl_developers

select * from tbl_trainees

-- correlated subquery is a subquery that references a column from the outer query
-- it is executed for each row of the outer query
-- Fetch the trainees whose score is greater the avg score in their stream

select name, stream, score from tbl_trainees m where score> 
(select avg(s.score) from tbl_trainees s where s.stream=m.stream) 

select avg(score) from tbl_trainees where stream='Web Development'

create index idx_stream_score on tbl_trainees(stream, score)

exec sp_helpindex 'tbl_trainees'