using System;
using System.Collections.Generic;

namespace PropertiesManagement.Models
{
    public class PropertyModel
    {

        public int Id { get; set; }

        public int? PropertyTypeId { get; set; }

        public int? OwnerId { get; set; }

        public string? Number { get; set; }

        public string? Address { get; set; }

        public decimal? Area { get; set; }

        public decimal? ConstructionArea { get; set; }

        public virtual OwnerModel? Owner { get; set; }

        public virtual PropertyTypeModel? PropertyType { get; set; }
    }
}
