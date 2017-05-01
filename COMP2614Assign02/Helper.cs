using System;
using System.Collections.Generic;
using System.Text;

namespace COMP2614Assign02
{
	public class Helper
	{
		public enum Province
		{
			Alberta,	// = "AB",
			BC,			//British Columbia,// = "BC",
			MB,			//"Manitoba" = "MB",
			NB,			//"New Brunswick"= "NB",
			NL,			//"Newfoundland and Labrador"= "NL",
			NT,			//"Northwest Territories"= "NT",
			NS,			// "Nova Scotia"= "NS",
			NU,			//"Nunavut"= "NU",
			ON,			//"Ontario"= "ON",
			PE,			//"Prince Edward Island"= "PE",
			QC,			//"Québec"= "QC",
			SK,			//"Saskatchewan"= "SK",
			YT			// "Yukon Territory"= "YT"
		}

		public string getUserInput()
		{
			StringBuilder sb = new StringBuilder();
			Console.Write($"{"First Name:\t"}");
			sb.Append(Console.ReadLine() + "|");
			Console.Write($"{"Last Name:\t"}",5);
			sb.Append(Console.ReadLine() + "|");
			Console.Write("Address:\t");
			sb.Append(Console.ReadLine() + "|");
			Console.Write("City:\t\t");
			sb.Append(Console.ReadLine() + "|");
			Console.Write("Province:\t");
			sb.Append(Console.ReadLine() + "|");
			Console.Write("Post Code:\t");
			sb.Append(Console.ReadLine());
			return sb.ToString();
		}


		public void printHeader()
		{
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
			Console.ReadLine();
		}

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
	}
}