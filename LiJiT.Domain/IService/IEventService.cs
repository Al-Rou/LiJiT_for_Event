using LiJiT.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiJiT.Domain.IService
{
    public interface IEventService
    {
        Task<List<EventsDto>> GetAll();
        Task<ListDto<EventsDto>> CreateEvent(EventsDto newEvent);
    }
}
