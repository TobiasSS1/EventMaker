using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {

        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Place { get; set; }
        
        DateTime DateTime { get; set; }

        public Event()
        {

        }
        public Event(int Id, string Name, string Description, string Place,  DateTime DateTime)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Place = Place;
            
            this.DateTime = DateTime;
        }
    }


}
