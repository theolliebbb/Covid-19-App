using System;
using Newtonsoft.Json;

namespace Covid.Models
{
    public partial class Prefectures
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name_ja")]
        public string NameJa { get; set; }

        [JsonProperty("name_en")]
        public string NameEn { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("cases")]
        public long Cases { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }
    }



    public class Cases
    {
        [JsonProperty("3/11/22")]
        public int _31122 { get; set; }

        [JsonProperty("3/12/22")]
        public int _31222 { get; set; }

        [JsonProperty("3/13/22")]
        public int _31322 { get; set; }

        [JsonProperty("3/14/22")]
        public int _31422 { get; set; }

        [JsonProperty("3/15/22")]
        public int _31522 { get; set; }

        [JsonProperty("3/16/22")]
        public int _31622 { get; set; }

        [JsonProperty("3/17/22")]
        public int _31722 { get; set; }

        [JsonProperty("3/18/22")]
        public int _31822 { get; set; }

        [JsonProperty("3/19/22")]
        public int _31922 { get; set; }

        [JsonProperty("3/20/22")]
        public int _32022 { get; set; }

        [JsonProperty("3/21/22")]
        public int _32122 { get; set; }

        [JsonProperty("3/22/22")]
        public int _32222 { get; set; }

        [JsonProperty("3/23/22")]
        public int _32322 { get; set; }

        [JsonProperty("3/24/22")]
        public int _32422 { get; set; }

        [JsonProperty("3/25/22")]
        public int _32522 { get; set; }

        [JsonProperty("3/26/22")]
        public int _32622 { get; set; }

        [JsonProperty("3/27/22")]
        public int _32722 { get; set; }

        [JsonProperty("3/28/22")]
        public int _32822 { get; set; }

        [JsonProperty("3/29/22")]
        public int _32922 { get; set; }

        [JsonProperty("3/30/22")]
        public int _33022 { get; set; }

        [JsonProperty("3/31/22")]
        public int _33122 { get; set; }

        [JsonProperty("4/1/22")]
        public int _4122 { get; set; }

        [JsonProperty("4/2/22")]
        public int _4222 { get; set; }

        [JsonProperty("4/3/22")]
        public int _4322 { get; set; }

        [JsonProperty("4/4/22")]
        public int _4422 { get; set; }

        [JsonProperty("4/5/22")]
        public int _4522 { get; set; }

        [JsonProperty("4/6/22")]
        public int _4622 { get; set; }

        [JsonProperty("4/7/22")]
        public int _4722 { get; set; }

        [JsonProperty("4/8/22")]
        public int _4822 { get; set; }

        [JsonProperty("4/9/22")]
        public int _4922 { get; set; }
    }

    public class Deaths
    {
        [JsonProperty("3/11/22")]
        public int _31122 { get; set; }

        [JsonProperty("3/12/22")]
        public int _31222 { get; set; }

        [JsonProperty("3/13/22")]
        public int _31322 { get; set; }

        [JsonProperty("3/14/22")]
        public int _31422 { get; set; }

        [JsonProperty("3/15/22")]
        public int _31522 { get; set; }

        [JsonProperty("3/16/22")]
        public int _31622 { get; set; }

        [JsonProperty("3/17/22")]
        public int _31722 { get; set; }

        [JsonProperty("3/18/22")]
        public int _31822 { get; set; }

        [JsonProperty("3/19/22")]
        public int _31922 { get; set; }

        [JsonProperty("3/20/22")]
        public int _32022 { get; set; }

        [JsonProperty("3/21/22")]
        public int _32122 { get; set; }

        [JsonProperty("3/22/22")]
        public int _32222 { get; set; }

        [JsonProperty("3/23/22")]
        public int _32322 { get; set; }

        [JsonProperty("3/24/22")]
        public int _32422 { get; set; }

        [JsonProperty("3/25/22")]
        public int _32522 { get; set; }

        [JsonProperty("3/26/22")]
        public int _32622 { get; set; }

        [JsonProperty("3/27/22")]
        public int _32722 { get; set; }

        [JsonProperty("3/28/22")]
        public int _32822 { get; set; }

        [JsonProperty("3/29/22")]
        public int _32922 { get; set; }

        [JsonProperty("3/30/22")]
        public int _33022 { get; set; }

        [JsonProperty("3/31/22")]
        public int _33122 { get; set; }

        [JsonProperty("4/1/22")]
        public int _4122 { get; set; }

        [JsonProperty("4/2/22")]
        public int _4222 { get; set; }

        [JsonProperty("4/3/22")]
        public int _4322 { get; set; }

        [JsonProperty("4/4/22")]
        public int _4422 { get; set; }

        [JsonProperty("4/5/22")]
        public int _4522 { get; set; }

        [JsonProperty("4/6/22")]
        public int _4622 { get; set; }

        [JsonProperty("4/7/22")]
        public int _4722 { get; set; }

        [JsonProperty("4/8/22")]
        public int _4822 { get; set; }

        [JsonProperty("4/9/22")]
        public int _4922 { get; set; }
    }

    public class Recovered
    {
        [JsonProperty("3/11/22")]
        public int _31122 { get; set; }

        [JsonProperty("3/12/22")]
        public int _31222 { get; set; }

        [JsonProperty("3/13/22")]
        public int _31322 { get; set; }

        [JsonProperty("3/14/22")]
        public int _31422 { get; set; }

        [JsonProperty("3/15/22")]
        public int _31522 { get; set; }

        [JsonProperty("3/16/22")]
        public int _31622 { get; set; }

        [JsonProperty("3/17/22")]
        public int _31722 { get; set; }

        [JsonProperty("3/18/22")]
        public int _31822 { get; set; }

        [JsonProperty("3/19/22")]
        public int _31922 { get; set; }

        [JsonProperty("3/20/22")]
        public int _32022 { get; set; }

        [JsonProperty("3/21/22")]
        public int _32122 { get; set; }

        [JsonProperty("3/22/22")]
        public int _32222 { get; set; }

        [JsonProperty("3/23/22")]
        public int _32322 { get; set; }

        [JsonProperty("3/24/22")]
        public int _32422 { get; set; }

        [JsonProperty("3/25/22")]
        public int _32522 { get; set; }

        [JsonProperty("3/26/22")]
        public int _32622 { get; set; }

        [JsonProperty("3/27/22")]
        public int _32722 { get; set; }

        [JsonProperty("3/28/22")]
        public int _32822 { get; set; }

        [JsonProperty("3/29/22")]
        public int _32922 { get; set; }

        [JsonProperty("3/30/22")]
        public int _33022 { get; set; }

        [JsonProperty("3/31/22")]
        public int _33122 { get; set; }

        [JsonProperty("4/1/22")]
        public int _4122 { get; set; }

        [JsonProperty("4/2/22")]
        public int _4222 { get; set; }

        [JsonProperty("4/3/22")]
        public int _4322 { get; set; }

        [JsonProperty("4/4/22")]
        public int _4422 { get; set; }

        [JsonProperty("4/5/22")]
        public int _4522 { get; set; }

        [JsonProperty("4/6/22")]
        public int _4622 { get; set; }

        [JsonProperty("4/7/22")]
        public int _4722 { get; set; }

        [JsonProperty("4/8/22")]
        public int _4822 { get; set; }

        [JsonProperty("4/9/22")]
        public int _4922 { get; set; }
    }

    public class Timeline
    {
        public Cases cases { get; set; }
        public Deaths deaths { get; set; }
        public Recovered recovered { get; set; }
    }

    public class CountryInfo
    {
        public int _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public int lat { get; set; }
        public int @long { get; set; }
        public string flag { get; set; }
    }

    public class Root
    {
        public int date { get; set; }
        public long pcr { get; set; }
        public int hospitalize { get; set; }
        public int positive { get; set; }
        public int severe { get; set; }
        public int discharge { get; set; }
        public int death { get; set; }
        public int symptom_confirming { get; set; }
    }




}
