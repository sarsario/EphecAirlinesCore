using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Travel
    {
        public int Id { get; set; }

        public int FlyId { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int NbSeats { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

    }
}
