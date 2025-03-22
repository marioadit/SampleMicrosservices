using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play.Inventory.Service.Entities;
using static Play.Inventory.Service.Dtos;

namespace Play.Inventory.Service
{
    public static class Extension
    {
        public static InventoryItemDto AsDto(this InventoryItem item, String Name, String Description){
            return new InventoryItemDto(item.CatalogItemId, Name, Description, item.Quantity, item.AcquiredDate);
        }
    }
}