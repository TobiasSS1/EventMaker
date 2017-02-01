using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.ViewModel;
using EventMaker.Model;
using EventMaker.Converter;


namespace EventMaker.Handler
{
    class EventHandler
    {
        public EventViewModel EVM { get; private set; }


        public EventHandler(EventViewModel evm)
        {
            this.EVM = evm;

        }

        public void CreateEvent()
        {
            Event myevent = new Event(EVM.Id, EVM.Navn, EVM.Description, EVM.Place, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EVM.Date, EVM.Time));
            EVM.ECS.addMetode(myevent);
        }
    }
}
