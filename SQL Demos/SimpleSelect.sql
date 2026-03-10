create table tbl_tasks (
	taskid int constraint pk_taskid primary key,
	task_name varchar(255),
	project_id int constraint fk_projid FOREIGN KEY REFERENCES tbl_project(project_id) ,
	assigned_to int constraint fk_devid FOREIGN KEY REFERENCES tbl_developers(developerid),
	status varchar(50),
	due_date date
);

insert into tbl_tasks (taskid, task_name, project_id, assigned_to, status, due_date) values
(1, 'Design Database Schema', 11, 1, 'In Progress', '2024-07-15'),
(2, 'Develop API Endpoints', 12, 2, 'Not Started', '2024-08-01'),
(3, 'Create Frontend UI', 14, 3, 'Not Started', '2024-08-15'),
(4, 'Write Unit Tests', 13, 4, 'Not Started', '2024-08-30'),
(5, 'Deploy to Production', 11, 5, 'Not Started', '2024-09-15'),
(6, 'Conduct Code Review', 12, 1, 'Not Started', '2024-07-30'),
(7, 'Optimize Database Queries', 14, 2, 'Not Started', '2024-08-20'),
(8, 'Implement Authentication', 13, 3, 'Not Started', '2024-09-05'),
(9, 'Set Up CI/CD Pipeline', 11, 4, 'Not Started', '2024-09-25'),
(10, 'Monitor Application Performance', 151515, 5, 'Not Started', '2024-10-10'),
(11, 'Conduct User Acceptance Testing', 18, 1, 'Not Started', '2024-10-20'),
(12, 'Fix Bugs Identified in Testing', 19, 2, 'Not Started', '2026-11-01'),
(13, 'Update Documentation', 18, 3, 'Not Started', '2024-11-15'),
(14, 'Plan Next Phase of Development', 17, 4, 'Not Started', '2024-12-01'),
(15, 'Conduct Retrospective Meeting', 16, 5, 'Not Started', '2024-12-15'),
(16, 'Research New Technologies', 151515, 1, 'Not Started', '2025-01-10'),
(17, 'Implement New Features', 14, 2, 'Not Started', '2025-01-25'),
(18, 'Refactor Codebase', 13, 3, 'Not Started', '2025-02-10'),
(19, 'Conduct Performance Testing', 12, 4, 'Not Started', '2025-02-25'),
(20, 'Plan Product Roadmap', 11, 5, 'Not Started', '2025-03-10');


select * from tbl_tasks;
select * from tbl_developers
select * from tbl_project

-- Different SQL select Queries to retrieve data from a single table using different conditions and filters
-- 1. Retrieve specific columns from the tbl_tasks table
SELECT task_name, status FROM tbl_tasks;
-- 2. Retrieve all tasks that are currently 'Not Started'
SELECT * FROM tbl_tasks WHERE status = 'Not Started';
SeLECT * FROM tbl_tasks WHERE status = 'In Progress';

select * from tbl_trainees
-- 3. Retrieve trainees with a score greater than 80
SELECT * FROM tbl_trainees WHERE score > 80;
SeLECT * FROM tbl_trainees WHERE score between 80 and 100;
-- 4. Retrieve tasks that are due in the next 30 days
select getdate()
select dateadd(day,30,getdate())
SELECT * FROM tbl_tasks WHERE due_date >= dateadd(day, 30, getdate());
select DATEDIFF(year, '2003-08-28', getdate())

-- 5. Retrieve developers with more than 5 years of experience
select * from tbl_developers where experience > 5

select * from tbl_tasks where task_name like 'C%'
select * from tbl_tasks where task_name like '%Code%'

select * from tbl_project where projectname like '_a%'

-- 6. Retrieve tasks assigned to a specific developer (e.g., developerid = 1)
SELECT * FROM tbl_tasks WHERE assigned_to = 1;

select * from tbl_tasks where project_id =11 or status = 'In Progress'

select * from tbl_tasks where project_id in (11,12,13) and status = 'Not Started'
select * from tbl_tasks where project_id not in (11,12,13)

select COUNT(*) as TotalTasks from tbl_tasks
select * from tbl_trainees
select MAX(score) as HighestScore from tbl_trainees
select MIN(score) as LowestScore from tbl_trainees
select AVG(score) as AverageScore from tbl_trainees
select SUM(score) as TotalScore from tbl_trainees

select * from tbl_trainees

delete from tbl_trainees 
insert into tbl_trainees (traineeid, name, stream, score) values
(1, 'Alice', 'Data Science', 85),
(2, 'Bob', 'Web Development', 78),
(3, 'Charlie', 'Mobile Development', 92),
(4, 'David', 'Data Science', 88),
(5, 'Eve', 'Web Development', 95),
(6, 'Frank', 'Mobile Development', 80),
(7, 'Grace', 'Data Science', 90),
(8, 'Heidi', 'Web Development', 82),
(9, 'Ivan', 'Mobile Development', 87),
(10, 'Judy', 'Data Science', 91),
(11, 'Karl', 'Web Development', 79),
(12, 'Leo', 'Mobile Development', 84),
(13, 'Mallory', 'Data Science', 89),
(14, 'Nina', 'Web Development', 94),
(15, 'Oscar', 'Mobile Development', 81),
(16, 'Peggy', 'Data Science', 86),
(17, 'Quentin', 'Web Development', 77),
(18, 'Ruth', 'Mobile Development', 88),
(19, 'Sam', 'Data Science', 90),
(20, 'Trudy', 'Web Development', 83),
(21, 'Uma', 'Mobile Development', 85),
(22, 'Victor', 'Data Science', 87),
(23, 'Wendy', 'Web Development', 99),
(24, 'Xavier', 'Mobile Development', 82),
(25, 'Yvonne', 'Data Science', 88),
(26, 'Zack', 'Web Development', 100),
(27, 'Amy', 'Mobile Development', 79),
(28, 'Brian', 'Data Science', 91),
(29, 'Cathy', 'Web Development', 84),
(30, 'Derek', 'Mobile Development', 86);


select max(score) as HighestScore from tbl_trainees 
select max(score) from tbl_trainees where stream = 'Data Science'
select max(score) from tbl_trainees where stream = 'Web Development'
select max(score) from tbl_trainees where stream = 'Mobile Development'

select stream,max(score) 'MaxScore' from tbl_trainees group by stream
select stream,min(score) 'MaxScore' from tbl_trainees group by stream having min(score) > 80

select * from tbl_trainees order by score desc

-- The order of the clauses in a SQL query is as follows:
-- 1. SELECT: Specifies the columns to be retrieved.
-- 2. FROM: Specifies the table(s) from which to retrieve the data.
-- 3. WHERE: Filters the rows based on specified conditions.
-- 4. GROUP BY: Groups the rows based on specified columns.
-- 5. HAVING: Filters the groups based on specified conditions.
-- 6. ORDER BY: Sorts the result set based on specified columns.
