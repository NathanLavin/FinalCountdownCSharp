using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Ticket
    {
        public double TicketPrice { get; set; }
        public double GeneralAdmission { get; set; }
        public double FrontAdmission { get; set; }
        public double VipAdmission { get; set; }
        public Ticket() { }
        public override string ToString()
        {
            return $"General Admission: {GeneralAdmission}\nFront Admission: {FrontAdmission}\nVIP Admission: {VipAdmission}\n\n\n\n\n\n\n\n\n\n\n\nTotal Price: {TicketPrice:c}";
        }
    }
}
