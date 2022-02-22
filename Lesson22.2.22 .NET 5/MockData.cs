using lesson22._2._22.Models;
using Lesson22._2._22_.NET_5.Models;
using System;
using System.Linq;

namespace Lesson22._2._22_.NET_5
{
    public static class MockData
    {
        public static void Initialize(SheduleDBContext dbcontext)
        {
            if (!dbcontext.Lessons.Any())
            {
                dbcontext.Lessons.AddRange(
                    new Lesson
                    {
                        Name = "Java",
                        During = DateTime.Now
                    },
                    new Lesson
                    {
                        Name = ".NET",
                        During = DateTime.Now
                    },
                    new Lesson { Name = "Js", During = DateTime.Now });
                dbcontext.SaveChanges();
            }
        }
    }
}
