using Entities;
using FluentMigrator;
using System;
using System.Collections.Generic;

namespace DataBaseMigrations
{
    [Migration (2024021100)]
    public class CreateTableSpendingCategories : FluentMigrator.Migration
    {
        public override void Down()
        {
            if (this.Schema.Table("SpendingCategories").Exists())
            {
                Delete.Table("SpendingCategories");
            }
        }

        public override void Up()
        {
            if (!this.Schema.Table("SpendingCategories").Exists())
            {
                Create.Table("SpendingCategories")
                    .WithColumn("ID").AsInt32().PrimaryKey().NotNullable()
                    .WithColumn("Name").AsString(50).NotNullable();
                foreach (SpendingCategoriesEnum e in (SpendingCategoriesEnum[])Enum.GetValues(typeof(SpendingCategoriesEnum)))
                {
                    Insert.IntoTable("SpendingCategories").Row(new { ID = (int)e, Name = e.ToString() });
                }
                
            }
        }
    }
}
