using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eServiceApp.iOS;
using eServiceApp.Models;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRender))]
namespace eServiceApp.iOS
{
    class CustomLabelRender : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextAlignment = UITextAlignment.Justified;
            }
        }
    }
}