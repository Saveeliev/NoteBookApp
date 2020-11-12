using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NoteBookApp
{
    public static class FormEditor
    {
        public static void ClearForm(Control control)
        {
            var childs = control.Controls;
            foreach(Control el in childs)
            {
                var controlType = el.GetType();
                if(controlType.Name == "TextBox")
                {
                    var el1 = (TextBox)el;
                    el1.Text = "";
                }
                else if(el.Controls != null)
                {
                    foreach (Control el2 in el.Controls)
                    {
                        ClearForm(el2);
                    }
                }
            }
        }
    }
}