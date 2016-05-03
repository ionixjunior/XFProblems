using System;

using Xamarin.Forms;
using Core.ViewModels.Lists;

namespace Core.Views.Lists
{
	public class List1View : ContentPage
	{
		public List1View ()
		{
			Title = "Lista 1";
			ListDataViewModel listDataViewModel = new ListDataViewModel ();

			Content = new ListView () {
				ItemsSource = listDataViewModel.Data, 
				ItemTemplate = new DataTemplate(() => {
					TextCell textCell = new TextCell();
					textCell.SetBinding(TextCell.TextProperty, "Text");

					return textCell;
				})
			};
		}
	}
}


