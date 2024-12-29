using Microsoft.AspNetCore.Mvc;
using TextBasedFantasyGame.Services;

namespace TextBasedFantasyGame.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly JobService _jobService;

    public JobsController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet]
    public IActionResult GetJobs()
    {
        var jobs = _jobService.GetAllJobs();
        Console.WriteLine("Received request for GetJobs");
        return Ok(jobs);
    }

    [HttpGet("{jobName}")]
    public IActionResult GetJobByName(string jobName)
    {
        var job = _jobService.GetJobByName(jobName);
        if (job == null)
        {
            return NotFound($"Job {jobName} was not found");
        }

        return Ok(job);
    }
}