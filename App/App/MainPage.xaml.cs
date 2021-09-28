using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        AppLinkEntry _appLink;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _appLink = new AppLinkEntry
            {
                AppLinkUri = new Uri(string.Format(App.AppLinkUri)),
                Thumbnail = ImageSource.FromFile("Xamagon.png"),
                Description = string.Format($"This is item {0}"),
                Title = string.Format($"Item {0}"),
                IsLinkActive = true
            };

            Application.Current.AppLinks.RegisterLink(_appLink);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            _appLink.IsLinkActive = false;
            Application.Current.AppLinks.RegisterLink(_appLink);
        }
    }
}
