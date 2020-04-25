namespace TylerTaskMasterTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) Values ('To Do');");
            Sql("INSERT INTO Status (Name) Values ('In Progress');");
            Sql("INSERT INTO Status (Name) Values ('Done');");

        }

        public override void Down()
        {
            //Delete statements go here.
        }
    }
}
