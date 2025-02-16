using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
					throw new ArgumentException("This is an invalid salary value since your salary value cannot be less than 0, try again.");
				}
				_salary = value;
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
			PrintFullName();
			Console.WriteLine($"Salary: {Salary:C}");
		}
		/// <summary>
		/// Represents a department using an abstract class.
		/// </summary>
	}
}