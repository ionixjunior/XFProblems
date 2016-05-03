using System;

using Xamarin.Forms;
using Core.ViewModels.Lists;

namespace Core.Views.Lists
{
	public class List2View : ContentPage
	{
		public List2View ()
		{
			Title = "Lista 2";
			ListDataViewModel listDataViewModel = new ListDataViewModel ();

			Content = new ListView () {
				ItemsSource = listDataViewModel.Data, 
				ItemTemplate = new DataTemplate(() => {
					TextCell textCell = new TextCell();
					textCell.SetBinding(TextCell.TextProperty, "Text");
					textCell.SetBinding(TextCell.DetailProperty, "Detail");

					return textCell;
				})
			};
		}
	}
}


