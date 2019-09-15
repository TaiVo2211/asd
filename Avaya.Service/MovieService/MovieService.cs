using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avaya.Core.Extension;
using Avaya.Core.Repositories;
using Avaya.Domain.Models;

namespace Avaya.Service.MovieService
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<BookingDetail> _bookingDetailRepository;
        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<BookingDetail> bookingDetailRepository,
            IRepository<Movie> movieRepository)
        {
            _bookingDetailRepository = bookingDetailRepository;
            _movieRepository = movieRepository;
        }
        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll().ToList();
        }

        public List<Movie> GetData(string query)
        {
            var list = new List<Movie>();
            list = _movieRepository.GetAll().Where(x=>x.Name.Contains(query)).MapTo<List<Movie>>().ToList();
            return list;
        }
    }
}
