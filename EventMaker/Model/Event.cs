using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {

        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Place { get; set; }
        DateTime DateTime { get; set; }

        public Event()
        {
            
        }
    }


}
