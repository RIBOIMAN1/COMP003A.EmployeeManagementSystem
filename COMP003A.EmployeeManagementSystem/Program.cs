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
				Console.Write("Enter Middle Name: ");
				string middleName = Console.ReadLine();
				Console.Write("Enter Last Name: ");
				string lastName = Console.ReadLine();
				Console.Write("Enter Salary: ");
				double salary = double.Parse(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("You have inputted an invalid input, try again.");
			}
			/// <summary>
			/// Displays employee information to the user.
			/// </summary>
			Console.WriteLine("\nEmployee Created Successfully!");
			Console.WriteLine($"\nEmployee ID: {employeeId}");
		}
	}
}