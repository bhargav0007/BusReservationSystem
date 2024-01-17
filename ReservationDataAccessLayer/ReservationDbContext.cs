using Microsoft.EntityFrameworkCore;
using ReservationDataAccessLayer.Models;

namespace ReservationDataAccessLayer
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext() { }

        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookingReservationSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buss { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().
                HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.Age).IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Bus>().
                HasKey(x => x.Id);
            modelBuilder.Entity<Bus>().Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            modelBuilder.Entity<Route>().
                HasKey(x => x.Id);
            modelBuilder.Entity<Route>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Schedule>().
                HasKey(x => x.Id);
            modelBuilder.Entity<Schedule>().Property(x => x.Id).ValueGeneratedOnAdd() ;
            modelBuilder.Entity<Schedule>().HasOne(x => x.Bus).WithMany(x => x.Schedules).HasForeignKey(x => x.BusId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Schedule>().HasOne(x => x.Route).WithMany(x => x.Schedules).HasForeignKey(x => x.RouteId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Booking>().
               HasKey(x => x.Id);
            modelBuilder.Entity<Booking>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Booking>().HasOne(x => x.Bus).WithMany(x => x.Bookings).HasForeignKey(x => x.BusId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Booking>().HasOne(x => x.User).WithMany(x => x.Bookings).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Booking>().HasOne(x => x.Schedule).WithMany(x => x.Bookings).HasForeignKey(x => x.ScheduleId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
