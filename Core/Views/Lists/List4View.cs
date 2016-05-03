using System;

using Xamarin.Forms;
using Core.ViewModels.Lists;

namespace Core.Views.Lists
{
	public class List4View : ContentPage
	{
		public List4View ()
		{
			Title = "Lista 4";
			ListDataViewModel listDataViewModel = new ListDataViewModel ();

			Content = new ListView () {
				HasUnevenRows = true, 
				ItemsSource = listDataViewModel.Data, 
				ItemTemplate = new DataTemplate(() => {
					Label text = new Label();
					text.SetBinding(Label.TextProperty, "Text");

					Label detail = new Label();
					detail.SetBinding(Label.TextProperty, "Detail");

					Label version = new Label();
					version.SetBinding(Label.TextProperty, "Version");

					Image image = new Image();
					image.HorizontalOptions = LayoutOptions.Start;
					image.SetBinding(Image.SourceProperty, "ImageName");

					return new ViewCell() {
						View = new StackLayout() {
							Padding = new Thickness(15, 5, 15, 5), 
							Orientation = StackOrientation.Horizontal, 
							Children = {
								image, 
								new StackLayout() {
									HorizontalOptions = LayoutOptions.FillAndExpand, 
									Children = {
										text, 
										detail
									}
								}, 
								new StackLayout() {
									HorizontalOptions = LayoutOptions.End, 
									VerticalOptions = LayoutOptions.Center, 
									Children = {
										version
									}
								}
							}
						}
					};
				})
			};
		}
	}
}


