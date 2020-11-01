using eServiceApp.Models;
using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Number14XXPage : AnimationPage
    {
        List<PhoneNumbers> list14xxNumbers;
       PhoneNumbers Number14XX = new PhoneNumbers();
        Label labelResult = new Label();
        public Number14XXPage()
        {
            InitializeComponent();
         //   image.Source = ImageSource.FromResource("eServiceApp.imgs.logo.jpg");
            list14xxNumbers = Number14XX.GetNumbers("14xx", "Number14xx", 1, 3, 8, 3);
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
              


        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string text = "", number = "14";
               number = number + searchBx.Text;
            if (searchBx.Text.Length==2)
            {
                var query = list14xxNumbers.Where(x => (x.Number14xx == (number))).ToList();
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