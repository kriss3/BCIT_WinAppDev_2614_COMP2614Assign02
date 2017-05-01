﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Run();
		}

		public static void Run()
		{
			Helper myHelper = new Helper();
			myHelper.printHeader();
			var inputData = myHelper.getUserInput();
			var data = myHelper.getData(inputData);
			myHelper.printFooter();
			myHelper.printResult(data);
		}
	}
}
