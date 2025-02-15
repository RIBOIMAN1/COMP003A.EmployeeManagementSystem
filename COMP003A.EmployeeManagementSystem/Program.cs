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