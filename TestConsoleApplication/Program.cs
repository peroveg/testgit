﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = new TestClass();
			test.Test();
			Console.WriteLine("Hello git hub");
			Console.WriteLine("Create new branch before close");
			Console.ReadKey();
		}
	}
}
