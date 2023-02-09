using System;
namespace MethodOverloading
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Methods.Add(4, 12);
			Methods.Add(4.7m, 5.9m);
			Methods.Add(7, 20, false);
		}
	}
}

