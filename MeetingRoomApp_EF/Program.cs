using MeetingRoom.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetingRoomApp_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingRoomDBContext _dbContext = new MeetingRoomDBContext();

            List<MeetingRoom.Domain.MeetingRoom> meetingRooms = _dbContext.MeetingRooms.ToList();

            Console.WriteLine("Displaying the Meeting Room Details");

            foreach (var item in meetingRooms)
            {
                Console.WriteLine($"Room Name : {item.RoomName.Trim()}, Location : {item.Location}");
            }


        }
    }
}
