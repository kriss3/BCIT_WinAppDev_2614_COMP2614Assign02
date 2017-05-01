using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
	public class Contact
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string PostalCode { get; set; }


		public Contact()
		{
		}

		public Contact(string firstName, string lastName, string address, string city, string province, string postCode)
		{
			FirstName = firstName;
			LastName = lastName;
			Address = address;
			City = city;
			Province = province;
			PostalCode = postCode;
		}

	}
}
