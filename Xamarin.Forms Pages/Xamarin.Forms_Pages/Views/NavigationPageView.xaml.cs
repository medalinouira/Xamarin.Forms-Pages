/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms_Pages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
          
            btnNavigateToFirstPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new FirstView()));
            btnNavigateToSecondPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new SecondView()));
            btnNavigateToThirdPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new ThirdView()));
        }
    }
}