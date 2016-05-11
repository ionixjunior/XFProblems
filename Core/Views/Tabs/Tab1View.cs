using System;

using Xamarin.Forms;

namespace Core.Views.Tabs
{
	public class Tab1View : ContentPage
	{
		public Tab1View ()
		{
			Title = "Tab 1";

			ToolbarItems.Add (new ToolbarItem() {
				Text = "Fechar", 
				Command = new Command(async () => { await Navigation.PopModalAsync(); })
			});

			Content = new StackLayout { 
				Children = {
					new Button () {
						Text = "Próxima página", 
						HeightRequest = 100, 
						BackgroundColor = Color.Gray, 
						TextColor = Color.White, 
						Command = new Command(async () => { await Navigation.PushAsync(new Tab2View()); })
					}
				}
			};
		}
	}
}


