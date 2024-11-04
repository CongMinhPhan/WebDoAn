namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit544 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Link", c => c.String());
            AddColumn("dbo.tb_Product", "OriginalPrice2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_Product", "OriginalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_Product", "OriginalPrice2");
            DropColumn("dbo.tb_Category", "Link");
        }
    }
}
