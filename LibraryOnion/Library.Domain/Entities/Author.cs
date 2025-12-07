using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }

        //NP
        public virtual ICollection<Book> Books { get; set; }
    }
}
