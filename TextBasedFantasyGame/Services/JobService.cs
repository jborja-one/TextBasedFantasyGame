using System.Reflection;
using TextBasedFantasyGame.Models;

namespace TextBasedFantasyGame.Services;

public class JobService
{
    private readonly List<Job> _jobs;

    public JobService()
    {
        _jobs = LoadAllJobs();
    }

    private List<Job> LoadAllJobs()
    {
        var jobType = typeof(Job);
        var jobTypes = Assembly.GetAssembly(jobType)?.GetTypes()
            .Where(t => t.IsSubclassOf(jobType) && !t.IsAbstract)
            .ToList();

        var jobs = jobTypes?.Select(t => (Job)Activator.CreateInstance(t)).ToList() ?? new List<Job>();

        foreach (var job in jobs)
        {
            job.Initialize();
        }

        return jobs;
    }

    public IEnumerable<Job> GetAllJobs()
    {
        return _jobs;
    }

    public Job? GetJobByName(string jobName)
    {
        return _jobs.FirstOrDefault(j => j.Name.Equals(jobName, StringComparison.OrdinalIgnoreCase));
    }
}