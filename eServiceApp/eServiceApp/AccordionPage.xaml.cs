using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Syncfusion.SfBusyIndicator.XForms;
using Syncfusion.XForms.Accordion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccordionPage : AnimationPage
    {
        public AccordionPage()
        {

           // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU5OTg2QDMxMzcyZTMzMmUzMFROdjlBSDFPTVp1Y2RSWUxTSm0zak9Wb3I4TW5uYnZBeTRVcVNMV3N2OWs9;MTU5OTg3QDMxMzcyZTMzMmUzMGxraDlwUUozZnVBL0Z5eDhMU0dXVmpJa3RWb1YrUkJJQmtvakNGc0ZRZmc9;MTU5OTg4QDMxMzcyZTMzMmUzMGMvTmZaOUVFcTNLb3JYdXR6Vm1nb1RnVnp1b0FTNFAyWWowdDBWU3czL2s9;MTU5OTg5QDMxMzcyZTMzMmUzMFJFYTNWa2ttajlyY2xBa2Qza1hlazF2bk55SXJMMVkwcTkxUm9acklMVkk9;MTU5OTkwQDMxMzcyZTMzMmUzME9wUVRWM2tNT3lyZDVFcFM2VzFIUU9xSnZhc1JXZTgrSmdET3RxNDlCbDg9;MTU5OTkxQDMxMzcyZTMzMmUzMFRWanpHRWVJOERvWS9ra1RseUNZTG5qZDNxcXppTzN4Y2dsWEhodGVtbWM9;MTU5OTkyQDMxMzcyZTMzMmUzMFFicDdBVGRQRk5CRDFnc0Q5M1Bzb0hMNEZVQkVUc0RVR0IxMGhSV1h1ZWs9;MTU5OTkzQDMxMzcyZTMzMmUzMEQxZDBVU3BKZFNNRjNRQm9RbWkxUkttZUtoeDg5MHY5ckZabkxldzlKSGc9;MTU5OTk0QDMxMzcyZTMzMmUzMFJFYTNWa2ttajlyY2xBa2Qza1hlazF2bk55SXJMMVkwcTkxUm9acklMVkk9;NT8mJyc2IWhiZH1gfWN9YmdoYmF8YGJ8ampqanNiYmlmamlmanMDHmg+JiAgMjF9IToyPToTOzwnPjI6P30wPD4=");
            InitializeComponent();
           
            //image.Source = ImageSource.FromResource("eServiceApp.imgs.logo.jpg");
        }

        async private void Button_Clicked_SMS(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new SMSNumbersPage());
        }

        async private void Button_Clicked_Number14(object sender, EventArgs e)
        {
         await   Navigation.PushAsync(new Number14XXPage());
        }

        async private void Button_Clicked_Number15(object sender, EventArgs e)
        {
         await   Navigation.PushAsync(new Number15XXPage());
        }

        async private void Button_Clicked_Number0800(object sender, EventArgs e)
        {
         await    Navigation.PushAsync(new Number0800Page());
        }

        async private void Button_Clicked_Number0900(object sender, EventArgs e)
        {
         await   Navigation.PushAsync(new Number0900Page());
        }

         async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomPage());
        }
    }
}