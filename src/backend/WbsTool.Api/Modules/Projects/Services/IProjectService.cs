using WbsTool.Api.Modules.Projects.Contracts;

namespace WbsTool.Api.Modules.Projects.Services;

public interface IProjectService
{
    IEnumerable<ProjectDto> GetAll();
    ProjectDto? GetById(Guid id);
    ProjectDto Create(CreateProjectRequest request);
}