using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace Mailbox
{
    partial class TableViewController : UITableViewController
	{
		public TableViewController (IntPtr handle) : base (handle)
		{
		}

        EmailServer emailServer = new EmailServer();

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return emailServer.Email.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell(CGRect.Empty);
            var item = emailServer.Email[indexPath.Row];

            cell.TextLabel.Text = item.Subject;
            return cell;
        }
    }
}