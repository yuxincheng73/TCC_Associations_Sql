using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCCAssociation.Associations.Dto;

namespace TCCAssociation.Associations
{
    class AssociationsService : IAssociationsService
    {

        public async Task<string> CreateAssociation(AssociationDto input)
        {
            return "dsf";
        }

        public async Task<string> DeleteAssociation(string id)
        {
            return "dsf";
        }

        public async Task<AssociationDto> GetAssociation(string id)
        {
            var sd = new AssociationDto
            {
                Id = id
            };
            return sd;
        }

        public Task<List<AssociationDto>> GetAssociations()
        {
            throw new NotImplementedException();
        }

        //public async Task<List<AssociationDto>> GetAssociations()
        //{

        //}

        public async Task<AssociationDto> UpdateAssociation(AssociationDto input)
        {
            var sd = new AssociationDto
            {
                Id = input.Id
            };
            return sd;
        }
    }
}
