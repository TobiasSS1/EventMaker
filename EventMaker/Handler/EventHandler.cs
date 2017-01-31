using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.ViewModel;

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
            EVM = new EventViewModel();
        }
    }
}
