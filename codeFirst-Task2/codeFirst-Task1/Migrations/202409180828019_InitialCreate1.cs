namespace codeFirst_Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        StudentDetailsId = c.Int(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentDetailsId)
                .ForeignKey("dbo.Students", t => t.StudentDetailsId)
                .Index(t => t.StudentDetailsId);
            
            AlterColumn("dbo.Assignments", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "Age");
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Teachers", "Subject");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Subject", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            DropForeignKey("dbo.StudentDetails", "StudentDetailsId", "dbo.Students");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailsId" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Assignments", "Title", c => c.String());
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Courses");
        }
    }
}
