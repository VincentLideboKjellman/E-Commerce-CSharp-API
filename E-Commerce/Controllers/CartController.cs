using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using SQLitePCL;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using E_Commerce.Services;
using E_Commerce.Models;
using E_Commerce.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;



//need to add services and repositories, also dont forget the conenction string
namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        private readonly CorsService cartService;

        public CartController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.cartService = new CartService(new CartRepository(connectionString));
        }

        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(Products), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            var resault = this.cartService.Get(guid);
            return Ok(resault);
        }
    }
}