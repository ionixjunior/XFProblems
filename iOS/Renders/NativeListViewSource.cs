using System;
using System.Linq;
using System.Collections.Generic;
using Core.Models;
using Foundation;
using UIKit;
using Core.Controls;

namespace Core.iOS.Renders
{
	public class NativeListViewSource : UITableViewSource
	{
		IList<DataModel> tableItems;
		NativeListView listView;
		readonly NSString cellIdentifier = new NSString ("TableCell");

		public IEnumerable<DataModel> Items {
			//get{ }
			set {
				tableItems = value.ToList ();
			}
		}

		public NativeListViewSource (NativeListView view)
		{
			tableItems = view.Items.ToList ();
			listView = view;
		}

		/// <summary>
		/// Called by the TableView to determine how many cells to create for that particular section.
		/// </summary>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}

		#region user interaction methods

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			listView.NotifyItemSelected (tableItems [indexPath.Row]);
			Console.WriteLine ("Row " + indexPath.Row.ToString () + " selected");	
			tableView.DeselectRow (indexPath, true);
		}

		public override void RowDeselected (UITableView tableView, NSIndexPath indexPath)
		{
			Console.WriteLine ("Row " + indexPath.Row.ToString () + " deselected");	
		}

		#endregion

		/// <summary>
		/// Called by the TableView to get the actual UITableViewCell to render for the particular section and row
		/// </summary>
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// request a recycled cell to save memory
			NativeListViewCell cell = tableView.DequeueReusableCell (cellIdentifier) as NativeListViewCell;

			// if there are no cells to reuse, create a new one
			if (cell == null) {
				cell = new NativeListViewCell (cellIdentifier);
			}

			if (String.IsNullOrWhiteSpace (tableItems [indexPath.Row].ImageName)) {
				cell.UpdateCell (tableItems [indexPath.Row].Text
					, tableItems [indexPath.Row].Detail
					, tableItems [indexPath.Row].Version
					, null);
			} else {
				cell.UpdateCell (tableItems [indexPath.Row].Text
					, tableItems [indexPath.Row].Detail
					, tableItems [indexPath.Row].Version
					, UIImage.FromFile (tableItems [indexPath.Row].ImageName));
			}

			return cell;
		}
	}
}

