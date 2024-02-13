using System;
using FluentNHibernate.Mapping;

namespace Entities
{
    public class Spending
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual SpendingCategory SpendingCategoryID { get; set; }
        public virtual decimal PcsPrice { get; set; }
        public virtual int Amount { get; set; }
        public virtual string Shop { get; set; }
        public virtual DateTime Date {  get; set; }
        public virtual string? Comment { get; set; }
        // Bool should not be mapped. Just for updating in DGV
        public virtual bool WasEdited { get; set; } = false;
    }

    public class SpendingMap : ClassMap<Spending>
    { 
        public SpendingMap()
        {
            Table("Spendings");
            Id(x => x.ID).Column("ID").Not.Nullable();
            Map(x => x.Name).Column("Name").Length(80).Not.Nullable();
            References(x => x.SpendingCategoryID).Column("SpendingCategoryID").Not.Nullable();
            Map(x => x.PcsPrice).Column("PcsPrice").Scale(8).Precision(2).Not.Nullable();
            Map(x => x.Amount).Column("Amount").Not.Nullable();
            Map(x => x.Shop).Column("Shop").Length(50).Not.Nullable();
            Map(x => x.Date).Column("Date").Not.Nullable();
            Map(x => x.Comment).Column("Comment").Length(255).Nullable();
            
        }
    }

}
