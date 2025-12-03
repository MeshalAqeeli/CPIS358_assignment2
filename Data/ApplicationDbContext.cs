using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReceiptTracker.Models;

namespace ReceiptTracker.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<ReceiptTracker.Models.Receipt> Receipt { get; set; } = default!;
    }
}
