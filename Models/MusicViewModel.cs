namespace RapidApiAkademiq.Models
{
    public class MusicViewModel
    {
        public class Rootobject
        {
            public Tracks tracks { get; set; }
            public Albums albums { get; set; }
            public Artists1 artists { get; set; }
        }

        public class Tracks
        {
            public int totalCount { get; set; }
            public TrackItem[] items { get; set; }
        }

        public class TrackItem
        {
            public TrackData data { get; set; }
        }

        public class TrackData
        {
            public string id { get; set; }
            public string name { get; set; }
            public AlbumOfTrack albumOfTrack { get; set; }
            public Artists3 artists { get; set; }
            public Duration1 duration { get; set; }
        }

        public class AlbumOfTrack
        {
            public string name { get; set; }
            public Coverart5 coverArt { get; set; }
        }

        public class Coverart5
        {
            public Source10[] sources { get; set; }
        }

        public class Source10
        {
            public string url { get; set; }
        }

        public class Artists3
        {
            public ArtistItem[] items { get; set; }
        }

        public class ArtistItem
        {
            public Profile4 profile { get; set; }
        }

        public class Profile4
        {
            public string name { get; set; }
        }

        public class Duration1
        {
            public int totalMilliseconds { get; set; }
        }

        public class Albums { public Item[] items { get; set; } }
        public class Item { public Data data { get; set; } }
        public class Data { public string name { get; set; } public Coverart coverArt { get; set; } }
        public class Coverart { public Source[] sources { get; set; } }
        public class Source { public string url { get; set; } }

        public class Artists1 { public Item2[] items { get; set; } }
        public class Item2 { public Data1 data { get; set; } }
        public class Data1 { public Profile1 profile { get; set; } public Visuals visuals { get; set; } }
        public class Profile1 { public string name { get; set; } }
        public class Visuals { public Avatarimage avatarImage { get; set; } }
        public class Avatarimage { public Source1[] sources { get; set; } }
        public class Source1 { public string url { get; set; } }
    }
}