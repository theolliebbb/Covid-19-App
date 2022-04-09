using System;
using System.Collections.Generic;
using Covid.Models;
using Xamarin.Forms;

namespace Covid.Views
{
    public partial class Pref_Data : ContentPage
    {
        public Pref_Data(Prefectures details)
        {
            InitializeComponent();
            Prefectures prefDetails;
            if (details != null)
            {

                prefDetails = details;
                PopulateDetails(prefDetails);
            }
        }
        private void PopulateDetails(Prefectures details)
        {
            nameja.Text = $"{details.NameJa}県";
            nameen.Text = $"{details.NameEn} Prefecture";
            cases.Text = $"Case Count: {details.Cases.ToString()}";
            death.Text = $"Death Count: {details.Deaths.ToString()}";

            this.Title = $"{details.NameJa}　コロナデータ";
        }

        void back_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
