using eServiceApp.Models;
using FormsControls.Base;
using Syncfusion.SfAutoComplete.XForms;
using Syncfusion.SfBusyIndicator.XForms;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutoCompletePage : AnimationPage
    {
       
        DeviceViewModel deviceViewModel = new DeviceViewModel();
        public AutoCompletePage()
        {
            
            InitializeComponent();
           
           dataGrid.ItemsSource = deviceViewModel.deviceForApprovalsObservable;

                      
            

            List<string> autoCompleteArray = new List<string>();
            autoCompleteArray.AddRange(deviceViewModel.deviceForApprovalsObservable.Select(x => x.DeviceType).Distinct());
            autoCompleteArray.AddRange(deviceViewModel.deviceForApprovalsObservable.Select(x => x.Manufucturer).Distinct());
            autoCompleteArray.AddRange(deviceViewModel.deviceForApprovalsObservable.Select(x => x.Model).Distinct());


            autocomplete.AutoCompleteSource = autoCompleteArray;


        }
        async private  void Button_Clicked(object sender, EventArgs e)
        {
                  
            await    Navigation.PopAsync();               

        }

        private void autocomplete_ValueChanged(object sender, Syncfusion.SfAutoComplete.XForms.ValueChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Value))
            {
                dataGrid.ItemsSource = deviceViewModel.deviceForApprovalsObservable.Where(x =>
                                                                                         (x.DeviceType.StartsWith(e.Value)
                                                                                         || x.Manufucturer.StartsWith(e.Value)
                                                                                         || x.Model.StartsWith(e.Value)));            }
            else 
            {                
                dataGrid.ItemsSource = deviceViewModel.deviceForApprovalsObservable;
            }                                                                                   
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            
                
                 await   Navigation.PushAsync(new WelcomPage());          
           
        }
    }
}