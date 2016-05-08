using System;

using Xamarin.Forms;

namespace Core.Views.Tabs
{
	public class Tab2View : ContentPage
	{
		public Tab2View ()
		{
			Title = "Tab 2";

			Content = new StackLayout { 
				Children = {
					new Label() { 
						Text = "Exibindo próxima página", 
						HorizontalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}


