using MeetingRoom.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace MeetingRoom.Data
{
    public class MeetingRoomDBContext:DbContext
    {
        public DbSet<MeetingRoomType> MeetingRoomTypes { get; set; }// is used for reperenting the model class as a Database table,
                                                                    // CRUD 

        public DbSet<MeetingRoom.Domain.MeetingRoom> MeetingRooms  { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Dhivya-pc\\SqlExpress;Database=MeetingRoom_EFDemo;integrated security=true");
        }
    }
}
