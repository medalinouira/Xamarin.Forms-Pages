/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;

namespace Xamarin.Forms_Pages.Models
{
    public class MasterDetailPageViewMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }

        public MasterDetailPageViewMenuItem(Type page)
        {
            TargetType = page;
        }
    }
}
