using System.Text.Json.Serialization;

namespace Project1.Models
{
    public class User
    {
            public int UserId { get; set; }

            public string Username { get; set; }

            public string FullName { get; set; }

            public DateTime JoinDate { get; set; }

            public int FollowersCount { get; set; }
         
        [JsonIgnore]
        public ICollection<Tweet> Tweets { get; set; }
        

    }
}
