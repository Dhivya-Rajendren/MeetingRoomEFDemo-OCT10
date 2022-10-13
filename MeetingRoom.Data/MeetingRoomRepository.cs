using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Data
{
    public class MeetingRoomRepository
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

    }
}
