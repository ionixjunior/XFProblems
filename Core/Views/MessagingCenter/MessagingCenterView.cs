using System;

using Xamarin.Forms;
using Core.Models;
using Core.ViewModels.MessagingCenter;

namespace Core.Views.MessagingCenter
{
	public class MessagingCenterView : ContentPage
	{
		private string _message { get; } = "Clicks: {0}";

		private MessagingCenterViewModel _viewModel { get; set; }

		private Label _label { get; set; }

		public MessagingCenterView ()
		{
			Title = "Messaging Center";
			_viewModel = new MessagingCenterViewModel ();

			BuildToolbarItems ();
			BuildContent ();
			SubscribeMessage ();
		}

		private void BuildToolbarItems()
		{
			ToolbarItems.Add (new ToolbarItem() {
				Text = "Update click", 
				Command = _viewModel.ClickCommand
			});
		}

		private void BuildContent()
		{
			_label = new Label () {
				HorizontalOptions = LayoutOptions.CenterAndExpand, 
				VerticalOptions = LayoutOptions.CenterAndExpand, 
				Text = string.Format(_message, _viewModel.Click.Total)
			};

			Content = new StackLayout { 
				Children = {
					_label
				}
			};
		}

		private void SubscribeMessage()
		{
			Xamarin.Forms.MessagingCenter.Subscribe<ClickModel> (this, "UpdateClicks", (sender) => {
				System.Diagnostics.Debug.WriteLine(string.Format("UpdateClicks {0}...", sender.Total));
				_label.Text = string.Format(_message, sender.Total);
			});
		}
	}
}


