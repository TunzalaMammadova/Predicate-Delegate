using System;
namespace Domain.Models
{
	public class Person : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public decimal Salary { get; set; }
	}
}

