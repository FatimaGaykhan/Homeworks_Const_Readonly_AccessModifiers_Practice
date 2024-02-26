using System;
namespace HomeWorks_Const_Readonly_Access_Modifiers.Models
{
	public class Test:Car
	{
		public int bestSpeed;
		public Test():base(5)
		{
			bestSpeed = speed;
		}
	}
}

