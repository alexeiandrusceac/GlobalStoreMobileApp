
using Android.App;
using GlobalStoreMobileApp.Interfaces;
using GlobalStoreMobileApp.Droid.Dependency;

using Xamarin.Forms;
[assembly: Dependency(typeof(CloseApplication))]
namespace GlobalStoreMobileApp.Droid.Dependency
{
    public  class CloseApplication : ICloseApplication
    {
        public void CloseApp() {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();
        }
    }
}