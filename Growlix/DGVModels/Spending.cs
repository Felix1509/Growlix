using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Growlix.DGVModels
{
    internal class SpendingModel
    {
        Guid ID { get; set; }
        string Name { get; set; }
        int Category { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }
        string Shop { get; set; }
        DateTime Date { get; set; }
        string Comment { get; set; }
        public SpendingModel(Spending s)
        {
            ID = s.ID;
            Name = s.Name;
            Category = s.SpendingCategoryID.ID;
            Price = s.PcsPrice;
            Amount = s.Amount;
            Shop = s.Shop;
            Date = s.Date;
            Comment = s.Comment;
        }
    }
}
