using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Activity : IActivity
    {
        public string ActivityName { get; set; }
        public DateTime SetDate { get; set; }
        public string Details { get; set; } //ev. begränsa till 500 tecken 
    }
}
