using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatliSozluk.Data.Post;
using TatliSozluk.Domain.Context;
using TatliSozluk.Domain.Models;

namespace TatliSozluk.Service.PostServices
{
    public class PostService : IPostService
    {
        private readonly Context _context;
        public PostService(Context context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAll()
        {
            return await _context.Post.Where(e => e.CreateDate > DateTime.Now.AddDays(-30)).Take(10).ToListAsync();
        }

        public async Task<List<PostWithAuthor>> GetLastPosts()
        {
            return await _context.Post.Where(e => e.CreateDate > DateTime.Now.AddDays(-30)).Take(10).Include(e => e.Author).Select(e => new PostWithAuthor
            {
                AuthorNick = e.Author.NickName,
                PostCreateDate = e.CreateDate,
                Title = e.Title
            }).ToListAsync();
        }
    }

    public interface IPostService
    {
        Task<List<Post>> GetAll();
        Task<List<PostWithAuthor>> GetLastPosts();
    }
}
