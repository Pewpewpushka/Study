using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_and_nullable
{
	internal class MyException : Exception
	{
		public MyException() { }

		public MyException(string message):base(message)
		{
		}
	}
}
