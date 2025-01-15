using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Song
    {
        private int songID;
        private string songTitel;
        private int genreID;
        private int albumID;

        public int SongID { get => songID; set => songID = value; }
        public string SongTitel { get => songTitel; set => songTitel = value; }
        public int GenreID { get => genreID; set => genreID = value; }
        public int AlbumID { get => albumID; set => albumID = value; }

        public Song(int songID, string songTitel, int genreID, int albumID)
        {
            this.songID = songID;
            this.songTitel = songTitel;
            this.genreID = genreID;
            this.albumID = albumID;
        }

        public Song(string songTitel, int genreID, int albumID)
        {
            this.songTitel = songTitel;
            this.genreID = genreID;
            this.albumID = albumID;
        }
    }
}
