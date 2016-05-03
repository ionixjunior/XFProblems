using System;

using Xamarin.Forms;
using Core.Views.Switch;
using Core.Views.Keyboard;
using Core.Views.UITest;
using Core.Views.Lists;

namespace Core.Views
{
	public class HomeView : ContentPage
	{
		public HomeView ()
		{
			Title = "Home";

			ToolbarItems.Add (new ToolbarItem() {
				Text = "Teste", 
				Command = new Command(() => { DisplayAlert("Título", "Mensagem", "Fechar"); }), 
				AutomationId = "tbiTest"
			});

			Content = new StackLayout() {
				Children = {
					new TableView() {
						Intent = TableIntent.Menu, 
						Root = new TableRoot() {
							new TableSection() {
								GetTextCell("Desabilitando SwitchCell", typeof(SwitchCellView), "tclSwitchCell", Open), 
								GetTextCell("Tipos de teclado", typeof(KeyboardTypeView), "tclKeyboardType", Open), 
								GetTextCell("Listas", typeof(ListsView), "tclLists", Open)
							}
						}
					}, 
					GetButtonUiTests()
				}
			};
		}

		private TextCell GetTextCell(string text, Type page, string automationId, EventHandler eventHandler)
		{
			TextCell textCell = new TextCell () {
				BindingContext = page, 
				Text = text, 
				AutomationId = automationId
			};
			textCell.Tapped += eventHandler;

			return textCell;
		}

		private void Open(object sender, EventArgs args)
		{
			TextCell textCell = (TextCell)sender;
			Type pageType = (Type)textCell.BindingContext;

			Page page = (Page)Activator.CreateInstance (pageType);
			Navigation.PushAsync (page);
		}

		private Button GetButtonUiTests()
		{
			Button button = new Button () {
				Text = "Para UI Tests", 
				AutomationId = "btnUiTests"
			};
			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync(new TestFormView());
			};

			return button;
		}
	}
}


