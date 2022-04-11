using System;
using System.Collections.Generic;
using Covid.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class CountryToday : ContentPage
    {
        public int count = 0;
        public int times = 0;
        public static Root2 prefDetails1;
        public CountryToday(Root2 details)
        {
            InitializeComponent();



            prefDetails1 = details;
            PopulateDetails1(prefDetails1);
            var random = new Random();
            var entries = new List<ChartEntry>();
            foreach (var Data in details.dataProvider)
            {

                if (count != 0)
                    if (times <= 100)
                    {
                        {
                            entries.Add(new ChartEntry(Data.cnt_confirmed - count)
                            {
                                Label = "",
                                Color = SKColor.Parse("#b455b6"),
                                ValueLabel = "",
                            });

                            count = Data.cnt_confirmed;
                            times++;
                        }
                    }
                else
                    {
                        entries.Add(new ChartEntry(Data.cnt_confirmed - count)
                        {
                            Label = $"{Data.date_stamp}",
                            Color = SKColor.Parse("#b455b6"),
                            ValueLabel = $"",
                        });
                        times = 0;
                        count = Data.cnt_confirmed;
                        times++;
                    }
                    else
                    {
                        count = Data.cnt_confirmed;
                        times++;
                    }
            }
            chartViewBar.Chart = new LineChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 20, LineMode = LineMode.Straight, PointSize = 0 };
        }

        private void PopulateDetails1(Root2 details)
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
