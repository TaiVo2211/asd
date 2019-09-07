using System;
using System.Collections.Generic;
using System.Text;
using Avaya.Core.Repositories;
using Avaya.Domain.Models;

namespace Avaya.Service.CinemaService
{
    class CinemaService
    {
        private readonly IRepository<BookingDetail> _bookingdetailRepository;
        private readonly IRepository<Cinema> _cinemaDetailsRepository;

        public CinemaService(IRepository<BookingDetail> bookingdetailRepository,
            IRepository<Cinema> movieRepository)
        {
            _bookingdetailRepository = bookingdetailRepository;
            _cinemaDetailsRepository = movieRepository;
        }

        //public List<Cinema> GetAll(int date, Movie movie);
        //{
             
        //}
    }
}
