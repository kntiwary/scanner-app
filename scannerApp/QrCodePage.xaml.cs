using System;
using System.Collections.Generic;
using ZXing;
using Xamarin.Forms;

namespace scannerApp
{
    public partial class QrCodePage : ContentPage
    {
        public QrCodePage()
        {
            InitializeComponent();
            generator.BarcodeOptions.Height = 50;
            generator.BarcodeOptions.Width = 50;
        }


    }
}
