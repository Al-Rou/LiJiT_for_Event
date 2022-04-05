using LiJiT.Domain.DTO;
using LiJiT.Domain.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiJiT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class EventsController : ControllerBase
    {

            public readonly IEventService _eventService;
            public EventsController(IEventService eventService)
            {
                _eventService = eventService;
            }
            [HttpGet]
            [Route("Upcoming")]
            public async Task<List<EventsDto>> GetAll()
            {
                var result  = await _eventService.GetAll();
                return result;
            }

            [HttpGet]
            [Route("All")]
            public async Task<List<EventsDto>> GetAllEvents()
            {
                var temp = await _eventService.GetAll();
                return temp;
            }

            [HttpPost]
            [Route("Create")]
            public async Task<ListDto<EventsDto>> CreateAboutContent(EventsDto newEvent)
            {
                return await _eventService.CreateEvent(newEvent);
            }
        


    }
}
