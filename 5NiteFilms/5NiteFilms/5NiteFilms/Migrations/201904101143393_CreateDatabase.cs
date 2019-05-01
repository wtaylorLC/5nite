namespace _5NiteFilms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.ActorID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Description = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        ActorID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.ActorID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.ReviewComments",
                c => new
                    {
                        CommentReviewID = c.Int(nullable: false, identity: true),
                        CommentDate = c.DateTime(nullable: false),
                        CommentID = c.Int(nullable: false),
                        ReviewID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentReviewID)
                .ForeignKey("dbo.Comments", t => t.CommentID, cascadeDelete: true)
                .ForeignKey("dbo.Reviews", t => t.ReviewID, cascadeDelete: true)
                .Index(t => t.CommentID)
                .Index(t => t.ReviewID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Descripton = c.String(),
                        Ratings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID);
            
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        MovieActorID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ActorID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieActorID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.ActorID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        GenreID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID)
                .Index(t => t.Movie_MovieID);
            
            CreateTable(
                "dbo.MovieDirectors",
                c => new
                    {
                        MovieDirectorID = c.Int(nullable: false, identity: true),
                        Producer = c.String(),
                        writers = c.String(),
                        DirectorID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieDirectorID)
                .ForeignKey("dbo.Directors", t => t.DirectorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.DirectorID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        DirectorName = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Movies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieDirectors", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieDirectors", "DirectorID", "dbo.Directors");
            DropForeignKey("dbo.MovieActors", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Comments", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieActors", "ActorID", "dbo.Actors");
            DropForeignKey("dbo.Comments", "ActorID", "dbo.Actors");
            DropForeignKey("dbo.ReviewComments", "ReviewID", "dbo.Reviews");
            DropForeignKey("dbo.ReviewComments", "CommentID", "dbo.Comments");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.MovieDirectors", new[] { "MovieID" });
            DropIndex("dbo.MovieDirectors", new[] { "DirectorID" });
            DropIndex("dbo.Movies", new[] { "Movie_MovieID" });
            DropIndex("dbo.MovieActors", new[] { "MovieID" });
            DropIndex("dbo.MovieActors", new[] { "ActorID" });
            DropIndex("dbo.ReviewComments", new[] { "ReviewID" });
            DropIndex("dbo.ReviewComments", new[] { "CommentID" });
            DropIndex("dbo.Comments", new[] { "MovieID" });
            DropIndex("dbo.Comments", new[] { "ActorID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Genres");
            DropTable("dbo.Directors");
            DropTable("dbo.MovieDirectors");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieActors");
            DropTable("dbo.Reviews");
            DropTable("dbo.ReviewComments");
            DropTable("dbo.Comments");
            DropTable("dbo.Actors");
        }
    }
}
