using Xamarin.Forms;

//using TypeLocator = GlobalStoreMobileApp.MockDataService.TypeLocator;
namespace GlobalStoreMobileApp
{
    public partial class App : Application
    {
        public static bool MockDataService = true;
        public App()
        {
            InitializeComponent();

            /*if (MockDataService)
            {
                TypeLocator.Start();
                MainPage = new NavigationPage(new OnBoardingAnimationPage());
            }
            else
            {
                ListenNetworkChanges();
                if (!SQLiteDatabase.Shared.Initialized) SQLiteDatabase.Shared.Init();

                DataService.TypeLocator.Start();
                MapperConfig.Config();
                GetUserInfo();
            }*/
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
