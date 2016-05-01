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
						GetSwitchCell("Habilitado", true), 
						GetSwitchCell("Desabilitado", false)
					}
				}
			};
		}

		private SwitchCell GetSwitchCell(string text, bool isEnabled)
		{
			return new SwitchCell () {
				Text = text, 
				IsEnabled = isEnabled, 
				On = true
			};
		}
	}
}


