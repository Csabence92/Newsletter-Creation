using System;

namespace Newsletter_Creation
{
    class HtmlStringBuilder
    {
        public static String titleText = "titleText";
        public static String titleImage = "titleImage";
        public static String bodyText = "bodyText";
        public static String footerText = "footeText";
        private String getMarks(String input) { return "\"" + input + "\""; }
        public String modifyID(String getRow,String input)
        {
            String row = "";
            if (getRow.Contains(titleText))
            {
                row = "<n id=" + getMarks(titleText) + ">" + input + "</n>";
            }
            else if (getRow.Contains(titleImage))
            {
                row = "</br><a id=" + getMarks(titleImage) + " href=" + input + "><img class=" + getMarks("image") + " src=cid:bodyID></a>";
            }
            else if (getRow.Contains(bodyText))
            {
                row = "<p id=" + getMarks(bodyText) + " class=" + getMarks("paragh") + ">" + input +  "</p>";
            }
            else if (getRow.Contains(footerText))
            {
                row = "<p id="+getMarks(footerText)+" class="+getMarks("footerText")+">"+input +"</p>";
            }

            return row;
        }
        public String deleteRows(String getRow)
        {
            String row = "";
            String input = "";
            if (getRow.Contains(titleText))
            {
                row = "<n id=" + getMarks(titleText) + "></n>";
            }
            else if (getRow.Contains(titleImage))
            {
                row = "</br><a id=" + getMarks(titleImage) + " href=><img class=" + getMarks("image") + " src=cid:bodyID></a>";
            }
            else if (getRow.Contains(bodyText))
            {
                row = "<p id=" + getMarks(bodyText) + " class=" + getMarks("paragh") + "></p>";
            }
            else if (getRow.Contains(footerText))
            {
                row = "<p id=" + getMarks(footerText) + " class=" + getMarks("footerText") + "></p>";
            }
            return row;

        }
    }
}
