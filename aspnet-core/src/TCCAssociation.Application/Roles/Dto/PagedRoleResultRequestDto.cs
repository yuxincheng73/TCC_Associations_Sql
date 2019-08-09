using Abp.Application.Services.Dto;

namespace TCCAssociation.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

