namespace RapidApiAkademiq.Models
{
    public class FootballViewModel
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public string competition_cluster { get; set; }
            public string prediction { get; set; }
            public string status { get; set; }
            public string federation { get; set; }
            public bool is_expired { get; set; }
            public int id { get; set; }
            public string season { get; set; }
            public string result { get; set; }
            public DateTime start_date { get; set; }
            public DateTime last_update_at { get; set; }
            public string home_team { get; set; }
            public string competition_name { get; set; }
            public string away_team { get; set; }
            public string market { get; set; }
            public Odds odds { get; set; }
        }

        public class Odds
        {
            public float _1 { get; set; }
            public float _2 { get; set; }
            public float _12 { get; set; }
            public float X { get; set; }
            public float _1X { get; set; }
            public float X2 { get; set; }
        }


    }
}
