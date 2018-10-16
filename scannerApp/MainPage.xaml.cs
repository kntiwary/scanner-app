using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace scannerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ScanCustomPage(object sender, EventArgs e) 
        {  
            await Navigation.PushAsync(new scannerAppPage());  
        }  
        private async void GenerateBarcode(object sender, EventArgs e) 
        {  
            await Navigation.PushAsync(new QrCodePage());  
        }  
    }
}
