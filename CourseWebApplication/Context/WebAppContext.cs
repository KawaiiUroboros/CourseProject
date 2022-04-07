using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Jwt
{
    public class WebAppContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {

        }
    }
}
