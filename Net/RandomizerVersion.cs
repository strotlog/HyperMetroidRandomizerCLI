using System;
using System.Text.RegularExpressions;

namespace SuperMetroidRandomizer.Net
{
    public static class RandomizerVersion
    {
        public static string Current = "1.0";

        public static string CurrentDisplay
        {
            get
            {
                var retVal = Current;

                if (retVal.Contains("p"))
                {
                    retVal = string.Format("{0})", retVal.Replace("P", " (preview "));
                }

                return retVal;
            }
        }

    }
}
