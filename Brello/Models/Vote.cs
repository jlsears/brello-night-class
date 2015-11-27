using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Vote
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int VoteId { get; }
        public int Value { get; set; }
        public Card Card { get; set; }
        public ApplicationUser User { get; set; }
    }
}