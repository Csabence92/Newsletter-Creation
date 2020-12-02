using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsletter_Creation
{
    class StyleTextChanged : CSSBuilder
    {
       public void OnTextChanged(TextBox textbox,WebBrowser browser, EventArgs e)
        {
            String id = getID(textbox);
            ModifyStyle(id, browser, textbox.Text);
        }
        private String getID(TextBox textBox)
        {
            String output = "";
            switch (textBox.Name.ToString())
            {
                case "bodyFontFamilyBox": output = BODY_FONT; break;
                case "bodyWidthBox": output = BODY_WIDTH; break;
                case "imagePaddingBox": output = IMAGE_PADDING; break;
                case "imageWidthBox": output = IMAGE_WIDTH; break;
                case "imageMarginRightBox": output = IMAGE_MARGIN_RIGHT;break;
                case "contMarginRightBox": output = CONTENT_MARGIN_RIGHT;break;
                case "contColorBox": output = CONTENT_TEXTCOLOR;break;
                case "contFontSizeBox": output = CONTENT_FONTSIZE;break;
                case "paraghFontFamilyBox": output = PARAGRAPH_FONTFAMILY;break;
                case "paraghTextAlignBox": output = PARAGRAPH_TEXT_ALIGN;break;
                case "linkFontStyleBox": output = LINK_FONTSTYLE;break;
                case "linkColorBox": output = LINK_COLOR;break;
                case "footerFontFamilyBox":output = FOOTER_FONTFAMILY;break;
                case "footerColorBox":output = FOOTER_COLOR;break;
                case "footerPaddingBox":output = FOOTER_PADDING;break;
                case "footerBgBox":output = FOOTET_BACKGROUND;break;
                case "footerTextFontFamilyBox":output = FOOTER_TEXT_FONTFAMILY;break;
                case "footerTextTextAlignBox":output = FOOTER_TEXT_TEXTALIGN;break;
            }
            return output;

        }
        private void ModifyStyle(String id, WebBrowser browser,String text)
        {
            String[] htmlRows = new HTMLManager().ReadHTMLContent();
            for (int i = 0; i < htmlRows.Length; i++){
                if (htmlRows[i].Contains(id))
                {
                    htmlRows[i] = getRow(text, id);
                    break;
                }
            }
            new HTMLManager().WriteHTMLContent(htmlRows);
            browser.Navigate(HTMLManager.HTML_FILE);
        }
    }
}
