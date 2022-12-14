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

            MeetingRoomRepository repo = new MeetingRoomRepository();
            //Console.WriteLine("Details in Meeting Room Table");
            //foreach (var item in repo.GetmeetingRoomList())
            //{
            //    Console.WriteLine($"{item.RoomName}, is Available in {item.Location}");
            //}

            //Console.WriteLine("Enter the Meeting Room Details");
            //Console.WriteLine("Enter Room Name");
            //MeetingRoom.Domain.MeetingRoom meetingRoomObj = new MeetingRoom.Domain.MeetingRoom();
            //meetingRoomObj.RoomName = Console.ReadLine();
            //Console.WriteLine("Enter the Location");
            //meetingRoomObj.Location = Console.ReadLine();
            //Console.WriteLine("Enter the Room Type");
            //meetingRoomObj.RoomType = Console.ReadLine();
            //repo.AddNewMeetingRoom(meetingRoomObj);

            //Console.WriteLine("Details of Meeting Room after new meeting room insertion");
            //foreach (var item in repo.GetmeetingRoomList())
            //{
            //    Console.WriteLine($"{item.RoomName}, is Available in {item.Location}");
            //}


            //    QueryFilters();
            Console.WriteLine("Details in Meeting Room Table");
            foreach (var item in repo.GetmeetingRoomList())
            {
                Console.WriteLine($"{item.RoomName}, is Available in {item.Location}");
            }
            repo.UpDateMeetingRoom();
            Console.WriteLine("Details in Meeting Room Table");
            foreach (var item in repo.GetmeetingRoomList())
            {
                Console.WriteLine($"{item.RoomName}, is Available in {item.Location}");
            }


        }

        public static void QueryFilters()
        {
            MeetingRoomDBContext dbContext = new MeetingRoomDBContext();
            //Fetching the rooms from a Given Location
            string location = Console.ReadLine();
            var rooms = dbContext.MeetingRooms.Where(s => s.Location == location);
            Console.WriteLine("Fetching the Rooms of Chennai");
            foreach (var item in rooms)
            {
                Console.WriteLine($"{item.RoomName}, {item.RoomType}");
            }
        }
    }
}
