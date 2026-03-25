namespace RapidApiAkademiq.Models
{
    public class GasViewModel
    {

        public class Rootobject
        {
            public Update[] updates { get; set; }
        }

        public class Update
        {
            public string brand { get; set; }
            public string last_updated { get; set; }
            public string data_freshness { get; set; }
        }


    }
}
