create database PayRollService

create table employee_payroll
(
EmployeeID int Identity,
EmployeeName varchar(255),
PhoneNumber varchar(255),
Address varchar(255),
Department varchar(255),
Gender char,
BasicPay float,
Deductions float,
TaxablePay float,
Tax float,
NetPay float,
StartDate DateTime,
City varchar(255),
Country varchar(255)
)

select * from employee_payroll