using Microsoft.EntityFrameworkCore;

namespace Chain_Of_Responsibilty.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CSTSJL1\\MSSQLSERVER2019;initial catalog=ZChainOfResponsibility;integrated security=true");

        }
        public DbSet<ProcessDetail> ProcessDetails { get; set; }

    }
}
