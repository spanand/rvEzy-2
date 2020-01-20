using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using Services.Interface;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListing _listingService;
        private readonly IMapper _mapper;

        public ListingsController(IListing listing, IMapper mapper)
        {
            _listingService = listing;
            _mapper = mapper;
        }
        
        // GET api/values
        [HttpGet]
        public List<ListingDto> Get([FromQuery] ListingPagination listingPagination)
        {
            var calendars = _listingService.GetCalendars();
            var listings = _listingService.GetListings();
            var reviews =  _listingService.GetReviews();
            _listingService.PushData(listings,calendars,reviews);
            var listing = _listingService.Get(listingPagination);
            var mappedResult = _mapper.Map<List<Listing>, List<ListingDto>>(listing);
            return mappedResult.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ListingDto Get(int id)
        {
            var listing = _listingService.Get(id);
            var mappedResult = _mapper.Map<Listing, ListingDto>(listing);
            return mappedResult;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
