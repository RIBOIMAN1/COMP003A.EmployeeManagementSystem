// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
	/// <summary>
	/// Question prompts asking the user employee information.
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			string employeeId = null;
			try
			{
				// Input employee details.
				Console.Write("Enter Employee ID: ");
				employeeId = Console.ReadLine();
				Console.Write("Enter First Name: ");
				string firstName = Console.ReadLine();
				Console.Write("Enter Middle Name (Press Enter to skip): ");
				string middleName = Console.ReadLine();
				Console.Write("Enter Last Name: ");
				string lastName = Console.ReadLine();
				Console.Write("Enter Salary: ");
				double salary = double.Parse(Console.ReadLine());
				/// <summary>
				/// Displays employee information to the user.
				/// </summary>
				Console.WriteLine("\nEmployee Created Successfully!");
				Employee employee = new Employee(employeeId, firstName, lastName, salary, middleName);
				employee.DisplayEmployeeInfo();
				Console.WriteLine();
				HRDepartment hrDepartment = new HRDepartment();
				ITDepartment itDepartment = new ITDepartment();
				hrDepartment.DisplayDepartmentInfo();
				hrDepartment.Operate();
				Console.WriteLine();
				itDepartment.DisplayDepartmentInfo();
				itDepartment.Operate();
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid salary format. Please enter a numeric value.");
			}
			catch (Exception)
			{
				Console.WriteLine("You have inputted an invalid input, try again.");
			}
		}
	}
}