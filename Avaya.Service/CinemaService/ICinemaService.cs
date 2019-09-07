using System;
using System.Collections.Generic;
using System.Text;
using Avaya.Domain.Models;

namespace Avaya.Service.CinemaService
{
    interface ICinemaService
    {
        List<Cinema> GetAll(int date, Movie movie);
    }
}
