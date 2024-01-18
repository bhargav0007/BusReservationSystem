using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReservationCommon.Interface;
using ReservationDataAccessLayer;
using ReservationDataAccessLayer.Models;
using ReservationDataAccessLayer.Repository;
using ReservationServiceLayer;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.Mapper;
using ReservationServiceLayer.ViewModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ReservationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookingReservationSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
});

builder.Services.AddTransient<ReservationFactory>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IBusService, BusService>();
builder.Services.AddTransient<IBookingService, BookingService>();

builder.Services.AddTransient<IRepository<Bus>, BusRepository>();
builder.Services.AddTransient<IRepository<Booking>, BookingRepository>();
builder.Services.AddTransient<IRepository<User>, UserRepository>();

builder.Services.AddTransient<IMapper<User, UserModel>, UserMapper>();
builder.Services.AddTransient<IMapper<Bus, BusModel>, BusMapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
