using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using EventMaker.Model;


namespace EventMaker.Persistency
{
    public class PersistencyService
    {

        public EventCatalogSingleton MyCatalog { get; set; }

        public PersistencyService(EventCatalogSingleton test)
        {
            this.MyCatalog = test;
        }

        private void GemEvent()
        {
            
        }

        public string GetEvent()
        {
            return "";
        }

        //public PersistencyService()
        //{

        //}

        //public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        //{
            
        //}

        //public static async Task<List<Event>> LoadEventsFromJson()
        //{
        //    //string jsonText = JsonConvert.SerializeObject();
        //    //return jsonText;
        //}

        //public static async void SerializeEventsFileAsync(string eventString, string fileName)
        //{
                        
        //}

        //public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        //{
        //    return "test";
        //}
    }
}
