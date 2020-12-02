using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter_Creation
{
    pulic class StreamHTML
    {
        private static String HTML_FILE = "newsletterTemp.html";

        public String[] ReadHTMLContent()
        {
            return System.IO.File.ReadAllLines(HTML_FILE);
        }
        public void WriteHTMLContent(String[] content)
        {
            System.IO.File.WriteAllLines(HTML_FILE,content);
        }
    }
}
