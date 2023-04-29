using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Materials
    {
        public int ID { get; set; }
        public string Factory { get; }
        public int Leftovers_start { get; set; }
        public int Received { get; set; }
        public int Issued { get; set; }
        public int Leftovers_end { get; set; }
       
        public Materials(string factory, int leftovers1, int received, int issued)
        {
            this.Factory = factory;
            this.Leftovers_start = leftovers1;
            this.Received = received;
            this.Issued = issued;
            this.Leftovers_end = leftovers1 + received - issued;

        }
    }
}
