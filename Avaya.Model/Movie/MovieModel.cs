using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Model.Movie
{
    public class MovieModel : BaseModel
    {
        public MovieModel()
        {
            ListShowTime = new List<ShowTimeModel>();
        }

        public string MovieName { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public List<ShowTimeModel> ListShowTime { get; set; }
    }
}
