using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
	class TestClass
	{
		public void Test()
		{
			using (var fs = new FileStream("1.txt", FileMode.Open))
			using (var sr = new StreamReader(fs))
			{
				sr.ReadToEnd();
			}
		}
	}
}
