using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Data
{
    public class MeetingRoomRepository:IMeetingRoomRepository
    {


     public   List<MeetingRoom.Domain.MeetingRoom> GetmeetingRoomList()
        {
            MeetingRoomDBContext dbContext = new MeetingRoomDBContext();
            return dbContext.MeetingRooms.ToList();
        }

        public int AddNewMeetingRoom(MeetingRoom.Domain.MeetingRoom meetingRoom)
        {
            MeetingRoomDBContext dbContext = new MeetingRoomDBContext();

            if (meetingRoom!=null)
            {
                dbContext.MeetingRooms.Add(meetingRoom);  
            }

            return dbContext.SaveChanges();
        }

        public List<Domain.MeetingRoom> GetMaaetingRooms()
        {
            throw new NotImplementedException();
        }

        public int UpDateMeetingRoom()
        {
            MeetingRoomDBContext meetingRoomDBContext = new MeetingRoomDBContext();
            var meetingRoom = meetingRoomDBContext.MeetingRooms.FirstOrDefault();
            meetingRoom.RoomName = "Room- " +meetingRoom.RoomName.Trim() ;
            return meetingRoomDBContext.SaveChanges();
        }
    }
}
