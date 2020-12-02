using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsletter_Creation
{
    class ColorPicker
    {
        public void colorDialogPicker(TextBox tb)
        {
            Color color = new Color();
            ColorDialog dialog = new ColorDialog();
           
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
                tb.BackColor = color;
            }
            
        }
    }
}
