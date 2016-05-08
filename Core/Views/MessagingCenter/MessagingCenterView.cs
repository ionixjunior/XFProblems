using System;

using Xamarin.Forms;
using Core.Models;

namespace Core.Views.MessagingCenter
{
	public class MessagingCenterView : ContentPage
	{
		private ClickModel _click { get; set; }

		public ClickModel Click
		{
			get 
			{
				if (_click == null) 
				{
					_click = new ClickModel () {
						Total = 0
					};
				}

				return _click;
			}
			set 
			{
				_click = value;
			}
		}

		private string _message { get; } = "Clicks: {0}";

		public MessagingCenterView ()
		{
			Title = "Messaging Center";

			ToolbarItems.Add (new ToolbarItem() {
				Text = "Update click", 
				Command = new Command(() => { 
					Click.Total++;
					Xamarin.Forms.MessagingCenter.Send<ClickModel>(Click, "UpdateClicks");
				})
			});

			Label label = new Label () {
				HorizontalOptions = LayoutOptions.CenterAndExpand, 
				VerticalOptions = LayoutOptions.CenterAndExpand, 
				Text = string.Format(_message, Click.Total)
			};

			Content = new StackLayout { 
				Children = {
					label
				}
			};

			Xamarin.Forms.MessagingCenter.Subscribe<ClickModel> (this, "UpdateClicks", (sender) => {
				System.Diagnostics.Debug.WriteLine(string.Format("UpdateClicks {0}...", sender.Total));
				label.Text = string.Format(_message, sender.Total);
			});
		}
	}
}


