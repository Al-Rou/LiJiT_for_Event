using AutoMapper;
using LiJiT.Domain.DTO;
using LiJiT.Domain.IRepository;
using LiJiT.Domain.IService;
using LiJiT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiJiT.Domain.Service
{
    public class EventService: IEventService
    {

        private IEventsRepository _eventsRepository;
        private readonly IMapper _mapper;
        public EventService(IEventsRepository eventsRepository, IMapper mapper)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
        }
        public async Task<List<EventsDto>> GetAll()
        {
            List<EventsDto> _listDto = new List<EventsDto>();
            try
            {
                var result = await _eventsRepository.GetAll();
                _listDto = new List<EventsDto>();
                foreach (var item in result)
                {
                    _listDto.Add(_mapper.Map<EventsDto>(item));
                }
            }
            catch (Exception ex)
            {

            }
            return _listDto;
        }
        public async Task<ListDto<EventsDto>> CreateEvent(EventsDto newEvent)
        {
            ListDto<EventsDto> _listDto = new ListDto<EventsDto>();
            try
            {

                var result = _mapper.Map<EventsDto, Events>(newEvent);
                await _eventsRepository.Add(result);
            }
            catch (Exception ex)
            {

            }
            return _listDto;
        }

    }
}
