using System;
using System.Runtime.CompilerServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCity.Contracts.Services;

namespace SmartCity.Api.Controllers
{
    [ApiController]
    public class IssueController
        : ControllerBase
    {
        private readonly IIssueService _issueService;
        private readonly IMediator _mediator;

        public IssueController(
            IIssueService issueService,
            IMediator mediator,
            ILogger<IssueController> logger
            )
        {
            _issueService = issueService;
            _mediator = mediator;
        }
        
        [HttpGet]
        public IActionResult GetIssue()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateIssue()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        public IActionResult UpdateIssue()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]                              
        public IActionResult DeleteIssue()      
        {                                       
            throw new NotImplementedException();
        }                                       
    }
}