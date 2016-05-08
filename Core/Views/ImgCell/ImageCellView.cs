using System;

using Xamarin.Forms;

namespace Core.Views.ImgCell
{
	public class ImageCellView : ContentPage
	{
		public ImageCellView ()
		{
			Title = "Image Cell";

			Content = new TableView () {
				Intent = TableIntent.Menu, 
				Root = new TableRoot() {
					new TableSection("Legenda") {
						GetImageCell("Localização atual", "current_location.png"), 
						GetImageCell("Mapa", "map.png"), 
						GetImageCell("Tempo de espera", "waiting_time.png")
					}
				}
			};
		}

		private ImageCell GetImageCell(string text, string icon) 
		{
			return new ImageCell () {
				Text = text, 
				ImageSource = icon
			};
		}
	}
}


