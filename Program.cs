// See https://aka.ms/new-console-template for more information

using EmployeePayrollService;

Console.WriteLine("Welcome to Employee Payroll!");
EmployeeRepo employeeRepo = new EmployeeRepo();
EmployeeModel employeeModel = new EmployeeModel();
employeeModel.EmployeeName = "Bruce Wayne";
employeeModel.PhoneNumber = "8524568962";
employeeModel.Address = "12th Street";
employeeModel.Department = "HR";
employeeModel.Gender = 'M';
employeeModel.BasicPay = 22000;
employeeModel.Deductions = 1500;
employeeModel.TaxablePay = 200;
employeeModel.Tax = 300;
employeeModel.NetPay = 25000;
employeeModel.StartDate = Convert.ToDateTime("2021-10-05");
employeeModel.City = "Mumbai";
employeeModel.Country = "India";

//if (repo.AddEmployee(employee))
//    Console.WriteLine("Records added successfully");
employeeRepo.GetAllEmployee();
Console.ReadKey();