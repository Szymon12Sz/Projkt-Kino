using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy_Kino.Data.Base;
using Udemy_Kino.Models;

namespace Udemy_Kino.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context) : base(context) { }

    }
}
