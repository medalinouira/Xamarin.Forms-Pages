/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Xamarin.Forms;
using System.Reflection;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms_Pages.Extensions
{
    [Preserve(AllMembers = true)]
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var strAssemblyName = typeof(ImageResourceExtension).GetTypeInfo().Assembly.GetName().Name;
            var imageSource = ImageSource.FromResource($"{strAssemblyName}.Resources.{Source}");
            return imageSource;
        }
    }
}
