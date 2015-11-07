using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardContext : DbContext
    {
        // Uses the connection string from the Web.config named "BoardContext"
        /*
        public BoardContext() {
            Boards = new DbSet<Board>();
        }*/

        public virtual IDbSet<Color> Colors { get; set; }
        public virtual IDbSet<Card> Cards { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        // Taking the I away makes this a concrete class rather than an interface

        // IQueryable, IList/List, ICollection/Collection, IDbset/Dbset
    }
}