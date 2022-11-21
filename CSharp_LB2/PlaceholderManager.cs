using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CSharp_LB3
{
    //текст-підказка для TextBox
    public static class PlaceholderManager
    {
        public static void AddPlaceholder(this TextBox tb, string placeholderText)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholderText)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholderText;
                }
            };
        }
    }
}
