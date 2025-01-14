using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Genre
    {
        private int genreID;
        private string genreName;
        public int GenreID { get => genreID; set => genreID = value; }
        public string GenreName { get => genreName; set => genreName = value; }
        
        public Genre(int genreID, string genreName)
        {
            this.genreID = genreID;
            this.genreName = genreName;
        }
    }
}
