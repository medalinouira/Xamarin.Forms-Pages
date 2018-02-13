/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms_Pages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
    
            btnTabbedPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new TabbedPageView()));
            btnContentPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new ContentPageView()));
            btnCarouselPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new CarouselPageView()));
            btnTemplatedPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new TemplatedPageView()));
            btnNavigationPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new NavigationPageView()));
            btnMasterDetailPage.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new MasterDetailPageView()));
        }
    }
}