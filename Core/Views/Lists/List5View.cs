using System;

using Xamarin.Forms;
using Core.ViewModels.Lists;
using Core.Controls;

namespace Core.Views.Lists
{
	public class List5View : ContentPage
	{
		public List5View ()
		{
			Title = "Lista 5";
			ListDataViewModel listDataViewModel = new ListDataViewModel ();

			Content = new NativeListView () {
				Items = listDataViewModel.Data
			};
		}
	}
}


