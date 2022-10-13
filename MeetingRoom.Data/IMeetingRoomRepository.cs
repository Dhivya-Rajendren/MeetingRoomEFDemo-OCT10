using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Data
{
    internal interface IMeetingRoomRepository
    {
        List<MeetingRoom.Domain.MeetingRoom> GetMaaetingRooms();
        int AddNewMeetingRoom(MeetingRoom.Domain.MeetingRoom meeting);
    }
}
