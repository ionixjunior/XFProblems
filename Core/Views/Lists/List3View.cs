using System;

using Xamarin.Forms;
using Core.ViewModels.Lists;

namespace Core.Views.Lists
{
	public class List3View : ContentPage
	{
		public List3View ()
		{
			Title = "Lista 3";
			ListDataViewModel listDataViewModel = new ListDataViewModel ();

			Content = new ListView () {
				ItemsSource = listDataViewModel.Data, 
				ItemTemplate = new DataTemplate(() => {
					ImageCell imageCell = new ImageCell();
					imageCell.SetBinding(ImageCell.TextProperty, "Text");
					imageCell.SetBinding(ImageCell.DetailProperty, "Detail");
					imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImageName");

					return imageCell;
				})
			};
		}
	}
}


