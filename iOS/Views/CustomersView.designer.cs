// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmCrossCrudSample.iOS.Views
{
    [Register ("CustomersView")]
    partial class CustomersView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView customersTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (customersTableView != null) {
                customersTableView.Dispose ();
                customersTableView = null;
            }
        }
    }
}