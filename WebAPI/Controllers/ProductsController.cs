using AutoMapper;
using Business.Abstract;
using Entities.Dtos;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private IMyAggregateService _myAggregateService;
        private IMapper _mapper;

        public ProductsController(IMyAggregateService myAggregateService,IMapper mapper)
        {
            _myAggregateService = myAggregateService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = _myAggregateService.ProductService.Get(id);
            if (result.Success)
            {
                var product = _mapper.Map<ProductDto>(result.Data);
                return Ok(product);
            }
            return NotFound();
        }

        [HttpGet]
        //[Route("getlist")]
        public IHttpActionResult GetList()
        {
            var result = _myAggregateService.ProductService.GetList();
            if (result.Success)
            {
                var products = _mapper.Map<List<ProductDto>>(result.Data);
                return Ok(products);
            }
            return NotFound(); 
        }

    }
}
