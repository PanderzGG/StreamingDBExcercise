using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Featuring
    {
        private int featuringID;
        private int songID;
        private int artistID;

        public int FeaturingID { get => featuringID; set => featuringID = value; }
        public int SongID { get => songID; set => songID = value; }
        public int ArtistID { get => artistID; set => artistID = value; }

        public Featuring(int featuringID, int songID, int artistID)
        {
            this.featuringID = featuringID;
            this.songID = songID;
            this.artistID = artistID;
        }
    }
}
