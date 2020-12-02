using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsletter_Creation
{
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }

        private void StyleForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(HTMLManager.HTML_FILE);
        }
        private void AddTextChangeListener(object sender, EventArgs e)
        {
            StyleTextChanged listener = new StyleTextChanged();
            listener.OnTextChanged((TextBox)sender, webBrowser, e);

        }
        private void ColorPickerListener(object sender,EventArgs e)
        {

        }
        private static String HexConverter(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void btnContTextColor_Click(object sender, EventArgs e)
        {
            new ColorPicker().colorDialogPicker(contColorBox);
            contColorBox.Text = HexConverter(contColorBox.BackColor);
        }

        private void btnFooterTextColor_Click(object sender, EventArgs e)
        {
            new ColorPicker().colorDialogPicker(footerColorBox);
            footerColorBox.Text = HexConverter(footerColorBox.BackColor);
        }

        private void btnFooterBg_Click(object sender, EventArgs e)
        {
            new ColorPicker().colorDialogPicker(footerBgBox);
            footerBgBox.Text = HexConverter(footerBgBox.BackColor);
        }

        private void btnLinkColor_Click(object sender, EventArgs e)
        {
            new ColorPicker().colorDialogPicker(linkColorBox);
            linkColorBox.Text = HexConverter(linkColorBox.BackColor);
        }
    }
}
