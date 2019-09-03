using Bcs.DataAccess.User;
using Bcs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bcs.DataAccess.Context
{
    public class BcsDbContext : IdentityDbContext<ApplicationUser>
    {
        public BcsDbContext(DbContextOptions<BcsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Iterate through all EF Entity types
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                #region Convert UniqueKeyAttribute on Entities to UniqueKey in DB
                var properties = entityType.GetProperties();
                if (properties != null && properties.Any())
                {
                    foreach (var property in properties)
                    {
                        var uniqueKeys = GetUniqueKeyAttributes(entityType, property);
                        if (uniqueKeys != null)
                        {
                            foreach (var uniqueKey in uniqueKeys.Where(x => x.Order == 0))
                            {
                                // Single column Unique Key
                                if (string.IsNullOrWhiteSpace(uniqueKey.GroupId))
                                {
                                    entityType.AddIndex(property).IsUnique = true;
                                }
                                // Multiple column Unique Key
                                else
                                {
                                    var mutableProperties = new List<IMutableProperty>();
                                    properties.ToList().ForEach(x =>
                                    {
                                        var uks = GetUniqueKeyAttributes(entityType, x);
                                        if (uks != null)
                                        {
                                            foreach (var uk in uks)
                                            {
                                                if (uk != null && uk.GroupId == uniqueKey.GroupId)
                                                {
                                                    mutableProperties.Add(x);
                                                }
                                            }
                                        }
                                    });
                                    entityType.AddIndex(mutableProperties).IsUnique = true;
                                }
                            }
                        }
                    }
                }
                #endregion Convert UniqueKeyAttribute on Entities to UniqueKey in DB
            }

            // any guid
            string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            string SUPERADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e675";
            // any guid, but nothing is against to use the same one
            string ROLE_ID = ADMIN_ID;
            string SUPERROLE_ID = SUPERADMIN_ID;
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = SUPERROLE_ID,
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            });

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "Admin@Compunet.com",
                Email = "Admin@Compunet.com",
                NormalizedUserName = "ADMIN@COMPUNET.COM",
                NormalizedEmail = "ADMIN@COMPUNET.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin@12345"),
                SecurityStamp = string.Empty
            });

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = SUPERADMIN_ID,
                UserName = "SuperAdmin@Compunet.com",
                Email = "SuperAdmin@Compunet.com",
                NormalizedUserName = "SUPERADMIN@COMPUNET.COM",
                NormalizedEmail = "SUPERADMIN@COMPUNET.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "superadmin@12345"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = SUPERROLE_ID,
                UserId = SUPERADMIN_ID
            });
        }

        private static IEnumerable<UniqueKeyAttribute> GetUniqueKeyAttributes(IMutableEntityType entityType, IMutableProperty property)
        {
            if (entityType == null)
            {
                throw new ArgumentNullException(nameof(entityType));
            }
            else if (entityType.ClrType == null)
            {
                throw new ArgumentNullException(nameof(entityType.ClrType));
            }
            else if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }
            else if (property.Name == null)
            {
                throw new ArgumentNullException(nameof(property.Name));
            }
            var propInfo = entityType.ClrType.GetProperty(
                property.Name,
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly);
            if (propInfo == null)
            {
                return null;
            }
            return propInfo.GetCustomAttributes<UniqueKeyAttribute>();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ExamTimeTable> ExamTimeTables { get; set; }
        public DbSet<PaymentCategory> PaymentCategories { get; set; }
        public DbSet<PaymentSetting> PaymentSettings { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StudentPayment> StudentPayments { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }
        public DbSet<TrainingTimeTable> TrainingTimeTables { get; set; }
      
    }
}
