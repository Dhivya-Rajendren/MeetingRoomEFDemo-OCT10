using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Domain
{
   public class Meeting
    {
        [Key]
        public int MeetingId { get; set; }
        [Required]
        public int RoomNo { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(250)]
        [Display(Name ="Remarks")]
        public string MeetingDescription { get; set; }

        public DateTime MeetingDate { get; set; }


    }
}
