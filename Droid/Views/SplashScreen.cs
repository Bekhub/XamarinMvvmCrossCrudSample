using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using MvvmCrossCrudSample.Droid;

namespace MvvmCrossCrudSample
{
  [Activity(
    Label = "MvvmCrossCrudSample"
      , MainLauncher = true
      , NoHistory = true
      , ScreenOrientation = ScreenOrientation.Portrait)]
  public class SplashScreen : MvxSplashScreenActivity
  {
    public SplashScreen()
         : base(Resource.Layout.SplashScreen)
    {
    }
  }
}