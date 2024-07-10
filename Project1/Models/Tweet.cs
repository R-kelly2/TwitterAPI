namespace Project1.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public int Likes { get; set; }

        public int Retweets { get; set; }
    }
}
