using Foundation;
using UIKit;
using MvvmCross.Platforms.Ios.Core;

namespace MvvmCrossCrudSample.iOS
{
  [Register("AppDelegate")]
  public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<Core.App>, Core.App>
  {
  }

}
