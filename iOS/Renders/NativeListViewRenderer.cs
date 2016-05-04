using System;
using Xamarin.Forms.Platform.iOS;
using Core.Controls;
using Xamarin.Forms;
using Core.iOS.Renders;

[assembly: ExportRenderer (typeof(NativeListView), typeof(NativeListViewRenderer))]
namespace Core.iOS.Renders
{
	public class NativeListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement != null) {
				// Unsubscribe
			}

			if (e.NewElement != null) {
				Control.Source = new NativeListViewSource (e.NewElement as NativeListView);
			}
		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			if (e.PropertyName == NativeListView.ItemsProperty.PropertyName) {
				Control.Source = new NativeListViewSource (Element as NativeListView);
			}
		}
	}
}

