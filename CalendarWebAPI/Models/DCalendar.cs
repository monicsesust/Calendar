using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarWebAPI.Models
{
    public class DCalendar
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string location { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string runType { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string productName { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string receiveBy { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }        

    }
}
