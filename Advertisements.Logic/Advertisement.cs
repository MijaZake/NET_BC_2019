using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
    public class Advertisement : BaseData
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
