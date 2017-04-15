using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		MainPageViewModel vm;

		public MainPage()
		{
			Person per = MainPageViewModel.GetPerson();
			vm = new MainPageViewModel(per);
			BindingContext = vm;
			InitializeComponent();
		}

		public void OnButtonClick(object o, EventArgs e)
		{
			Navigation.PushAsync(new Page2());
		}
	}
}
