using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EventMaker.Common;
using EventMaker.Model;
using EventMaker.Handler;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        public Model.EventCatalogSingleton ECS { get; set; }
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }
        /*public RelayCommand ICommand { get; private set; }  */
        public ICommand CreateEventCommander { get; set; }
        public EventCatalogSingleton minSingle { get; set;}
        public Handler.EventHandler minHandler { get; set; }

        
        public EventViewModel()
        {
            minHandler = new Handler.EventHandler(this);
            CreateEventCommander = new RelayCommand(minHandler.CreateEvent);
            //this.minHandler = minhandler;
            //this.minSingle = minsingle; 
            //this.CreateEventCommander = createeventcommander;
            DateTime dt = System.DateTime.Now;
            Date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }
    }
}
