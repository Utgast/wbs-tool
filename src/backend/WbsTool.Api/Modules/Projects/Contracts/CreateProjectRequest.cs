using System.ComponentModel.DataAnnotations;

namespace WbsTool.Api.Modules.Projects.Contracts;

public class CreateProjectRequest
{
    [Required]
    [MaxLength(50)]
    public string ProjectNumber { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string Description { get; set; } = string.Empty;

    public DateOnly? PlannedStart { get; set; }
    public DateOnly? PlannedEnd { get; set; }
}