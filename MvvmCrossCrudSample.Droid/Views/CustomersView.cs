using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCrossCrudSample.Core.ViewModels;

namespace MvvmCrossCrudSample.Droid.Views
{
  [MvxActivityPresentation]
  [Activity(Label = "View for CustomersView")]
  public class CustomersView : MvxActivity<CustomersViewModel>
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      SetContentView(Resource.Layout.CustomersView);
    }
  }
}
