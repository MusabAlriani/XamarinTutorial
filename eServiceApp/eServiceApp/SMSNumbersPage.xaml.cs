using eServiceApp.Models;
using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Syncfusion.SfNumericTextBox.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]    
    public partial class SMSNumbersPage : AnimationPage
    {
        List<PhoneNumbers> listSMSNumbers;
        PhoneNumbers SMSNumber = new PhoneNumbers();
       
        public SMSNumbersPage()
        {
            InitializeComponent();
         
         listSMSNumbers = SMSNumber.GetNumbers("PhoneNumber","SMSNumber",1, 2, 104, 2);      

        }
       
        async private void Button_Clicked(object sender, EventArgs e)
        {           
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private void ShowText(string text,string color)
        {
            //  stackLay2.Children.Clear();


            webView.Source = new HtmlWebViewSource
            {
                Html = "<!DOCTYPE html><html><head></head><body style=\"text-align:right;font-size:15px;color:" + color + "; \" >" + text + "</body></html>"
            };
            
           
            
            //text - align - last:center;
           
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomPage());
        }



        private void searchBx_SearchButtonPressed(object sender, EventArgs e)
        {           
          
            string text = "";

            if (searchBx.Text.Length==5)
            {
                var query = listSMSNumbers.Where(x => (x.SMSNumber == (searchBx.Text)));
                if (query != null && query.Count() == 0)
                {
                    text = "." + $"الرقم {searchBx.Text} مُتاح " + $"{ SMSNumber.GetPrice(searchBx.Text) } ";
                    ShowText(text, "Green");

                }
                else
                {
                    text = "." + $"الرقم {searchBx.Text} مُخصص";
                    ShowText(text, "Red");
                } 
            }

            
        }
        
        
        
       
    }
}