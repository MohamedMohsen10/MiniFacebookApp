using MiniFacebook.Data;
using MiniFacebook.Models.RepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoClass
{
    public class CommentLikeRepo:ICommentLikeRepo
    {
        private readonly ApplicationDbContext context;
        public CommentLikeRepo(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
