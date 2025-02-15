// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// Input employee details.
				Console.Write("Enter Employee ID: ");
				string employeeId = Console.ReadLine();
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
			Console.WriteLine("\nEmployee Created Successfully!");
		}
	}
	/// <summary>
	/// Showcases employee credentials to the user.
	/// </summary>
	public class Employee
	{
		private string _employeeId;
		private string _firstName;
		private string _middleName;
		private string _lastName;
		private double _salary;
		/// <summary>
		/// Gathers the input of the employee ID.
		/// </summary>
		public string EmployeeId
		{
			get { return _employeeId; }
		}
		/// <summary>
		/// Gathers the input of the employee's first name, not allowing empty or null inputs.
		/// </summary>
		/// <exception cref="ArgumentException">Exception that gets thrown whenever the input is empty or null.</exception>
		public string FirstName
		{
			get { return _firstName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("First name cannot be empty or null.");
				}
				_firstName = value;
			}
		}
		/// <summary>
		/// Gathers the input of the employee's middle name, allowing empty but not null inputs.
		/// </summary>
		public string MiddleName
		{
			get { return _middleName; }
			set { _middleName = value; }
		}
		/// <summary>
		/// Gathers the input of the employee's last name, not allowing empty or null inputs.
		/// </summary>
		/// <exception cref="ArgumentException">Exception that gets thrown whenever the input is empty or null.</exception>
		public string LastName
		{
			get { return _lastName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("First name cannot be empty or null.");
				}
				_lastName = value;
			}
		}
		/// <summary>
		/// Gathers the input of the employee's salary.
		/// </summary>
		public double Salary
		{
			get { return _salary; }
			set
			{
				if (value < 0)
				{
					Console.WriteLine("This is an invalid salary value since your salary value cannot be less than 0, try again.");
				}
			}
		}
	}
}