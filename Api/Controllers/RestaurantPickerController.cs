using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _RestaurantPickerService;
        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _RestaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("Restaurant/{userCategory}")]
        public string RestaurantPicker(string userCategory)
        {
            return _RestaurantPickerService.RestaurantPicker(userCategory);
        }
    }
}