using MiniFacebook.Data;
using MiniFacebook.Models.RepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoClass
{
    public class PostRepo:IPostRepo
    {
        private readonly ApplicationDbContext context;
        public PostRepo(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
