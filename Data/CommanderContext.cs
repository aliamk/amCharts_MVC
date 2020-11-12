using Commander.Models;                     // Command
using Microsoft.EntityFrameworkCore;        // DbContext

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        // Represent the Command object down to our database as a DbSet called Commands
        public DbSet<Command> Commands { get; set; }
    }
}