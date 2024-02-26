using System;
namespace HomeWorks_Const_Readonly_Access_Modifiers.Models
{
	public class Car
	{
		private string name;
		public string color;
		protected int speed=900;

		private Car()
		{
			Console.WriteLine("Fatya Hello");
		}

		public Car(int a):this()
		{

		}
	}
}

