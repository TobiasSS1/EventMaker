using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        public Model.EventCatalogSingleton ECS { get; set; }
        int Id { get; set; }
        string Navn { get; set; }
        string Description { get; set; }
        string Place { get; set; }
        DateTimeOffset Date { get; set; }
        TimeSpan Time { get; set; }

        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            Date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }

    }
}
