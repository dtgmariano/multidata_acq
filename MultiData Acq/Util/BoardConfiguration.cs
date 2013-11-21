﻿using System;

namespace MultiData_Acq.Util
{
    public class BoardConfiguration
    {
        public int Num { get; set; }
        public int Rate {get; set;}
        public int QChanns{get; set;}
        public int LowChannel  {get; set;}
        public int PointsRead {get; set;}
        private int maxChannels;
        public int MaxChannels
        {
            get { return maxChannels; }
            set
            {
                LowChannel = LowChannel + QChanns > value ? 0 : LowChannel;
                QChanns = QChanns > value ? value : QChanns;
                maxChannels = value;
            }
        }
        public BoardConfiguration(int lC, int qC, int r, int pR)
        {
            Rate = r;
            LowChannel = lC;
            PointsRead = pR;
            QChanns = qC;
        }

        public string BoardName
        {
            get{return String.Format("Board {0}", Num);}
        }
    }
}
