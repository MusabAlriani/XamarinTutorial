using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eServiceApp.Services;
using eServiceApp.Views;
using FormsControls.Base;

namespace eServiceApp
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
  

     Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU5OTg2QDMxMzcyZTMzMmUzMFROdjlBSDFPTVp1Y2RSWUxTSm0zak9Wb3I4TW5uYnZBeTRVcVNMV3N2OWs9;MTU5OTg3QDMxMzcyZTMzMmUzMGxraDlwUUozZnVBL0Z5eDhMU0dXVmpJa3RWb1YrUkJJQmtvakNGc0ZRZmc9;MTU5OTg4QDMxMzcyZTMzMmUzMGMvTmZaOUVFcTNLb3JYdXR6Vm1nb1RnVnp1b0FTNFAyWWowdDBWU3czL2s9;MTU5OTg5QDMxMzcyZTMzMmUzMFJFYTNWa2ttajlyY2xBa2Qza1hlazF2bk55SXJMMVkwcTkxUm9acklMVkk9;MTU5OTkwQDMxMzcyZTMzMmUzME9wUVRWM2tNT3lyZDVFcFM2VzFIUU9xSnZhc1JXZTgrSmdET3RxNDlCbDg9;MTU5OTkxQDMxMzcyZTMzMmUzMFRWanpHRWVJOERvWS9ra1RseUNZTG5qZDNxcXppTzN4Y2dsWEhodGVtbWM9;MTU5OTkyQDMxMzcyZTMzMmUzMFFicDdBVGRQRk5CRDFnc0Q5M1Bzb0hMNEZVQkVUc0RVR0IxMGhSV1h1ZWs9;MTU5OTkzQDMxMzcyZTMzMmUzMEQxZDBVU3BKZFNNRjNRQm9RbWkxUkttZUtoeDg5MHY5ckZabkxldzlKSGc9;MTU5OTk0QDMxMzcyZTMzMmUzMFJFYTNWa2ttajlyY2xBa2Qza1hlazF2bk55SXJMMVkwcTkxUm9acklMVkk9;NT8mJyc2IWhiZH1gfWN9YmdoYmF8YGJ8ampqanNiYmlmamlmanMDHmg+JiAgMjF9IToyPToTOzwnPjI6P30wPD4=");
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();
            
            MainPage = new AnimationNavigationPage(new WelcomPage());
            
             
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
