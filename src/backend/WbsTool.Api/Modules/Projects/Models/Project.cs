using WbsTool.Api.Modules.Wbs.Models;

namespace WbsTool.Api.Modules.Projects.Models;

public class Project
{
    public Guid Id { get; set; }
    public string ProjectNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly? PlannedStart { get; set; }
    public DateOnly? PlannedEnd { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<WbsNode> WbsNodes { get; set; } = new List<WbsNode>();
}