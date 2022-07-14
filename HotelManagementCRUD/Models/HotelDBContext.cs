using HotelManagementCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementCRUD.Models;

public class HotelDBContext : DbContext
{
    public HotelDBContext(DbContextOptions<HotelDBContext> options) : base(options)
    {

    }

    //Create Table here
    public DbSet<Hotel> Hotels { get; set; }
}