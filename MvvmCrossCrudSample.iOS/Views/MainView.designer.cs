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
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnNavCustomersView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnNavCustomersView != null) {
                btnNavCustomersView.Dispose ();
                btnNavCustomersView = null;
            }
        }
    }
}