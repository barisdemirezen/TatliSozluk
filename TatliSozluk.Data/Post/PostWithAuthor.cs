using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatliSozluk.Data.Post
{
    public class PostWithAuthor
    {
        public string Title { get; set; }
        public DateTime PostCreateDate { get; set; }
        public string AuthorNick { get; set; }
    }
}
