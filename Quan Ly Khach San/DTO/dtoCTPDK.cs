using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoCTPDK
    {
        private string cMND;
        private string mAPDK;
        private string mAP;
        public dtoCTPDK() { }
        public dtoCTPDK(string CMND,string MAPDK,string MAP) {
            this.CMND = CMND;
            this.MAPDK = MAPDK;
            this.MAP = MAP;
        }
        public dtoCTPDK(DataRow row)
        {
            this.CMND = (string)row["CMND"];
            this.MAPDK = (string)row["MAPDK"];
            this.MAP = (string)row["MAP"];
        }


        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public string MAPDK
        {
            get
            {
                return mAPDK;
            }

            set
            {
                mAPDK = value;
            }
        }

        public string MAP
        {
            get
            {
                return mAP;
            }

            set
            {
                mAP = value;
            }
        }
    }
}
