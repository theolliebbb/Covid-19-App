using System;
using System.Collections.Generic;
using Covid.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class Pref_Data : ContentPage
    {
        public static Prefectures prefDetails;
        public Pref_Data(Prefectures details)
        {
            InitializeComponent();
            
         

                prefDetails = details;
                PopulateDetails(prefDetails);
            
           var entries = new[]
        {
            new ChartEntry(prefDetails.Cases)
            {
                Label = "Cases",
                ValueLabel = $"{prefDetails.Cases}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails.Deaths)
            {
                Label = "Deaths",
                ValueLabel = $"{prefDetails.Deaths}",
                Color = SKColor.Parse("#77d065")
            },
            
        };
        chartViewBar.Chart = new BarChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
        }
        
        private void PopulateDetails(Prefectures details)
        {
            nameja.Text = $"{details.NameJa}県";
            nameen.Text = $"{details.NameEn} Prefecture";
            /*cases.Text = $"Case Count: {details.Cases.ToString()}";
            death.Text = $"Death Count: {details.Deaths.ToString()}";*/

            this.Title = $"{details.NameJa}　コロナデータ";
        }

        void back_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
