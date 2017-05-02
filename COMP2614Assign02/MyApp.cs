using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
	/// <summary>
	/// Main App entry;
	/// Krzysztof Szczurowski;
	/// Repo address: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign02.git
	/// </summary>
	class MyApp
	{
		static void Main(string[] args)
		{
			Run();
		}

		public static void Run()
		{
			Helper myHelper = new Helper();
			char answer;

			do
			{
				myHelper.printHeader();
				var inputData = myHelper.getUserInput();
				var data = myHelper.getData(inputData);
				myHelper.printFooter();
				myHelper.printResult(data);
				answer = myHelper.prompt();

			} while (answer == char.ToLower('y'));

			myHelper.exit();
			
		}
	}
}
