using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFilterSp.Utils
{
    public class ConvertEnumStatus
    {
        public static string ConvertToString(Nullable<int> status)
        {
            string stt = "";

            switch (status)
            {
                case 1:
                    stt = EnumStatus.Female.ToString();
                    break;
                case 2:
                    stt = EnumStatus.Male.ToString();
                    break;
                case 3:
                    stt = EnumStatus.Inactive.ToString();
                    break;
                case 4:
                    stt = EnumStatus.Active.ToString();
                    break;
            }
            return stt;
        }

        public static int ConvertToInt(string stt)
        {
            int status = 0;
            switch (stt)
            {
                case "Female":
                    status = 1;
                    break;
                case "Male":
                    status = 2;
                    break;
                case "Inactive":
                    status = 3;
                    break;
                case "Active":
                    status = 4;
                    break;
            }
            return status;
        }
    }
}