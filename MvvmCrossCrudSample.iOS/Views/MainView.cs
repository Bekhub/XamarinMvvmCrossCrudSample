using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossCrudSample.Core.ViewModels;
using UIKit;

namespace MvvmCrossCrudSample.iOS.Views
{
  [MvxRootPresentation(WrapInNavigationController = true)]
  public partial class MainView : MvxViewController
  {
    public MainView() : base("MainView", null)
    {
    }

    public override void ViewDidLoad()
    {
      base.ViewDidLoad();

      var set = this.CreateBindingSet<MainView, MainViewModel>();

      set.Bind(btnNavCustomersView).To(vm => vm.NavigateToCustomersViewCommand);
      set.Apply();
    }
  }
}

