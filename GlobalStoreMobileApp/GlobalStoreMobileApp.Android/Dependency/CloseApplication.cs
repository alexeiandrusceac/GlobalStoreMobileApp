
using Android.App;
using GlobalStoreMobileApp.Droid.Dependency;
using GlobalStoreMobileApp.Interfaces;
using Xamarin.Forms;
[assembly: Dependency(typeof(CloseApplication))]
namespace GlobalStoreMobileApp.Droid.Dependency
{
    public  class CloseApplication : ICloseApplication
    {
        public void CloseApp() {
            /*var activity = (Activity)Forms.Context;
            activity.FinishAffinity();*/
        }
    }
}