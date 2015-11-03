using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }

        // Changed from ICollection to List (List implements ICollection)
        public virtual List<BrelloList> Lists { get; set; }
        public virtual List<ApplicationUser> Followers { get; set; }

        // Constructor to allow for initializing in the test
        public Board()
        {
            Lists = new List<BrelloList>();
            Followers = new List<ApplicationUser>();
        }
    }
}