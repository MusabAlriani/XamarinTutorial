using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccordionGridPage : ContentPage
    {
        public AccordionGridPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;

        }

        async private void Button_Clicked_SMS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SMSNumbersPage());
        }

        async private void Button_Clicked_Number14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Number14XXPage());
        }

        async private void Button_Clicked_Number15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Number15XXPage());
        }

        async private void Button_Clicked_Number0800(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Number0800Page());
        }
        async private void Button_Clicked_Number0900(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Number0900Page());
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