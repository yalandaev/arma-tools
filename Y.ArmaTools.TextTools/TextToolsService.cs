using System;
using System.Text;
using Y.ArmaTools.Abstractions;

namespace Y.ArmaTools.TextTools
{
    public class TextToolsService: ITextToolsService
    {
        public string GenerateIncrementStringsByTemplate(string template, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                sb.Append(template.Replace("#x#", i.ToString()));
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}