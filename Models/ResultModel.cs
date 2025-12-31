namespace AlicanteWeb.Models
{
    public class ResultModel
    {
        public int ResultId { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int Hcp { get; set; }
        public int Score { get; set; }
        public int Birdies { get; set; }
        public int Par3 { get; set; }
        public decimal ScorePrice { get; set; } = 0.0m;
        public decimal BirdiePrice { get; set; } = 0.0m;
        public decimal Par3Price { get; set; } = 0.0m;
        public decimal Price { get; set; } = 0.0m;
    }
}
