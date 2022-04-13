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
    public class CategoryController : ControllerBase
    {
        ICategoryDal _cDal;
        IMapper _mapper;

        public CategoryController(ICategoryDal cDal, IMapper mapper)
        {
            _cDal = cDal;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var data = _cDal.GetAll();
            return Ok(_mapper.Map<List<CategoryDTO>>(data));
        }
    }
}
