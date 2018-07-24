using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossCrudSample.Core.ViewModels;
using UIKit;

namespace MvvmCrossCrudSample.iOS.Views
{
    public partial class CustomersView : MvxViewController<CustomersViewModel>
    {
        public CustomersView() : base("CustomersView", null)
        {
        }
    public override void ViewDidLoad()
    {
      base.ViewDidLoad();
      //customersTableView.TableHeaderView = new UILabel() { Text = "Customers" };
      var source = new MvxStandardTableViewSource(customersTableView, UITableViewCellStyle.Subtitle, new Foundation.NSString(),"TitleText Name; DetailText Description" );
      customersTableView.Source = source;
      var set = this.CreateBindingSet<CustomersView, CustomersViewModel>();
      set.Bind(source).To(vm => vm.Customers);
      set.Apply();
      customersTableView.ReloadData();

    }
  }
}

