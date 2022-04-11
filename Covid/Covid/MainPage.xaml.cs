using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Covid.Models;
using Covid.Views;
using Newtonsoft.Json.Linq;

namespace Covid
{
    
    public partial class MainPage : ContentPage
    {
        
        public static List<Prefectures> Prefs = new List<Prefectures>();
        HttpClient client;
        
        private ObservableCollection<Prefectures> plist;
        public ObservableCollection<Prefectures> Plist
        {
            get
            {
                return plist;
            }
            set
            {
                plist = value;

            }
        }
        public string WebAPIUrlP = "http://covid19-japan-web-api.now.sh/api//v1/prefectures";
        
        public MainPage()
        {
            InitializeComponent();
            /*GetGlobalCoronaDataCommandExecution();*/
            Button_Clicked();
        }

        async Task Button_Clicked()
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://covid19-japan-web-api.vercel.app/api/v1/prefectures");
            var resultPrefectures = JsonConvert.DeserializeObject<Prefectures[]>(resultJson);
            picker.ItemsSource = resultPrefectures;
            
            var resultJson2 = await httpClient.GetStringAsync("https://corona.lmao.ninja/v2/countries?yesterday=&sort=");
            var root = JObject.Parse(resultJson2);
            var parsedObject = JObject.Parse(resultJson2);
            var popupJson = parsedObject.ToString();
            var countries = JsonConvert.DeserializeObject<Root[]>(popupJson);
           /* picker2.ItemsSource = countries;*/
        }
    
        
        private async void EditEvent(object sender, ItemTappedEventArgs e)
        {

            

        }

    

       async void picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var details = picker.SelectedItem as Prefectures;


            App.Current.MainPage = new Pref_Data(details);
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();
            var resultJson2 = await httpClient.GetStringAsync("https://covid19-japan-web-api.vercel.app/api/v1/total");

            var resultPrefectures = JsonConvert.DeserializeObject<Root>(resultJson2);
            var details = resultPrefectures;
            App.Current.MainPage = new CountryGraph(details);
        }

        async void Button_Clicked2(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();
            
            var resultJson3 = await httpClient.GetStringAsync("https://covid19.richdataservices.com/rds/api/query/int/jhu_country/select?cols=date_stamp,cnt_confirmed,cnt_death,cnt_recovered&where=(iso3166_1=JP)&format=amcharts&limit=6000");
            
            var resultBig = JsonConvert.DeserializeObject<Root2>(resultJson3);
            var details = resultBig;
            

            App.Current.MainPage = new CountryToday(details);
        }

       async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();

            var resultJson3 = await httpClient.GetStringAsync("https://corona.lmao.ninja/v2/historical/Japan?lastdays=31");

            var resultBig = JsonConvert.DeserializeObject<Root3>(resultJson3);
            var details = resultBig;


            App.Current.MainPage = new Countrybyday(details);
        }

       async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();

            var resultJson4 = await httpClient.GetStringAsync("https://corona.lmao.ninja/v2/continents?yesterday=true&sort");

            var myDeserializedClass = JsonConvert.DeserializeObject<Root4[]>(resultJson4);
            var details = myDeserializedClass;


            App.Current.MainPage = new Global(details);
        }
    }
}
            
            
   


