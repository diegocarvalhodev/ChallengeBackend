using ChallengeBackendApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeBackendApi.Data
{
    public class ChallengeContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }

        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {
        }
    }
}
