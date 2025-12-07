using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs
{
    public class BookTagDto : BaseDto
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}
