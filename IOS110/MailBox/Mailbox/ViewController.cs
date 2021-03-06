﻿using System;

using UIKit;

namespace Mailbox
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        UITableView tableView;

        EmailServerDataSource dataSource;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            Add(tableView = new UITableView(this.View.Frame));

            tableView.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Top,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.TopMargin, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Left,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Left, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Width,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Width, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Height,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Height, 1, 0));

            tableView.Source = dataSource = new EmailServerDataSource(this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

