using System;
using Xamarin.Forms;
using System.Collections.Generic;
using Core.Models;

namespace Core.Controls
{
	public class NativeListView : ListView
	{
		public static readonly BindableProperty ItemsProperty =
			BindableProperty.Create ("Items", typeof(IEnumerable<DataModel>), typeof(NativeListView), new List<DataModel> ());

		public IEnumerable<DataModel> Items {
			get { return (IEnumerable<DataModel>)GetValue (ItemsProperty); }
			set { SetValue (ItemsProperty, value); }
		}

		public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

		public void NotifyItemSelected (object item)
		{
			if (ItemSelected != null) {
				ItemSelected (this, new SelectedItemChangedEventArgs (item));
			}
		}
	}
}

