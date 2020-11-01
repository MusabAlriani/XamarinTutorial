using eServiceApp.Models;
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
    public partial class Number15XXPage : AnimationPage
    {
        List<PhoneNumbers> list15xxNumbers;
        PhoneNumbers Number15XX = new PhoneNumbers();
        Label labelResult = new Label();

        public Number15XXPage()
        {
            InitializeComponent();
            
            list15xxNumbers = Number15XX.GetNumbers("15xx", "Number15xx", 1, 4, 8, 4);
        }
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomPage());
        }


        

        private void ShowText(string text, string color)
        {
            //  stackLay2.Children.Clear();


            webView.Source = new HtmlWebViewSource
            {
                Html = "<!DOCTYPE html><html><head></head><body style=\"text-align:right;font-size:15px;color:" + color + "; \" >" + text + "</body></html>"
            };



            //text - align - last:center;

        }
        private void searchBx_SearchButtonPressed(object sender, EventArgs e)
        {
            string text = "",number="15";
            
            number = number+  searchBx.Text;

            if (searchBx.Text.Length == 2)
            {
                var query = list15xxNumbers.Where(x => (x.Number15xx == (number))).ToList(); ;
                if (query != null && query.Count() == 0)
                {
                    text = "." + $"الرقم {number} مُتاح  ";
                    ShowText(text, "Green");

                }
                else
                {
                    text = "." + $"الرقم {number} مُخصص";
                    ShowText(text, "Red");
                } 
            }
        }
    }
}