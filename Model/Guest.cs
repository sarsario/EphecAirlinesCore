using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Guest
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public DateTime Birthdate { get; set; }

    }
}
