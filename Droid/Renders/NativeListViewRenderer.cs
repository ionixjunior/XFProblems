using System;
using System.Linq;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Core.Controls;
using Core.Droid.Renders;

[assembly: ExportRenderer (typeof(NativeListView), typeof(NativeListViewRenderer))]
namespace Core.Droid.Renders
{
	public class NativeListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement != null) {
				// unsubscribe
				Control.ItemClick -= OnItemClick;
			}

			if (e.NewElement != null) {
				// subscribe
				Control.Adapter = new NativeListViewAdapter (Forms.Context as Android.App.Activity, e.NewElement as NativeListView);
				Control.ItemClick += OnItemClick;
			}
		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			if (e.PropertyName == NativeListView.ItemsProperty.PropertyName) {
				Control.Adapter = new NativeListViewAdapter (Forms.Context as Android.App.Activity, Element as NativeListView);
			}
		}

		void OnItemClick (object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
		{			
			((NativeListView)Element).NotifyItemSelected (((NativeListView)Element).Items.ToList () [e.Position - 1]);
		}
	}
}

