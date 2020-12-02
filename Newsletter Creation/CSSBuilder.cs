using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter_Creation
{
    class CSSBuilder
    {
        public const String BODY_FONT = "bodyFont";
        public const String BODY_WIDTH = "bodyWidth";
        public const String IMAGE_PADDING = "imagePadding";
        public const String IMAGE_WIDTH = "imageWidth";
        public const String IMAGE_MARGIN_RIGHT = "imageMarginRight";
        public const String CONTENT_MARGIN_RIGHT = "contMarginRight";
        public const String CONTENT_TEXTCOLOR = "contColor";
        public const String CONTENT_FONTSIZE = "contFontSize";
        public const String PARAGRAPH_FONTFAMILY = "paraghFontFamily";
        public const String PARAGRAPH_TEXT_ALIGN = "paraghTextAlign";
        public const String LINK_FONTSTYLE= "linkFontStyle";
        public const String LINK_COLOR = "linkColor";
        public const String FOOTER_FONTFAMILY= "footerFontFamily";
        public const String FOOTER_COLOR= "footerColor";
        public const String FOOTER_PADDING= "footerPadding";
        public const String FOOTET_BACKGROUND = "footerBackground";
        public const String FOOTER_TEXT_FONTFAMILY = "footerTextFontFamily";
        public const String FOOTER_TEXT_TEXTALIGN= "footerTextAlign";
        public const String MAINDIV_FONTFAMILY= "mainDivFontFamily";
        public const String MAINDIV_WIDTH= "mainDivWidth";
        public const String MAINDIV_BACKGROUND_COLOR= "mainDivBackground";

        private String setBodyFontFamily(String fontFamily){return "font-family: " + fontFamily + "; /* bodyFont*/";}
        private String setBodyWidth(String width){ return "width: " + width + "%; /*bodyWidth*/"; }
        private String setImagePadding(String padding){ return "padding: " + padding + "px; /* imagePadding */";}
        private String setImageWidth(String width){return "width: " + width + "%; /*imageWidth*/";}
        private String setImageMarginRight(String marginRight) { return " margin-right: " + marginRight + "%; /*imageMarginRight*/"; }
        private String setContentMarginRight(String marginRight) { return " margin-right:" + marginRight + "%; /*contMarginRight*/"; }
        private String setContentTextColor(String textColor) { return "color: " +textColor +"; /*contColor*/"; }
        private String setContentFontSize(String fontSize) { return "font-size: " + fontSize + "; /*contFontSize*/"; }
        private String setParagraphFontFamily(String fontFamily) { return "font-family: " + fontFamily + "; /*paraghFontFamily*/"; }
        private String setParagraphTextAlign(String textAlign) { return " text-align: " + textAlign + "; /*paraghTextAlign*/"; }
        private String setLinkFontStyle(String fontStyle) { return "font-style:" + fontStyle + "; /* linkFontStyle */"; }
        private String setLinkTextColor(String textColor) { return "color: " +textColor +" /* linkColor */"; }
        private String setFooterFontFamily(String fontFamily) { return "font-family: " + fontFamily + "; /*footerText */"; }
        private String setFooterColor(String color) { return "color:"+color+"; /* footerColor */"; }
        private String setFooterPadding(String padding) { return "padding: "+padding+"%; /* footerPadding */"; }
        private String setFooterBackgroundColor(String color) { return "background:"+color+"; /* footerBackground */"; }
        private String setFooterTextFontFamily(String fontFamily) { return "font-family: " + fontFamily + "; /*footerText */"; }
        private String setFooterTextAlign(String textAlign) { return "text-align: " + textAlign + "; /*footerTextAlign */"; }
        private String setMainDivFontFamily(String fontFamily) { return "font-family: "+fontFamily+"; /* mainDivFontFamily */"; }
        private String setMainDivWidth(String width) { return "width: "+width+"%; /*mainDivWidth */"; }
        private String setMainDivBackgroundColor(String color) { return "background-color:"+color+" ; /* mainDivBackground */"; }

        public String getRow(String input,String styleID)
        {
            String output = "";
            switch (styleID)
            {
                case BODY_FONT: output = setBodyFontFamily(input); break;
                case BODY_WIDTH: output = setBodyWidth(input); break;
                case IMAGE_PADDING: output = setImagePadding(input); break;
                case IMAGE_WIDTH: output = setImageWidth(input); break;
                case IMAGE_MARGIN_RIGHT: output = setImageMarginRight(input); break;
                case CONTENT_MARGIN_RIGHT: output = setContentMarginRight(input); break;
                case CONTENT_TEXTCOLOR: output = setContentTextColor(input); break;
                case CONTENT_FONTSIZE: output = setContentFontSize(input); break;
                case PARAGRAPH_FONTFAMILY: output = setParagraphFontFamily(input); break;
                case PARAGRAPH_TEXT_ALIGN: output = setParagraphTextAlign(input); break;
                case LINK_FONTSTYLE: output = setLinkFontStyle(input); break;
                case FOOTER_FONTFAMILY: output = setFooterFontFamily(input); break;
                case FOOTER_COLOR: output = setFooterColor(input); break;
                case LINK_COLOR: output = setLinkTextColor(input); break;
                case FOOTER_PADDING: output = setFooterPadding(input); break;
                case FOOTET_BACKGROUND: output = setFooterBackgroundColor(input); break;
                case FOOTER_TEXT_FONTFAMILY: output = setFooterTextFontFamily(input); break;
                case FOOTER_TEXT_TEXTALIGN: output = setFooterTextAlign(input); break;
                case MAINDIV_WIDTH: output = setMainDivWidth(input); break;
                case MAINDIV_FONTFAMILY: output = setMainDivFontFamily(input); break;
                case MAINDIV_BACKGROUND_COLOR: output = setMainDivBackgroundColor(input); break;
            }
            return output;
        }
    }
}
