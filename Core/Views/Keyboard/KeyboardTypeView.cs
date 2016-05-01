using System;

using Xamarin.Forms;

namespace Core.Views.Keyboard
{
	public class KeyboardTypeView : ContentPage
	{
		public KeyboardTypeView ()
		{
			Title = "Tipos de teclado";

			Content = new TableView () {
				Intent = TableIntent.Form, 
				Root = new TableRoot() {
					new TableSection() {
						GetEntryCell("Texto 1", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 2", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 3", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 4", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 5", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 6", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 7", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 8", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 9", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 10", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 11", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 12", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 13", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 14", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 15", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 16", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 17", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 18", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 19", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 20", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 21", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 22", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 23", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 24", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 25", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 26", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 27", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 28", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 29", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Texto 30", Xamarin.Forms.Keyboard.Text), 
						GetEntryCell("Numérico 1", Xamarin.Forms.Keyboard.Numeric), 
						GetEntryCell("Telefone 1", Xamarin.Forms.Keyboard.Telephone), 
						GetEntryCell("E-mail 1", Xamarin.Forms.Keyboard.Email)
					}
				}
			};
		}

		private EntryCell GetEntryCell(string label, Xamarin.Forms.Keyboard keyboardType)
		{
			return new EntryCell () {
				Label = label, 
				Keyboard = keyboardType
			};
		}
	}
}


