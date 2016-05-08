using System;

using Xamarin.Forms;

namespace Core.Views.Tabs
{
	public class TabsView : TabbedPage
	{
		public TabsView ()
		{
			Children.Add (GetNewTab("Tab 1"));
			Children.Add (GetNewTab("Tab 2"));
			Children.Add (GetNewTab("Tab 3"));
			Children.Add (GetNewTab("Tab 4"));
			Children.Add (GetNewTab("Tab 5"));
			Children.Add (GetNewTab("Tab 6"));
		}

		private NavigationPage GetNewTab(string name)
		{
			Tab1View page = new Tab1View () {
				Title = name
			};

			NavigationPage navigationPage = new NavigationPage (page) {
				Title = name
			};

			return navigationPage;
		}
	}
}


