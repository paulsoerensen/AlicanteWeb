namespace AlicanteWeb.Models
{
    public class MatchResultViewModel
    {
        public int MatchId { get; set; }
        public bool Published { get; set; }
        public int MatchRank { get; set; }
        public DateTime MatchDate { get; set; }
        public string CourseName { get; set; }
        public int? Hcp { get; set; }
        public int Par { get; set; }
        public int Score { get; set; }
        public int Netto { get; set; }

        public int Birdies { get; set; }
        public int Par3 { get; set; }
        public decimal ScorePrice { get; set; } = 0.0m;
        public decimal BirdiePrice { get; set; } = 0.0m;
        public decimal Par3Price { get; set; } = 0.0m;
        public decimal TotalPrice => ScorePrice + BirdiePrice + Par3Price;

        public decimal Price { get; set; } = 0.0m;
        public string PlayerName { get; set; }
        public decimal HcpIndex { get; set; }
        public int Championships { get; set; } = 0;
    }
}
