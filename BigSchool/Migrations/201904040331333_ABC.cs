namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABC : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_Lecturer_Id", newName: "IX_LecturerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_Lecturer_Id");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturer_Id");
        }
    }
}
