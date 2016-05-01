using System;

using Xamarin.Forms;
using Core.Views.Switch;

namespace Core.Views
{
	public class HomeView : ContentPage
	{
		public HomeView ()
		{
			Title = "Home";

			Content = new TableView() {
				Intent = TableIntent.Menu, 
				Root = new TableRoot() {
					new TableSection() {
						GetTextCell("Desabilitando SwitchCell", typeof(SwitchCellView), Open)
					}
				}
			};
		}

		private TextCell GetTextCell(string text, Type page, EventHandler eventHandler)
		{
			TextCell textCell = new TextCell () {
				BindingContext = page, 
				Text = text
			};
			textCell.Tapped += eventHandler;

			return textCell;
		}

		private void Open(object sender, EventArgs args)
		{
			TextCell textCell = (TextCell)sender;
			Type pageType = (Type)textCell.BindingContext;

			Page page = (Page)Activator.CreateInstance (pageType);
			Navigation.PushAsync (page);
		}
	}
}


