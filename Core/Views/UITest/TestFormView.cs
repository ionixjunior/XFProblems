using System;

using Xamarin.Forms;

namespace Core.Views.UITest
{
	public class TestFormView : ContentPage
	{
		public TestFormView ()
		{
			Content = new StackLayout() { 
				Children = {
					new Label() { Text = "Label 1" }, 
					new Entry() { AutomationId = "etr1" }, 
					new Label() { Text = "Label 2" }, 
					new Entry() { AutomationId = "etr2" }
				}
			};
		}
	}
}


