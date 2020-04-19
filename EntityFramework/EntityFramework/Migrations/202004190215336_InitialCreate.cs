namespace EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocPhan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LopHocPhan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdHocPhan = c.Int(nullable: false),
                        MSSV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HocPhan", t => t.IdHocPhan, cascadeDelete: true)
                .ForeignKey("dbo.SinhVien", t => t.MSSV)
                .Index(t => t.IdHocPhan)
                .Index(t => t.MSSV);
            
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        MSSV = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.Boolean(nullable: false),
                        Age = c.Int(nullable: false),
                        Birthday = c.DateTime(),
                    })
                .PrimaryKey(t => t.MSSV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocPhan", "MSSV", "dbo.SinhVien");
            DropForeignKey("dbo.LopHocPhan", "IdHocPhan", "dbo.HocPhan");
            DropIndex("dbo.LopHocPhan", new[] { "MSSV" });
            DropIndex("dbo.LopHocPhan", new[] { "IdHocPhan" });
            DropTable("dbo.SinhVien");
            DropTable("dbo.LopHocPhan");
            DropTable("dbo.HocPhan");
        }
    }
}
