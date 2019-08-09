using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCCAssociation.Models
{
    public class Association : IHasCreationTime, IHasDeletionTime
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Name_TC")]
        public string Name_TC { get; set; }
        [BsonElement("Name_SC")]
        public string Name_SC { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("Description_TC")]
        public string Description_TC { get; set; }
        [BsonElement("Description_SC")]
        public string Description_SC { get; set; }
        [BsonElement("Url")]
        public string Url { get; set; }
        [BsonElement("Url_TC")]
        public string Url_TC { get; set; }
        [BsonElement("Url_SC")]
        public string Url_SC { get; set; }
        [BsonElement("Logo")]
        public string Logo { get; set; }
        [BsonElement("Discoverable")]
        public bool Discoverable { get; set; }
        [BsonElement("SortingOder")]
        public string SortingOrder { get; set; }
        [BsonElement("LaunchDate")]
        public DateTime LaunchDate { get; set; }
        [BsonElement("TimeZone")]
        public string TimeZone { get; set; }
        [BsonElement("CreationTime")]
        public DateTime CreationTime { get; set; }
        [BsonElement("UpdationTime")]
        public DateTime UpdationTime { get; set; }
        [BsonElement("DeletionTime")]
        public DateTime? DeletionTime { get; set; }
        [BsonElement("IsDeleted")]
        public bool IsDeleted { get; set; }

        public Association()
        {
            CreationTime = Clock.Now;
        }
    }
}
