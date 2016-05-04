using System;

using Xamarin.Forms;

namespace Core.Views.Lists
{
	public class ListsView : ContentPage
	{
		public ListsView ()
		{
			Title = "Listas";

			Content = new TableView() {
				Intent = TableIntent.Menu, 
				Root = new TableRoot() {
					new TableSection() {
						new TextCell() {
							Text = "Texto", 
							Command = new Command(() => NavigateTo(typeof(List1View)))
						}, 
						new TextCell() {
							Text = "Texto e descrição", 
							Command = new Command(() => NavigateTo(typeof(List2View)))
						}, 
						new TextCell() {
							Text = "Texto, descrição e imagem", 
							Command = new Command(() => NavigateTo(typeof(List3View)))
						}, 
						new TextCell() {
							Text = "Customizado", 
							Command = new Command(() => NavigateTo(typeof(List4View)))
						}, 
						new TextCell() {
							Text = "Nativo", 
							Command = new Command(() => NavigateTo(typeof(List5View)))
						}
					}
				}
			};
		}

		private void NavigateTo(Type pageType)
		{
			Page page = (Page)Activator.CreateInstance (pageType);
			Navigation.PushAsync (page);
		}
	}
}


