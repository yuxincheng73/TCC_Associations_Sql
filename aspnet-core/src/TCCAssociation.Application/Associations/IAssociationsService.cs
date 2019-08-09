using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCCAssociation.Associations.Dto;

namespace TCCAssociation.Associations
{
    public interface IAssociationsService : IApplicationService
    {
        Task<List<AssociationDto>> GetAssociations();
        Task<AssociationDto> GetAssociation(string id);
        //Task<AssociationDto> GetAssociationbyName(string name, string language_code);
        Task<string> CreateAssociation(AssociationDto input);
        //Task<AssociationDto> UpdateAssociation(AssociationDto input);
        Task<string> DeleteAssociation(string id);
    }
}
