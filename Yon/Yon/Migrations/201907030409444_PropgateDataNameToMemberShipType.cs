namespace Yon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropgateDataNameToMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET NAME='Free Account' WHERE ID=1");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME='Monthly Account' WHERE ID=2");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME='Quarterly Account' WHERE ID=3");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME='Yearly Account' WHERE ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
