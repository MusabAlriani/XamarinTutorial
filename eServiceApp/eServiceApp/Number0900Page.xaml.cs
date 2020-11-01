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
    public partial class Number0900Page : AnimationPage
    {
        List<PhoneNumbers> list0900Numbers;
        PhoneNumbers Number0900 = new PhoneNumbers();
        Label labelResult = new Label();
        public Number0900Page()
        {
            InitializeComponent();
            
            list0900Numbers = Number0900.GetNumbers("900yxxxxx", "Number900xxxxxx", 1, 6, 22, 6);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
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
            string text = "", number = "0900";

            number = number + searchBx.Text;

            if (searchBx.Text.Length==6)
            {
                var query = list0900Numbers.Where(x => x.Number900xxxxxx == number).ToList(); ;
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

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomPage());
        }
    }
}