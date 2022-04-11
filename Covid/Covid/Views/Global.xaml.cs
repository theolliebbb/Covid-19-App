using System;
using System.Collections.Generic;
using System.Linq;
using Covid.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class Global : ContentPage
    {
        public static Root4 prefDetails1;
        public int count;
        public List<Root4> pref;
        public Global(Root4[] details)
        {
            InitializeComponent();


            for (int i = 0; i < 10; i++)
            {
                prefDetails1.Add(details[i]);
            }
           
        
            
            


            var entries = new[]
         {
            new ChartEntry(prefDetails1.todayDeaths)
            {
                Label = "Deaths Today",
                ValueLabel = $"{prefDetails1.todayDeaths}",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(prefDetails1.cases)
            {
                Label = "Cases Today",
                ValueLabel = $"{prefDetails1.cases}",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(prefDetails1.tests)
            {
                Label = "Tests",
                ValueLabel = $"{prefDetails1.tests}",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(prefDetails1.todayRecovered)
            {
                Label = "Recovered Today",
                ValueLabel = $"{prefDetails1.todayRecovered}",
                Color = SKColor.Parse("#3498db")
            },
      



        };
            chartViewBar.Chart = new BarChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
        }

        
        void back_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
