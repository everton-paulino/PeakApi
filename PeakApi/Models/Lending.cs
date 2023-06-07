using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Models
{
    [BsonIgnoreExtraElements]
    public class Lending
    {
        public Lending()
        {
            Key = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }

        public string Key { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public int InstallmentsNumber { get; set; }
        public float InstallmentsValue { get; set; }
    }
}
