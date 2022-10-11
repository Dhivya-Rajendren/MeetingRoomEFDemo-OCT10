using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Domain
{
  public  class MeetingRoom
    {
        [Key]//Create a primary key to my table 
        public int RoomNo { get; set; }

        [Required]// Applying a NOT NULL constraint on the RoomName 
        [Column(TypeName ="char")]// Applies tha exact data type of the coulmn
        [StringLength(50)]// Apply what is the maximum length
        public string RoomName { get; set; }


        [Column(TypeName = "char")]// Applies tha exact data type of the coulmn
        [StringLength(50)]// Apply what is the maximum length
        [Required]
        public string RoomType { get; set; }

        [Column(TypeName = "varchar")]// Applies tha exact data type of the coulmn
        [StringLength(50)]// Apply what is the maximum length
        [Required]
        public string Location { get; set; }
    }
}
