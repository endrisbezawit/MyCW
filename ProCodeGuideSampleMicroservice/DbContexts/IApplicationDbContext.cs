using Microsoft.EntityFrameworkCore;
using ProCodeGuideSampleMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuideSampleMicroservice.DbContexts
{
  public  interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChanges();
    }
}
