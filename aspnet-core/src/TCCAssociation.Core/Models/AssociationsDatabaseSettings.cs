using System;
using System.Collections.Generic;
using System.Text;

namespace TCCAssociation.Models
{
    public class AssociationsDatabaseSettings : IAssociationsDatabaseSettings
    {
        public string BrandsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAssociationsDatabaseSettings
    {
        string BrandsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
