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
        TimeSpan Time { get; set; }
        DateTime DateTime { get; set; }

        public Event()
        {
            
        }
        public Event(int Id, string Name, string Description, string Place, TimeSpan Time, DateTime DateTime)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Place = Place;
            this.Time = Time;
            this.DateTime = DateTime;
        }
    }


}
