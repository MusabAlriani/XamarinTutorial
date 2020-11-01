using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eServiceApp.Models;
using eServiceApp.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using TextAlignment = Windows.UI.Xaml.TextAlignment;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRender))]
namespace eServiceApp.UWP
{
    public class CustomLabelRender : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextAlignment = TextAlignment.Justify;
            }
        }
    }
}
