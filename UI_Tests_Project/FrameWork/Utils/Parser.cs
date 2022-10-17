using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class Parser
    {
        public static IList<string> StringParse(string parseString)
        {
            var split = Regex.Split(parseString, "\r\\n");

            return split;
        }
    }
}