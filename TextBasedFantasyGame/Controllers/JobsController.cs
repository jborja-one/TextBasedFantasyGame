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
        try
        {
            var jobs = _jobService.GetAllJobs();
            return Ok(jobs);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = "An error occurred while fetching jobs.", details = ex.Message });
        }
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