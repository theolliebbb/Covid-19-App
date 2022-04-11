using System;
using System.Collections.Generic;
using Covid.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class Countrybyday : ContentPage
    {
        public static Root3 prefDetails2;
        public static Timeline timeline2;
        public Countrybyday(Root3 details)
        {
            InitializeComponent();



            prefDetails2 = details;
            PopulateDetails1(prefDetails2);
            var random = new Random();
            timeline2 = details.timeline;
            /*var entries = new List<ChartEntry>();*/
            var entries = new[]
        {
            
            
            new ChartEntry(timeline2.cases._4322 - timeline2.cases._4222)
            {
                Label = "4/3/22",
                ValueLabel = $"{timeline2.cases._4322 - timeline2.cases._4222}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(timeline2.cases._4422 - timeline2.cases._4322)
            {
                Label = "4/4/22",
                ValueLabel = $"{timeline2.cases._4422 - timeline2.cases._4322}",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(timeline2.cases._4522 - timeline2.cases._4422)
            {
                Label = "4/5/22",
                ValueLabel = $"{timeline2.cases._4522 - timeline2.cases._4422}",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(timeline2.cases._4622 - timeline2.cases._4522)
            {
                Label = "4/6/22",
                ValueLabel = $"{timeline2.cases._4622 - timeline2.cases._4522}",
                Color = SKColor.Parse("#3498db")
            },
            new ChartEntry(timeline2.cases._4722 - timeline2.cases._4622)
            {
                Label = "4/7/22",
                ValueLabel = $"{timeline2.cases._4722 - timeline2.cases._4622}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(timeline2.cases._4822 - timeline2.cases._4722)
            {
                Label = "4/8/22",
                ValueLabel = $"{timeline2.cases._4822 - timeline2.cases._4722}",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(timeline2.cases._4922 - timeline2.cases._4822)
            {
                Label = "4/9/22",
                ValueLabel = $"{timeline2.cases._4922 - timeline2.cases._4822}",
                Color = SKColor.Parse("#b455b6")
            },


        };
            /*foreach (int Data in timeline2.cases)
            {
                

                entries.Add(new ChartEntry(Data.cnt_confirmed)
                {
                    Label = "",
                    Color = SKColor.Parse("#2c3e50"),
                    ValueLabel = "",
                });
            }*/
            chartViewBar.Chart = new LineChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
        }

        private void PopulateDetails1(Root3 details)
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
