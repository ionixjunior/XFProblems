using System;

using Xamarin.Forms;

namespace Core.Views
{
	public class HomeView : ContentPage
	{
		public HomeView ()
		{
			Title = "Home";
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


