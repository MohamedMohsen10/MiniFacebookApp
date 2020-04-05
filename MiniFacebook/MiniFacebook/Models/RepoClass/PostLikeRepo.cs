using MiniFacebook.Data;
using MiniFacebook.Models.Entities;
using MiniFacebook.Models.RepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoClass
{
    public class PostLikeRepo:IPostLikeRepo
    {
        private readonly ApplicationDbContext context;
        public PostLikeRepo(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
