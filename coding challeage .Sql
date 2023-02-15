
/*create database Biodata;
   --creating table department
  create table Department(
      [Id] int PRIMARY key,
      [Name] varchar(20),
      [Location] varchar(15)
  )
    ---creating table employee
   create table Employee(
       [Id] int Primary key,
       [FirstName] varchar(10),
       [LastName] varchar(10),
       [SSN] bigint,
       [DeptId] INT,
       FOREIGN key (DeptId) REFERENCES Department(Id)
          )
        ---  creating table  empdetails
          create table EmpDetails(
              [Id] int Primary KEY ,
              [EmpId] int Unique,
              [Salary] int,
              [Address1] varchar(50),
              [Address2] varchar(40),
              [City] varchar(10),
              [State] varchar(10),
              [Country] varchar(10)
              FOREIGN key (Id) REFERENCES Employee(Id)
          )
       ---inserting values into department
    insert into Department Values (
        1,'electrical','hyderabad'
    ),(2,'mechanical','chennai'),(3,'electonics','andhrapradesh'),(4,'civil','benglore')
       ---inserting values into employee
   insert into Employee values (
       1,'raghu','vamshi',31351543855,1
   ),(2,'sai','krishna',534273584957,2),(3,'bhanu','prakash',6586374746663,3),(
       4,'surya','prakash',76259484774466,4
   )
        ---inserting values into emodetails
    insert into EmpDetails values (
        1,23,30000,'shaikpet','manikonda','hyderabad','Telangana','India'
    ),(2,11,2000,'banaganapalli','vijaywada','kurnool','AP','India'),
    (3,13,10000,'nandhyal','goa','kurnool','AP','India'),
    (4,14,20000,'guntur','kurnool','guntur','AP','India' )


         --inserting tina department values
     insert into Department values(
         5,'Marketing','america'
     )
        --inserting tina employee values
     insert into Employee values (
         5,'Tina','Smith',6543875,5
     )
         --inserting tina empdetails values
      insert into EmpDetails values (
          5,26,40000,'chicago','wahington','chicago','chicago','America'
      ) 
     --checking
         select*from[dbo].[Department];
         select*from[dbo].[Employee];
          select*from[dbo].[EmpDetails];

        alter table Employee
        add Constraint [UK_EmployeeSSN]
        Unique(SSN);

            --all  employee from marketing 
            select FirstName,LastName,Department.Name
            from Employee inner join Department on 
            Employee.DeptId=Department.Id where Department.Name='Marketing';
           
            --total salary of marketing

         select SUM (e.Salary) 
         as totalSalary from EmpDetails as e inner join Employee as s on e.Id=s.Id
             inner join Department as d on 
            s.Id=d.Id  where d.Name='Marketing'; 

           -- total employees by department
            select count(*) as 'Total Employees', Department.Name from Employee 
            inner join Department on 
             Employee.DeptId=Department.Id group by Department.Name;

 --increasing salary of tina smith to 90000
 
update Empdetails
 set salary = 90000 
 from EmpDetails as e  
inner join Employee as s 
on e.Id=s.Id where s.FirstName = 'Tina';*/
          
         


































