using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Brello.Models
{
    public class BoardService
    {
        private BoardContext context;
        public BoardService(BoardContext _context) {
            context = _context;
        }
    }
}
