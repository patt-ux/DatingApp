namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}

/* Entity Framework
Is an Object Relation Mapper (ORM)
Translates code into SQL Commands that update the tables in the database
(this used to be ADO for handling connections to Database - until .Net 3.5)

Linq Queries
e.g.
DbContext.Users.Add(new User { Id = 4, Name = "John"})
SQL Lite Provider (Entity Framework) outputs:
INSERT INTO Users(Id, Name) VALUES (4, "John")

Entity Frameworks:
Allow Querying
Change Tracking
Save changes into Database (CRUD)
Concurrency
Transactions
Caching
Built-in conventions
Configurations
Migrations
*/