using System;
using Core.Models;
using System.Collections.Generic;

namespace Core.ViewModels.Lists
{
	public class ListDataViewModel : BaseViewModel
	{
		private IList<DataModel> _data { get; set; }

		public IList<DataModel> Data
		{
			get { return _data; }
			set 
			{
				_data = value;
				INotifyPropertyChanged ();
			}
		}

		public ListDataViewModel()
		{
			Data = new List<DataModel> ();

			Data.Add (new DataModel() {
				Text = "iOS", 
				Detail = "Apple", 
				ImageName = "ios.png", 
				Version = "v9.3"
			});

			Data.Add (new DataModel() {
				Text = "Android", 
				Detail = "Google", 
				ImageName = "android.png", 
				Version = "v6.0"
			});

			Data.Add (new DataModel() {
				Text = "Windows Phone", 
				Detail = "Microsoft", 
				ImageName = "windowsphone.png", 
				Version = "v8.1"
			});
		}
	}
}

