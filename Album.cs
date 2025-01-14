using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Album
    {

        private int albumID;
        private string albumName;
        private int erscheinungsjahr;
        private string albumCover;
        private int labelID;
        private int artistID;

        public int AlbumID { get => albumID; set => albumID = value; }
        public string AlbumName { get => albumName; set => albumName = value; }
        public int Erscheinungsjahr { get => erscheinungsjahr; set => erscheinungsjahr = value; }
        public string AlbumCover { get => albumCover; set => albumCover = value; }
        public int LabelID { get => labelID; set => labelID = value; }
        public int ArtistID { get => artistID; set => artistID = value; }

        public Album(int albumID, string albumName, int erscheinungsjahr, string albumCover, int labelID, int artistID)
        {
            this.albumID = albumID;
            this.albumName = albumName;
            this.erscheinungsjahr = erscheinungsjahr;
            this.albumCover = albumCover;
            this.labelID = labelID;
            this.artistID = artistID;
        }
    }
}
