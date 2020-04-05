using MiniFacebook.Data;
using MiniFacebook.Models.RepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoClass
{
    public class FriendRepo:IFriendRepo
    {
        private readonly ApplicationDbContext context;
        public FriendRepo(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
