using FormsControls.Base;
using Syncfusion.SfBusyIndicator.XForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eServiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomPage : AnimationPage
    {
        
        public WelcomPage()
        {
            InitializeComponent();
            //imgLocal.Source = ImageSource.FromFile("logo.jpg");
            //    image.Source = ImageSource.FromResource("eServiceApp.imgs.xamarinlogo.jpg",
            //typeof(WelcomPage).GetTypeInfo().Assembly);

            //image1.Source = ImageSource.FromResource("eServiceApp.imgs.addService.jpg");

            //image2.Source = ImageSource.FromResource("eServiceApp.imgs.xamarinlogo.jpg");

            //var assembly = typeof(WelcomPage).GetTypeInfo().Assembly;
            //foreach (var res in assembly.GetManifestResourceNames())
            //{
            //    System.Diagnostics.Debug.WriteLine("found resource: " + res);
            //}

        }
        async private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccordionGridPage());


        }

        async private void OnTapGestureRecognizerTapped2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AutoCompletePage());


        }

        
    }
}