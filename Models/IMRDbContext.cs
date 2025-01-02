
using Microsoft.EntityFrameworkCore;
using ERP_IMR.ViewModels;

namespace ERP_IMR.Models
{
    public class IMRDbContext : DbContext
    {
        public DbSet<BSMIMRBOM001> BSMIMRBOM001 { get; set; }
        public DbSet<BSMIMRCCM001> BSMIMRCCM001 { get; set; }
        public DbSet<BSMIMRGEN001> BSMIMRGEN001 { get; set; }
        public DbSet<BSMIMRGEN002> BSMIMRGEN002 { get; set; }
        public DbSet<BSMIMRGEN003> BSMIMRGEN003 { get; set; }
        public DbSet<BSMIMRGEN004> BSMIMRGEN004 { get; set; }
        public DbSet<BSMIMRGEN005> BSMIMRGEN005 { get; set; }
        public DbSet<BSMIMRMAT001> BSMIMRMAT001 { get; set; }
        public DbSet<BSMIMRMATHEAD> BSMIMRMATHEAD { get; set; }
        public DbSet<BSMIMRMATTEXT> BSMIMRMATTEXT { get; set; }
        public DbSet<BSMIMRROT001> BSMIMRROT001 { get; set; }
        public DbSet<BSMIMRWCM001> BSMIMRWCM001 { get; set; }
        public DbSet<BSMIMROPR001> BSMIMROPR001 { get; set; }
        public DbSet<BSMIMRCCMHEAD> BSMIMRCCMHEAD { get; set; }
        public DbSet<BSMIMRCCMTEXT> BSMIMRCCMTEXT { get; set; }
        public DbSet<BSMIMRWCMHEAD> BSMIMRWCMHEAD { get; set; }
        public DbSet<BSMIMRBOMCONTENT> BSMIMRBOMCONTENT { get; set; }
        public DbSet<BSMIMRBOMHEAD> BSMIMRBOMHEAD { get; set; }
        public DbSet<BSMIMRROTHEAD> BSMIMRROTHEAD { get; set; }
        public DbSet<BSMIMRWCMOPR> BSMIMRWCMOPR { get; set; }
        public DbSet<BSMIMRWCMTEXT> BSMIMRWCMTEXT { get; set; }
        public DbSet<BSMIMRROTOPRCONTENT> BSMIMRROTOPRCONTENT { get; set; }
        public DbSet<BSMIMRROTBOMCONTENT> BSMIMRROTBOMCONTENT { get; set; }

        public IMRDbContext(DbContextOptions<IMRDbContext> options) : base(options)
        {
        }

        public DbSet<ERP_IMR.ViewModels.MalzemeViewModel>? MalzemeViewModel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MalzemeViewModel>().HasNoKey();
        }
    }
  
}
