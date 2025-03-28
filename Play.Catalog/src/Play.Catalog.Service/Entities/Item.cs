using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play.Common;

namespace Play.Catalog.Service.Entities
{
    public class Item : IEntity
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}