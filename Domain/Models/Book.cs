using System;
namespace Domain.Models
{
	public class Book : BaseEntity
	{
		public string Author { get; set; }
		public int Page { get; set; }
	}
}

