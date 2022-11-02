using TatliSozluk.Data.Post;
using TatliSozluk.Domain.Models;

namespace TatlıSozluk.Models
{
    public class HomeViewModel
    {
        public List<Post> TrendingPosts { get; set; }
        public List<PostWithAuthor> LastPosts { get; set; }
    }
}
