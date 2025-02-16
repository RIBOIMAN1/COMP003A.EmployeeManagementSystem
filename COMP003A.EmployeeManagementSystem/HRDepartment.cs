using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
	/// <summary>
	/// HR department
	/// </summary>
	public class HRDepartment : Department, IDepartmentOperations
	{
		public HRDepartment()
		{
			DepartmentName = "Human Resources";
		}

		public override string GetDepartmentDetails()
		{
			return "Handles employee relations and recruitment.";
		}

		public void Operate()
		{
			Console.WriteLine("Performing HR operations...");
		}
	}
}