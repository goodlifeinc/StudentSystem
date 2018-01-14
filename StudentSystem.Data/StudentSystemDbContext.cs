using Microsoft.AspNet.Identity.EntityFramework;
using StudentSystemDbContext.Models;
using System.Data.Entity;

namespace StudentSystemDbContext.Data
{
    public class StudentSystemDbContextImpl : IdentityDbContext<ApplicationUser>
    {
        public StudentSystemDbContextImpl()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Lecturer> Lecturers { get; set; }

        public virtual IDbSet<Specialty> Specialties { get; set; }

        public virtual IDbSet<Faculty> Factulties { get; set; }

        public virtual IDbSet<DiplomaWork> DiplomaWorkds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<StudentSystemDbContextImpl>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiplomaWork>()
                .HasOptional(s => s.AssignedStudent)
                .WithOptionalDependent(t => t.DiplomaWork);

            //modelBuilder.Entity<Student>()
            //    .HasOptional(t => t.DiplomaWork)
            //    .WithOptionalPrincipal(s => s.AssignedStudent);

            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Entity<Trip>()
            //    .HasRequired(t => t.Driver)
            //    .WithMany(u => u.OwnTrips)
            //    .HasForeignKey(t => t.DriverId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<User>()
            //    .HasMany(x => x.JoinedTrips)
            //    .WithMany(t => t.Passengers);

            //modelBuilder.Entity<Comment>()
            //    .HasRequired(c => c.Trip)
            //    .WithMany(t => t.Comments)
            //    .HasForeignKey(c => c.TripId)
            //    .WillCascadeOnDelete(true);

            //base.OnModelCreating(modelBuilder);
        }

        public static StudentSystemDbContextImpl Create()
        {
            return new StudentSystemDbContextImpl();
        }
    }
}
