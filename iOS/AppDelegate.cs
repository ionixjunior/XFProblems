using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Core.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Xamarin.Calabash.Start ();
			global::Xamarin.Forms.Forms.Init ();

			Xamarin.Forms.Forms.ViewInitialized += (object sender, Xamarin.Forms.ViewInitializedEventArgs e) => {
				// http://developer.xamarin.com/recipes/testcloud/set-accessibilityidentifier-ios/
				if (null != e.View.StyleId) {
					e.NativeView.AccessibilityIdentifier = e.View.StyleId;
				}
			};

			LoadApplication (new App ());
			return base.FinishedLaunching (app, options);
		}
	}
}

