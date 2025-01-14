using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDB
{
    public class Label
    {
        private int labelID;
        private string labelName;
        private string labelInfo;
        private string labelImage;

        public int LabelID { get => labelID; set => labelID = value; }
        public string LabelName { get => labelName; set => labelName = value; }
        public string LabelInfo { get => labelInfo; set => labelInfo = value; }
        public string LabelImage { get => labelImage; set => labelImage = value; }

        public Label(int labelID, string labelName, string labelInfo, string labelImage)
        {
            this.labelID = labelID;
            this.labelName = labelName;
            this.labelInfo = labelInfo;
            this.labelImage = labelImage;
        }
    }
}
