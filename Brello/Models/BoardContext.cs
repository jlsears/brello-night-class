namespace Brello.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BoardContext : DbContext

    {
        // Making the connections between the classes we have and the table/model
        public virtual IDbSet<Color> Colors { get; set; }
        public virtual IDbSet<Card> Cards { get; set; }

        // Your context has been configured to use a 'BoardContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Brello.Models.BoardContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BoardContext' 
        // connection string in the application configuration file.
       
            // Used the connection string from the webconfig named "BoardContext"
            public BoardContext()
            : base("name=BoardContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}