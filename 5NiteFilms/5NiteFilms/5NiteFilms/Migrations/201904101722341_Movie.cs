namespace _5NiteFilms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Movie : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Movies", "Image_HelpLink");
           // DropColumn("dbo.Movies", "Image_Source");
            //DropColumn("dbo.Movies", "Image_HResult");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Movies", "Image_HResult", c => c.Int(nullable: false));
            //AddColumn("dbo.Movies", "Image_Source", c => c.String());
            //AddColumn("dbo.Movies", "Image_HelpLink", c => c.String());
        }
    }
}
