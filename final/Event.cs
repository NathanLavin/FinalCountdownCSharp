using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Event
    {
        private List<Band> _bands;
        public Event() { }
        public Event(List<Band> bands)
        {
            _bands = bands;
        }
        public List<Band> Events
        {
            get { return _bands; }
            set { _bands = value; }
        }
    }
}
