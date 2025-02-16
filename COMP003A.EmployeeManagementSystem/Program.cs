﻿// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
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
		/// <summary>
		/// New instance of Employee class.
		/// </summary>
		/// <param name="employeeId">ID of the employee.</param>
		/// <param name="firstName">First name of the employee.</param>
		/// <param name="lastName">Last name of the employee.</param>
		/// <param name="salary">Salary of the employee.</param>
		/// <param name="middleName">Middle name, if it exists, of the employee.</param>
		public Employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
		{
			_employeeId = employeeId;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			MiddleName = middleName;
		}
		/// <summary>
		/// Displays the full name of the employee.
		/// </summary>
		public void PrintFullName()
		{
			if (string.IsNullOrWhiteSpace(MiddleName))
			{
				Console.WriteLine($"Name: {FirstName} {LastName}");
			}
			else
			{
				Console.WriteLine($"Name: {FirstName} {MiddleName} {LastName}");
			}
		}
		/// <summary>
		/// Displays information about the employee to the user.
		/// </summary>
		public void DisplayEmployeeInfo()
		{
			Console.WriteLine($"Employee ID: {EmployeeId}");
			Console.WriteLine($"{PrintFullName}");
			Console.WriteLine($"Salary: {Salary:C}");
		}
		/// <summary>
		/// Represents a department using an abstract class.
		/// </summary>
		public abstract class Department
		{
			/// <summary>
			/// Receives the department name.
			/// </summary>
			public string DepartmentName { get; set; }

			/// <summary>
			/// Gets details about the department.
			/// </summary>
			/// <returns>String that has details about the department.</returns>
			public abstract string GetDepartmentDetails();

			/// <summary>
			/// Displays information about the department.
			/// </summary>
			public void DisplayDepartmentInfo()
			{
				Console.WriteLine($"Department: {DepartmentName}");
				Console.WriteLine($"Details: {GetDepartmentDetails()}");
			}
		}
	}
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
			Console.WriteLine("\nEmployee Created Successfully!");
			Console.WriteLine($"\nEmployee ID: {employeeId}");
		}
	}
}