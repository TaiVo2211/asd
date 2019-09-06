using System;
using System.Collections.Generic;

namespace Avaya.API.Models
{
    public partial class BookingDetail
    {
        public BookingDetail()
        {
            ShowTime = new HashSet<ShowTime>();
        }

        public int Id { get; set; }
        public int IdMovie { get; set; }
        public int IdCinema { get; set; }
        public DateTime Date { get; set; }

        public virtual Cinema IdCinemaNavigation { get; set; }
        public virtual Movie IdMovieNavigation { get; set; }
        public virtual ICollection<ShowTime> ShowTime { get; set; }
    }
}
