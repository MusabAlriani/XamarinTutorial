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
    public partial class Number0800Page : AnimationPage
    {
        List<PhoneNumbers> list0800Numbers;
        PhoneNumbers Number0800 = new PhoneNumbers();
        Label labelResult = new Label();
        public Number0800Page()
        {
            InitializeComponent();
            
            list0800Numbers = Number0800.GetNumbers("800xxxxxx", "Number800xxxxxx", 1, 5, 3, 5);
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomPage());
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
            string text = "", number = "0800";

            number = number + searchBx.Text;

            if (searchBx.Text.Length == 6)
            {
                var query = list0800Numbers.Where(x => x.Number800xxxxxx == number).ToList(); ;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}