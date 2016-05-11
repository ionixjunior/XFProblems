using System;

using Xamarin.Forms;
using Core.Views.Switch;
using Core.Views.Keyboard;
using Core.Views.UITest;
using Core.Views.Lists;
using Core.Views.MessagingCenter;
using Core.Views.ImgCell;
using Core.Views.Tabs;

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
								GetTextCell("Listas", typeof(ListsView), "tclLists", Open), 
								GetTextCell("Messaging Center", typeof(MessagingCenterView), "tclMessagingCenter", Open), 
								GetTextCell("ImageCell", typeof(ImageCellView), "tclImageCell", Open), 
								GetTextCell("Abas", typeof(TabsView), "tclTabs", OpenModal)
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

		private void OpenModal(object sender, EventArgs args)
		{
			TextCell textCell = (TextCell)sender;
			Type pageType = (Type)textCell.BindingContext;

			Page page = (Page)Activator.CreateInstance (pageType);
			Navigation.PushModalAsync (page);
		}

		private Button GetButtonUiTests()
		{
			Button button = new Button () {
				Text = "UI Tests", 
				AutomationId = "btnUiTests"
			};
			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync(new TestFormView());
			};

			return button;
		}
	}
}


