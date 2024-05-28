using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Entitites;

namespace WebApplication1.DAL.Context;

public class MyPortfolioContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=webapplication1;User=root;Password=root;", new MySqlServerVersion(new Version(0, 0, 1)));
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}