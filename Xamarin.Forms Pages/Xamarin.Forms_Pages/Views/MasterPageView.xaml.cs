/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using Xamarin.Forms_Pages.Models;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Xamarin.Forms_Pages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageView : ContentPage
    {
        public ListView listview;
        public MasterPageView()
        {
            InitializeComponent();
            listview = MenuItemsListView;
            BindingContext = new MasterDetailPageMasterViewModel();
        }
    
        public class MasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPageViewMenuItem> MenuItems { get; set; }

            public MasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPageViewMenuItem>(new[]
                {
                    new MasterDetailPageViewMenuItem(typeof(FirstView)) { Id = 0, Title = "First View" },
                    new MasterDetailPageViewMenuItem(typeof(SecondView)) { Id = 1, Title = "Second View" },
                    new MasterDetailPageViewMenuItem(typeof(ThirdView)) { Id = 2, Title = "Third View" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}