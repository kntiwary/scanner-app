using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using System;
using ZXing;
using System.Threading.Tasks;

namespace scannerApp
{
    public partial class scannerAppPage : ContentPage
    {
        public scannerAppPage()
        {
            InitializeComponent();

        }

      
        protected override void OnAppearing()
        {
            zxing.IsScanning = true;
            base.OnAppearing();
        }


        private async void ZXingScannerView_OnOnScanResult(Result result)
        {  
            Device.BeginInvokeOnMainThread(async () => 
            {
                zxing.IsAnalyzing = false;  
                await DisplayAlert("", result.Text.ToString(), "OK"); 
                await Navigation.PopAsync();
            });
            

              
        }  
        private void Overlay_OnFlashButtonClicked(Button sender, EventArgs e) 
        {  
            zxing.IsTorchOn = !zxing.IsTorchOn;  
        } 
    }
}
