using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
	public delegate void Message();
	public class Event
	{
		int num1;

		public event Message Event1;
		public void CallEvent()
		{
			if (num1 % 2 == 0)
			{
				Console.WriteLine("Number is Even");
			}
		}
		public static void EventHandler()
		{
			Console.WriteLine("Number is odd");	
		}
	}
}
