using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchingMovieMicroservice
{
    public class FilteringOperations
    {
        public static string FilterKeyword(string keyword)
        {

            return Regex.Replace(keyword, @"\s", "").ToLower();
        }
    }
}
