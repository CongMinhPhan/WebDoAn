namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Product", "OriginalPrice2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "OriginalPrice2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
