using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartCity.Contracts.Services;

namespace SmartCity.Api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMediator _mediatr;

        public UserController(
            IUserService userService,
            IMediator mediatr)
        {
            _userService = userService;
            _mediatr = mediatr;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateUser()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        public IActionResult UpdateUser()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]                              
        public IActionResult DeleteUser()      
        {                                       
            throw new NotImplementedException();
        }                                       
    }
}