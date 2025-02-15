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
				employeeInfo employee = new employeeInfo();
				employee.employeeId = "34IG";
				employee.firstName = "Riley";
				employee.middleName = "Scott";
				employee.lastName = "Benson";
				employee.salary = 75000;

				// Input employee details.
				Console.Write("Enter Employee ID: ");
				employee.employeeId = int.Parse(employee.employeeId);
			}
			catch (Exception)
			{
				Console.WriteLine("You have inputted an invalid input, try again.");

			}
		}
		/// <summary>
		/// Showcases employee credentials to the user.
		/// </summary>
	}
	public class employeeInfo
	{
		private string _employeeId;
		private string _firstName;
		private string _middleName;
		private string _lastName;
		private double _salary;

		public string EmployeeId
		{
			get { return _employeeId; }
		}
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		public string MiddleName
		{
			get { return _middleName; }
			set { _middleName = value; }
		}
		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
		public double Salary
		{
			get { return _salary; }
			set
			{
				if (value < 0)
				{
					Console.WriteLine("This is an invalid salary value, try again.");
				}
			}
		}
	}
}