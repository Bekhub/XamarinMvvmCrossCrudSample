using System;
using MvvmCross.ViewModels;
using MvvmCrossCrudSample.Core.ViewModels;

namespace MvvmCrossCrudSample.Core
{
  public class App : MvxApplication
    {
    public override void Initialize()
    {

      RegisterAppStart<MainViewModel>();
    }
    }
}
