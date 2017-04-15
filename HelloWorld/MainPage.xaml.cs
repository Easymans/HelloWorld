using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		public void OnButtonClick(object o, EventArgs e)
		{
			Navigation.PushAsync(new Page2());
		}
	}
}
