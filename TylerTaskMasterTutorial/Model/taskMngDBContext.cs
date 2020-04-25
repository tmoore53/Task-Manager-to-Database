using System.Data.Entity;


namespace TylerTaskMasterTutorial.Model
{
    class taskMngDBContext: DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }




        /* Package MAnager Console Commands
         1. update-databae
         2. add-migration ____*what you are migrating*_____
         3. update-database -Target ___*Roll-back to that specific migration, you don't need to include .cs *___
         4. get-migration  *This shows what migrations you have on the database*

         */
    }
}
