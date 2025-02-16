using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
	/// <summary>
	/// Represents a department.
	/// </summary>
	internal class Department
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
