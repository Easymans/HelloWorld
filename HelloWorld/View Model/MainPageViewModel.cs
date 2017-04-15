using System;
namespace HelloWorld
{
	public class MainPageViewModel
	{
		public MainPageViewModel(Person person){
			FullName = person.FirstName + " " + person.LastName;
			Email = person.Email;
			Phone = person.Phone;
			Age = ComputeAge(person.Birthday);
		}

		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }

		private int ComputeAge(DateTime birthday){
			return 21;
		}

		// Get person from web service
		public static Person GetPerson()
		{
			var person = new Person()
			{
				FirstName = "Paschal",
				LastName = "Ihenacho",
				Email = "ihenachopaschal@yahoo.com",
				Phone = "(832) 641-2011",
				Birthday = new DateTime(1989, 03, 05),
				Id = 123
			};
			return person;
		}
	}
}
