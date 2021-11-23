using Microsoft.EntityFrameworkCore;
using Party.Models;

namespace Party.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}


		public DbSet<GuestResponse> guestResponses { get; set; }
	}
}

