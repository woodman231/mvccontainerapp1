using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApplication.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public virtual DbSet<Item> Items {get; set;} = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
