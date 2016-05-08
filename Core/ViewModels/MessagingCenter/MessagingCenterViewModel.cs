using System;
using Core.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace Core.ViewModels.MessagingCenter
{
	public class MessagingCenterViewModel : BaseViewModel
	{
		private ClickModel _click { get; set; }

		public ClickModel Click
		{
			get { return _click; }
			set 
			{
				_click = value;
				INotifyPropertyChanged ();
			}
		}

		public ICommand ClickCommand { get; private set; }

		public MessagingCenterViewModel()
		{
			Click = new ClickModel () {
				Total = 0
			};

			ClickCommand = new Command (() => ClickExec());
		}

		public void ClickExec()
		{
			Click.Total++;
			Xamarin.Forms.MessagingCenter.Send<ClickModel>(Click, "UpdateClicks");
		}
	}
}

