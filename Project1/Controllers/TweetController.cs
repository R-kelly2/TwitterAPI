using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Models;
using TwitterAnalyticsAPI.Data;

[Route("api/[controller]")]
[ApiController]
public class TweetsController : ControllerBase
{
    private readonly AppDbContext _context;

    public TweetsController(AppDbContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    [HttpGet]
    public async Task<ActionResult> GetTweets()
    {
        return Ok(await _context.Tweets.Include(t => t.User).ToArrayAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Tweet>> GetTweet(int id)
    {
        var tweet = await _context.Tweets.Include(t => t.User).FirstOrDefaultAsync(t => t.TweetId == id);

        if (tweet == null)
        {
            return NotFound();
        }

        return tweet;
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTweet(int id)
    {
        var tweet = await _context.Tweets.FindAsync(id);
        if (tweet == null)
        {
            return NotFound();
        }

        _context.Tweets.Remove(tweet);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TweetExists(int id)
    {
        return _context.Tweets.Any(e => e.TweetId == id);
    }
}

