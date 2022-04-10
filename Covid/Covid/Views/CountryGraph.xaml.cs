using System;
using System.Collections.Generic;
using Covid.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class CountryGraph : ContentPage
    {
        public static Root prefDetails1;
        public CountryGraph(Root details)
        {
            InitializeComponent();



            prefDetails1 = details;
            PopulateDetails1(prefDetails1);

            var entries = new[]
         {
            new ChartEntry(prefDetails1.death)
            {
                Label = "Deaths",
                ValueLabel = $"{prefDetails1.death}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.discharge)
            {
                Label = "Discharges",
                ValueLabel = $"{prefDetails1.discharge}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.hospitalize)
            {
                Label = "Hospitalized",
                ValueLabel = $"{prefDetails1.hospitalize}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.pcr)
            {
                Label = "Pcr Tests",
                ValueLabel = $"{prefDetails1.pcr}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.positive)
            {
                Label = "Cases",
                ValueLabel = $"{prefDetails1.positive}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.severe)
            {
                Label = "Severe Cases",
                ValueLabel = $"{prefDetails1.severe}",
                Color = SKColor.Parse("#2c3e50")
            },
    
            

        };
            chartViewBar.Chart = new BarChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
        }

        private void PopulateDetails1(Root details)
        {
            /*nameja.Text = $"{details.NameJa}県";
            nameen.Text = $"{details.NameEn} Prefecture";
            /*cases.Text = $"Case Count: {details.Cases.ToString()}";
            death.Text = $"Death Count: {details.Deaths.ToString()}";*/

           /* this.Title = $"{details.NameJa}　コロナデータ";*/
        }

        void back_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
