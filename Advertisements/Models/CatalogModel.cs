using Advertisements.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisements.Models
{
    public class CatalogModel
    {
        public List<Advertisement> Advertisements { get; set; }
        public Category Category { get; set; }
    }
}
