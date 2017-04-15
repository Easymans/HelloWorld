using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			Person paschal = Init();
			BindingContext = paschal;
			InitializeComponent();
		}

		private Person Init()
		{
			return new Person
			{
				FullName = "Paschal Ihenacho",
				Phone = "(832) 641-2011",
				Email = "ihenachopaschal@yahoo.com"
			};

		}

		public void OnButtonClick(object o, EventArgs e)
		{
			Navigation.PushAsync(new Page2());
		}
	}
}
