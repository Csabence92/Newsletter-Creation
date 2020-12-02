using System;
using System.IO;

namespace Newsletter_Creation
{
    class HTMLManager
    {
        private static char separator = Path.DirectorySeparatorChar;
        private static string projectDir = Directory.GetCurrentDirectory() + separator;
        public static String HTML_FILE = projectDir + "newsletterTemp.html";

        public String[] ReadHTMLContent()
        {
            return System.IO.File.ReadAllLines(HTML_FILE);
        }
        public void WriteHTMLContent(String[] content)
        {
            System.IO.File.WriteAllLines(HTML_FILE, content);
        }
    }
}
