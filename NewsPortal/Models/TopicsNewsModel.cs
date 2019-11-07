using NewsPortal.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class TopicsNewsModel
    {
        public List<Topic> topics { get; set; }
        public List<News> news { get; set; }
    }
}
