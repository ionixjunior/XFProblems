using System;
using UIKit;
using Foundation;

namespace Core.iOS.Renders
{
	public class NativeListViewCell : UITableViewCell
	{
		UILabel headingLabel, subheadingLabel, versionLabel;
		UIImageView imageView;

		public NativeListViewCell (NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;

			imageView = new UIImageView ();
			headingLabel = new UILabel ();
			subheadingLabel = new UILabel ();
			versionLabel = new UILabel ();

			ContentView.Add (imageView);
			ContentView.Add (headingLabel);
			ContentView.Add (subheadingLabel);
			ContentView.Add (versionLabel);
		}

		public void UpdateCell (string caption, string subtitle, string version, UIImage image)
		{
			headingLabel.Text = caption;
			subheadingLabel.Text = subtitle;
			versionLabel.Text = version;
			imageView.Image = image;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			imageView.Frame = new CoreGraphics.CGRect (15, 5, 33, 33);
			headingLabel.Frame = new CoreGraphics.CGRect (70, 5, ContentView.Bounds.Width - 15, 20);
			subheadingLabel.Frame = new CoreGraphics.CGRect (70, 25, ContentView.Bounds.Width - 15, 20);
			versionLabel.Frame = new CoreGraphics.CGRect (ContentView.Bounds.Width - 65, 10, 100, 20);
		}
	}
}

