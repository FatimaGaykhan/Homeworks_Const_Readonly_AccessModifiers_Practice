 using System;
namespace HomeWorks_Const_Readonly_Access_Modifiers.Models
{
	public class Book:BaseEntity
	{
		public const string title="Fatima";
		public readonly string author;

		public Book()
		{
			author = "sagol"; 
		}
	}
}

