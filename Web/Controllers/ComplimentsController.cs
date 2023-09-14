using System;
using System.Collections.Generic;
using System.Linq;
using Db.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Db.Repositiries;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ComplimentsController : ControllerBase
{
    private readonly ILogger<ComplimentsController> _logger;
    private readonly IComplimentsRepository         _complimentsRepository;
    
    public ComplimentsController(
        ILogger<ComplimentsController> logger,
        IComplimentsRepository complimentsRepository)
    {
        _logger = logger;
        _complimentsRepository = complimentsRepository;
    }
    /// <summary>
    /// test
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetComplimentById")]
    public string GetComplimentById( int complimentId )
    {
        return _complimentsRepository.GetComplimentById(complimentId);
    }

    // [HttpGet(Name = "GetAllCompliments")]
    // public IEnumerable<string> GetAllCompliments()
    // {
    //     return _complimentsRepository.GetAllCompliments();
    // }
}