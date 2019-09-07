//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web.Http.Cors;
//using Avaya.Core.Repositories;
//using Avaya.Domain.Models;
//using Avaya.Model;
//using Avaya.Service;
//using Microsoft.AspNetCore.Mvc;

//namespace Avaya.API.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
//    public class MenuController : Controller
//    {
//        private readonly IMenuService _menuService;
//        public MenuController(IMenuService menuService)
//        {
//            _menuService = menuService;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            var listMenus = _menuService.GetAll();
//            return Ok(listMenus);
//        }

//        [HttpGet("{query}")]
//        public IActionResult GetData(int query)
//        {
//            var listMenus = _menuService.Change(query);
//            return Ok(listMenus);
//        }

//        [HttpPost]
//        public IActionResult GetPost([FromBody] ProductDetailModel abc)
//        {
//            //var listMenus = _menuService.GetAll();
//            return Ok("asdasd");
//        }
//    }
//}