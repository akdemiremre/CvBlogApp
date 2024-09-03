using CvBlog.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            // Social Media Links
            builder.Property(u => u.YoutubeLink).HasMaxLength(250);
            builder.Property(u => u.TwitterLink).HasMaxLength(250);
            builder.Property(u => u.InstagramLink).HasMaxLength(250);
            builder.Property(u => u.FacebookLink).HasMaxLength(250);
            builder.Property(u => u.LinkedInLink).HasMaxLength(250);
            builder.Property(u => u.GitHubLink).HasMaxLength(250);
            builder.Property(u => u.WebsiteLink).HasMaxLength(250);
            //About
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.About).HasMaxLength(1000);
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(100);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var adminUser = new User
            {
                Id = 1,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@emreakdemir.net",
                NormalizedEmail = "ADMIN@EMREAKDEMIR.NET",
                PhoneNumber = "+901111111111",
                Picture = "defaultUser.png",
                FirstName = "Admin",
                LastName ="Admin",
                About = "Admin User About...",
                TwitterLink = "https://twitter.com/",
                InstagramLink = "https://instagram.com/",
                YoutubeLink = "https://youtube.com/",
                GitHubLink = "https://github.com/",
                LinkedInLink = "https://linkedin.com/",
                WebsiteLink = "https://emreakdemir.net.com/",
                FacebookLink = "https://facebook.com/",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash = CreatePasswordHash(adminUser, "admin");

            var editorUser = new User
            {
                Id = 2,
                UserName = "editor",
                NormalizedUserName = "EDITOR",
                Email = "editor@emreakdemir.net",
                NormalizedEmail = "EDITOR@EMREAKDEMIR.NET",
                PhoneNumber = "++902222222222",
                Picture = "defaultUser.png",
                FirstName = "Editor",
                LastName = "Editor",
                About = "Editor User About...",
                TwitterLink = "https://twitter.com/",
                InstagramLink = "https://instagram.com/",
                YoutubeLink = "https://youtube.com/",
                GitHubLink = "https://github.com/",
                LinkedInLink = "https://linkedin.com/",
                WebsiteLink = "https://emreakdemir.net.com/",
                FacebookLink = "https://facebook.com/",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            editorUser.PasswordHash = CreatePasswordHash(editorUser, "editor");
            builder.HasData(adminUser, editorUser);
        }
        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
