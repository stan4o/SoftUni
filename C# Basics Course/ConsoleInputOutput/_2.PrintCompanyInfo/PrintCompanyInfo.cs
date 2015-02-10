using System;

namespace _2.PrintCompanyInfo
{
	class PrintCompanyInfo
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter company name!");
			string companyName = Console.ReadLine ();

			Console.WriteLine ("Enter company address!");
			string companyAddress = Console.ReadLine ();

			Console.WriteLine ("Enter phone number!");
			string companyPhone = Console.ReadLine ();

			Console.WriteLine ("Enter fax number!");
			string companyFax = Console.ReadLine ();
			companyFax = (companyFax == "") ? "(no fax)" : companyFax;

			Console.WriteLine ("Enter web site!");
			string webSite = Console.ReadLine ();

			Console.WriteLine ("Enter manager's first name!");
			string managerFirstName = Console.ReadLine ();

			Console.WriteLine ("Enter manager's last name!");
			string managerLastName = Console.ReadLine ();

			Console.WriteLine ("Enter manager's age!");
			string managerAge = Console.ReadLine ();

			Console.WriteLine ("Enter manager's phone!");
			string managerPhone = Console.ReadLine ();

			Console.WriteLine ("\r\n" + companyName);
			Console.WriteLine ("Address: " + companyAddress);
			Console.WriteLine ("Telephone: " + companyPhone);
			Console.WriteLine ("Fax: " + companyFax);
			Console.WriteLine ("Web site: " + webSite);
			Console.WriteLine ("Manager: {0} {1} ({2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
		}
	}
}
