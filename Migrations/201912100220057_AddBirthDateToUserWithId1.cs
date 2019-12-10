namespace MovieRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToUserWithId1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('01/01/1995' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
