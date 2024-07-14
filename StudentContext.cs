using Microsoft.EntityFrameworkCore;
using Schoolinfo.Model;

namespace Schoolinfo.Data
{
    public class StudentContext:  DbContext
    {
        public StudentContext(DbContextOptions options)
        : base(options) 
        {
        }

            public DbSet<Student> Students { get; set; }
        }
}
