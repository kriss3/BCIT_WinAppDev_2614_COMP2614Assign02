using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// RegEx source: http://stackoverflow.com/questions/14942602/c-validation-for-us-or-canadian-zip-code
/// </summary>
namespace COMP2614Assign02
{
	/// <summary>
	/// Krzysztf Szczurowski
	/// Helper method wrapping all functionl logic of this small app
	/// repo address: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign02.git
	/// </summary>
	public class Helper
	{
		#region Public Methods
		public string getUserInput()
		{
			StringBuilder sb = new StringBuilder();
			Console.Write($"{"First Name:\t"}");
			var fName = Console.ReadLine().Trim() + "|";
			sb.Append(fName);
			Console.Write($"{"Last Name:\t"}",5);
			var lName = Console.ReadLine() + "|";
			sb.Append(lName);
			Console.Write("Address:\t");
			var address = Console.ReadLine() + "|";
			sb.Append(address);
			Console.Write("City:\t\t");
			var city = Console.ReadLine() + "|";
			sb.Append(city);
			Console.Write("Province:\t");
			var province = Console.ReadLine() + "|";
			sb.Append(province);

			var pc = String.Empty;
			do
			{
				Console.Write("Post Code:\t");
				pc = Console.ReadLine();

			} while (!isValidPostCode(pc.ToUpper()));

			sb.Append(pc);
			
			return sb.ToString();
		}

		public void printHeader()
		{
			Console.Clear();
			Console.WriteLine("Contact Information\n------------------------------");
		}

		public void printFooter()
		{
			Console.WriteLine("\nContacts\n------------------------------");
		}

		public List<Contact> getData(string contact)
		{
			var contacts = new List<Contact>();
			var details = contact.Split('|');

			Contact c = new Contact();

			c.FirstName = details[0];
			c.LastName = details[1];
			c.Address = details[2];
			c.City = details[3];
			c.Province = details[4];
			c.PostalCode = details[5];

			contacts.Add(c);

			c = new Contact(details[0], details[1], details[2], details[3], details[4], details[5]);

			contacts.Add(c);

			c  = new Contact
			{
				FirstName = details[0],
				LastName = details[1],
				Address = details[2],
				City = details[3],
				Province = details[4],
				PostalCode = details[5]
			};

			contacts.Add(c);
	
			return contacts;
		}

		public void printResult(List<Contact> data)
		{
			if (data != null)
			{
				foreach (var contact in data)
				{
					PrintContact(contact);
					Console.WriteLine();
				}

			}
			else
			{
				Console.WriteLine("Something went wrong, data empty");
			}
		}

		public char prompt()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Would you like to try again? [Y/N]: ");
			Console.ForegroundColor = ConsoleColor.Gray;
			return Char.ToLower(Console.ReadKey().KeyChar);
		}

		public void exit()
		{
			Console.Clear();
			Console.WriteLine("\nThank you! Press any key to exit.");
			Console.ReadLine();
		}

		#endregion

		#region Private Methods
		private void PrintContact(Contact c)
		{
			if (c != null)
			{
				Console.WriteLine($"{c.FirstName} {c.LastName}");
				Console.WriteLine(c.Address);
				Console.WriteLine($"{c.City} {c.Province.ToUpper()}  {c.PostalCode.ToUpper()}");
			}
			else
			{
				Console.WriteLine("Something went wrong, input data empty");
			}
			
		}
		
		private bool isValidPostCode(string pc)
		{
			bool foundMatch = false;
			string cadRegEx =  @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
			try
			{
				if (Regex.IsMatch(pc, cadRegEx))
				{
					foundMatch = true;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"Incorrect Canadian Post Code: \"{pc}\". Make sure Post code is valid and in format: A1A 1A1 or A1A1A1.");
					Console.ForegroundColor = ConsoleColor.Gray;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Incorrect Canadian Post Code.\n{ex.Message}");
			}

			return foundMatch;
		}
		
		#endregion
	}
}