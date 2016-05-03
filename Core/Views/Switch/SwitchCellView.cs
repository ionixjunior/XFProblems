using System;

using Xamarin.Forms;

namespace Core.Views.Switch
{
	public class SwitchCellView : ContentPage
	{
		public SwitchCellView ()
		{
			Title = "SwitchCell";

			Content = new TableView() {
				Root = new TableRoot() {
					new TableSection() {
						GetSwitchCell("Habilitado", true, "sclEnabled"), 
						GetSwitchCell("Desabilitado", false, "sclDisabled")
					}
				}
			};
		}

		private SwitchCell GetSwitchCell(string text, bool isEnabled, string automationId)
		{
			return new SwitchCell () {
				Text = text, 
				IsEnabled = isEnabled, 
				AutomationId = automationId, 
				On = true
			};
		}
	}
}


