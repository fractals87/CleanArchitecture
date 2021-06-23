using CleanArchitecture.Core.ProjectAggregate;
using System.Collections.Generic;

namespace CleanArchitecture.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
