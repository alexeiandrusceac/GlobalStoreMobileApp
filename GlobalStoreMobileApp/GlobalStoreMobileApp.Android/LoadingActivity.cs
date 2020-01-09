
using Android.App;
using Android.Views;
using Android.OS;


namespace GlobalStoreMobileApp.Droid
{
    [Activity(Theme ="@style/Theme.Splash", Label="Global Store", MainLauncher =true,Icon = "@drawable/Icon")]
    public class LoadingActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Window.DecorView.SystemUiVisibility =
                (StatusBarVisibility)((int)Window.DecorView.SystemUiVisibility ^ (int)SystemUiFlags.LayoutStable ^
                                       (int)SystemUiFlags.LayoutFullscreen);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            base.OnCreate(savedInstanceState);
            // Create your application here
            StartActivity(typeof(MainActivity));
        }
    }
}