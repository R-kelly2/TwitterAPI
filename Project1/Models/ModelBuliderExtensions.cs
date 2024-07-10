using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Twitter.Models
{
    public static class ModelBuliderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "Lazy_pr1", FullName = "Success", JoinDate = DateTime.Now.AddYears(-2), FollowersCount = 104 },
                new User { UserId = 2, Username = "sage", FullName = "Christabel Omo", JoinDate = DateTime.Now.AddYears(-1), FollowersCount = 29 }
            );

            modelBuilder.Entity<Tweet>().HasData(
                new Tweet { TweetId = 1, UserId = 1, Content = "Isnt it crazy how nigeria is owing so much money", PostDate = DateTime.Now.AddDays(-10), Likes = 10, Retweets = 2 },
                new Tweet { TweetId = 2, UserId = 2, Content = "dont ever sugarcoat how you feel about me, say it with your full chest", PostDate = DateTime.Now.AddDays(-5), Likes = 20, Retweets = 5 }
            );
        }
    }
}
