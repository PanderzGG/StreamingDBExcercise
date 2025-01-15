using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class SongData
    {
        private int songDataID;
        private TimeSpan songDauer;
        private int songBPM;
        private string songFormat;
        private int songID;

        public int SongDataID { get => songDataID; set => songDataID = value; }
        public TimeSpan SongDauer { get => songDauer; set => songDauer = value; }
        public int SongBPM { get => songBPM; set => songBPM = value; }
        public string SongFormat { get => songFormat; set => songFormat = value; }
        public int SongID { get => songID; set => songID = value; }

        public SongData(int songDataID, TimeSpan songDauer, int songBPM, string songFormat, int songID)
        { 
            this.songDataID = songDataID;
            this.songDauer = songDauer;
            this.songBPM = songBPM;
            this.songFormat = songFormat;
            this.songID = songID;
        }

        public SongData(TimeSpan songDauer, int songBPM, string songFormat, int songID)
        {
            this.songDauer = songDauer;
            this.songBPM = songBPM;
            this.songFormat = songFormat;
            this.songID = songID;
        }
    }
}
