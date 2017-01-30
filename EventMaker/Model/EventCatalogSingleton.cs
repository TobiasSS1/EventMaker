using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {

        private static EventCatalogSingleton instance;

        private EventCatalogSingleton() { }
        public List<Event> EventListe = new List<Event>();

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }
                return instance;
            }
        }

        public void addMetode( )
        {
            EventListe.Add(1, "test", "test", "test", 1-14-2016);
            
        }
    }
}
