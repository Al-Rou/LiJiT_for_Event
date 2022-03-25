using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiJiT.Domain.DTO
{
    public class EventsDto
    {
        public string Note { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string ImageEvent { get; set; }
    }
}
