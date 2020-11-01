using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace eServiceApp.MarKUpExtensions
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(resourceId))]
    class EmbededImage : IMarkupExtension
    {
     
        public string resourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                return null;
            }

            return ImageSource.FromResource(resourceId);
        }
    }
}
