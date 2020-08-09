Create Table Department (
  DeptNo int Primary Key,
  DeptName varchar(100) Not Null,
  Location varchar(100) Not null
)

Create Table Employee (
  EmpNo int Primary Key,
  EmpName varchar(100) Not Null,
  Designation varchar(100) Not Null,
  Salary int Not Null,
  DeptNo int Not Null  References Department(DeptNo)
)