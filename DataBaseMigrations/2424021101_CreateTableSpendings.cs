using FluentMigrator;
using System;
using System.Collections.Generic;

namespace DataBaseMigrations
{
    [Migration (2024021101)]
    public class CreateTableSpendings : FluentMigrator.Migration
    {
        public override void Down()
        {
            if (this.Schema.Table("Spendings").Exists())
            {
                Delete.Table("Spending");
            }
        }

        public override void Up()
        {
            if (!this.Schema.Table("Spendings").Exists())
            {
                Create.Table("Spendings")
                    .WithColumn("ID").AsGuid().PrimaryKey().NotNullable()
                    .WithColumn("Name").AsString(80).NotNullable()
                    .WithColumn("SpendingCategoryID").AsInt32().ForeignKey("FK_Spending_Category", "SpendingCategories", "ID")
                    .WithColumn("PcsPrice").AsDecimal(8,2).NotNullable()
                    .WithColumn("Amount").AsInt32().NotNullable()
                    .WithColumn("Shop").AsString(50).NotNullable()
                    .WithColumn("Date").AsDateTime().NotNullable()
                    .WithColumn("Comment").AsString(255).Nullable();
                Execute.Script("SQL\\SpendingScript.sql");
            }
        }
    }
}
