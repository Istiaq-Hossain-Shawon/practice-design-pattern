


using factorypattern.Factory;
using factorypattern.Product;

Employee employee= new Employee();

employee.Name="A";
employee.EmployeeType=1;
EmployeeFactory employeeFactory= new EmployeeFactory();
EmployeeManager employeeManager= employeeFactory.GetEmployeeManager(2);
employee.EmplyeeBonus=employeeManager.GetBonus();
employee.EmployeeSalary=employeeManager.GetSalary();
// if(employee.EmployeeType==1){
//     employee.EmplyeeBonus=15000;
//     employee.EmployeeSalary=employee.EmplyeeBonus*100;
// }

// if(employee.EmployeeType==2){
//     employee.EmplyeeBonus=25000;
//     employee.EmployeeSalary=employee.EmplyeeBonus*100;
// }
Console.WriteLine(employee.Name);
Console.WriteLine(employee.EmplyeeBonus);
Console.WriteLine(employee.EmployeeSalary);
public class Employee{
    public string? Name { get; set; }
    public int EmployeeType { get; set; }
    public int EmplyeeBonus{get;set;}
    public int EmployeeSalary{get;set;} 
}