using System;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoom.Domain
{
    public class MeetingRoomType
    {
        [Key]// Created a primary key for RoomTypeId
        public int RoomTypeId { get; set; }
        public string RoomType { get; set; }
    }
}
