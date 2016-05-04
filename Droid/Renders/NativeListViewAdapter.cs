using System;
using System.Linq;
using Android.Widget;
using Core.Models;
using Android.App;
using System.Collections.Generic;
using Core.Controls;
using Android.Views;
using Android.Graphics.Drawables;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.Android;

namespace Core.Droid.Renders
{
	public class NativeListViewAdapter : BaseAdapter<DataModel>
	{
		readonly Activity context;
		IList<DataModel> tableItems = new List<DataModel> ();

		public IEnumerable<DataModel> Items {
			set { 
				tableItems = value.ToList ();
			}
		}

		public NativeListViewAdapter (Activity context, NativeListView view)
		{
			this.context = context;
			tableItems = view.Items.ToList ();
		}

		public override DataModel this [int position] {
			get { 
				return tableItems [position];
			}
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override int Count {
			get { return tableItems.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = tableItems [position];

			var view = convertView;
			if (view == null) {
				// no view to re-use, create new
				view = context.LayoutInflater.Inflate (Resource.Layout.NativeListViewCell, null);
			}
			view.FindViewById<TextView> (Resource.Id.Text1).Text = item.Text;
			view.FindViewById<TextView> (Resource.Id.Text2).Text = item.Detail;
			view.FindViewById<TextView> (Resource.Id.Text3).Text = item.Version;

			// grab the old image and dispose of it
			if (view.FindViewById<ImageView> (Resource.Id.Image).Drawable != null) {
				using (var image = view.FindViewById<ImageView> (Resource.Id.Image).Drawable as BitmapDrawable) {
					if (image != null) {
						if (image.Bitmap != null) {
							//image.Bitmap.Recycle ();
							image.Bitmap.Dispose ();
						}
					}
				}
			}

			// If a new image is required, display it
			if (!String.IsNullOrWhiteSpace (item.ImageName)) {
				context.Resources.GetBitmapAsync (item.ImageName).ContinueWith ((t) => {
					var bitmap = t.Result;
					if (bitmap != null) {
						view.FindViewById<ImageView> (Resource.Id.Image).SetImageBitmap (bitmap);
						bitmap.Dispose ();
					}
				}, TaskScheduler.FromCurrentSynchronizationContext ());
			} else {
				// clear the image
				view.FindViewById<ImageView> (Resource.Id.Image).SetImageBitmap (null);
			}

			return view;
		}
	}
}

