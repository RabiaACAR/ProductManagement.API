using AutoMapper;
using EntityLayer.DTO;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.DataAccesLayer.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductDal _pdal;
        IMapper _mapper;

        public ProductController(IProductDal pdal,IMapper mapper)
        {
            _pdal = pdal;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult getAll()
        {
           var data = _pdal.GetAll();
            return Ok(_mapper.Map<List<ProductDTO>>(data));
        }
        [HttpGet("{id}")]
        public IActionResult getProductByCategory(int id )
        {
            var values = _pdal.GetProductByCategory(id);
            return Ok(values);
        }
    }
}
