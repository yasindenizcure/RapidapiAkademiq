namespace RapidApiAkademiq.Models
{
    public class YoutubeViewModel
    {

        public class Rootobject
        {
            public float duration { get; set; }
            public string status { get; set; }
            public int filesize { get; set; }
            public int progress { get; set; }
            public int pc { get; set; }
            public string title { get; set; }
            public string msg { get; set; }
            public string link { get; set; }
        }

    }
}
