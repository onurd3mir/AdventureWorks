using AutoMapper;
using Business.Abstract;
using Entities.Dtos;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class SalesController : ApiController
    {
        private IMyAggregateService _myAggregateService;
        private IMapper _mapper;

        public SalesController(IMyAggregateService myAggregateService, IMapper mapper)
        {
            _myAggregateService = myAggregateService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetList(int page = 1)
        {
            var result = _myAggregateService.SalesService.GetSalesQuery(page);
            if (result.Success)
            {
                var sales = _mapper.Map<List<SalesDto>>(result.Data);
                return Ok(sales);
            }
            return NotFound();
        }
    }
}
