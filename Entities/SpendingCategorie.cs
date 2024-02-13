using System;
using System.Diagnostics.Tracing;
using FluentNHibernate.Mapping;

namespace Entities
{
    public class SpendingCategory
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
    }

    public class SpendingCategoryMap : ClassMap<SpendingCategory>
    {
        public SpendingCategoryMap()
        {
            Table("SpendingCategories");
            Id(x => x.ID).Column("ID").Not.Nullable();
            Map(x => x.Name).Column("Name").Length(50).Not.Nullable();
        }
    }

    public enum SpendingCategoriesEnum
    {
        DEFAULT = 0,
        SAMEN = 1,
        ERDE = 2,
        TOPF = 3,
        ANZUCHT = 4,
        ERNTE = 5,
        BOVEDA = 6,
        LAGERUNG = 7,
        DUENGER = 8,
        ZELT = 10,
        ABLUFT = 11,
        UMLUFT = 12,
        HAUPTLED = 13,
        ZUSATZLED = 14,
        ELEKTRONIK = 15,
        AKTIFKOHLEFILTER = 16,
        VERTIEB = 20,
        RBPROJEKT = 30
    }
}
