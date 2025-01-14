using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Artist
    {
        private int artistID;
        private string artistName;
        private string artistInfo;
        private string artistImage;

        public int ArtistID { get => artistID; set => artistID = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public string ArtistInfo { get => artistInfo; set => artistInfo = value; }
        public string ArtistImage { get => artistImage; set => artistImage = value; }

        public Artist(int artistID, string artistName, string artistInfo, string artistImage)
        {
            this.artistID = artistID;
            this.artistName = artistName;
            this.artistInfo = artistInfo;
            this.artistImage = artistImage;
        }
    }
}
