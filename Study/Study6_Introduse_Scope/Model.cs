using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study6_Introduse_Scope
{
	public class Model : IDisposable
	{
		public Model()
		{
			Number = random.Next(0,19900);
		}

		Random random = new Random();

		public int Number { get; set; } 

		public void GetNumber()
		{
			Console.WriteLine(Number);
		}

		public void Dispose()
		{
			Console.WriteLine("экземпляр класса удален");
		}
	}
}
