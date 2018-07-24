using System;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCrossCrudSample.Core.ViewModels
{
  public class MainViewModel : MvxViewModel
    {
    public MainViewModel()
    {
      NavigateToCustomersViewCommand = new MvxCommand(
        () => NavigationService.Navigate<CustomersViewModel>());
    }
    public MvxCommand NavigateToCustomersViewCommand
    {
      get;
      set;
    }

    }
}
