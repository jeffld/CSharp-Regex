using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericApp.Common
{
    public class RegexSamples
    {
                
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        
        public string ParseType()
        {

            string pattern = @".*(.)\.TXT";
            string result;
            result = "";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);

            Match m = r.Match(fileName);

            if (m.Success)
            {
                result = m.Groups[1].Value;
            }

            return result;
        }

    }
}
