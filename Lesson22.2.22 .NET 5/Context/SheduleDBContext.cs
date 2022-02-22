using lesson22._2._22.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lesson22._2._22_.NET_5.Models
{
    public class SheduleDBContext:DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Shedule> Shedules { get; set; }
        public SheduleDBContext(DbContextOptions<SheduleDBContext> options) :base (options)
        {
            Database.EnsureCreated();
        }
    }
}
