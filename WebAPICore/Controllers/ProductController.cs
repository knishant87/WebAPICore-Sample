using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Bussiness.Repository;
using WebAPICore.Model;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        IProductRepository productRepo = null;
        public ProductController(IProductRepository _productRepo)
        {
            productRepo = _productRepo;
        }


        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<ProductListViewModel> Get()
        {
            return Ok(productRepo.GetProducts());
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<ProductDetailsViewModel> GetByID(int id)
        {
            return Ok(productRepo.GetByID(id));
        }

    }
}