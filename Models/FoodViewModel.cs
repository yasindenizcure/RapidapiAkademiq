namespace RapidApiAkademiq.Models
{
    public class FoodViewModel
    {
        public class Rootobject
        {
            public int count { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string thumbnail_url { get; set; }

            // Süre bilgileri
            public int? cook_time_minutes { get; set; }
            public int? prep_time_minutes { get; set; }
            public int? total_time_minutes { get; set; }

            // Alt Modeller
            public Instruction[] instructions { get; set; }
            public Section[] sections { get; set; } // Malzemeler burada
            public User_Ratings user_ratings { get; set; }
            public Nutrition nutrition { get; set; }
            public Price price { get; set; }
        }

        public class User_Ratings
        {
            public int count_positive { get; set; }
            public float score { get; set; }
        }

        public class Nutrition
        {
            public int? calories { get; set; }
            public int? carbohydrates { get; set; }
            public int? fat { get; set; }
            public int? protein { get; set; }
        }

        public class Price
        {
            public decimal? total { get; set; }
            public decimal? portion { get; set; }
        }

        public class Instruction
        {
            public string display_text { get; set; }
            public int position { get; set; }
        }

        public class Section
        {
            public Component[] components { get; set; } // Malzeme satırları
            public string name { get; set; } // "Sos için", "Hamur için" gibi başlıklar
        }

        public class Component
        {
            public string raw_text { get; set; } // Örn: "2 adet yumurta"
        }
    }
}