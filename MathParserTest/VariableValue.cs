/*
 * Author: Patrik Lundin, patrik@lundin.info
 * Web: http://www.lundin.info
 * 
 * Source code released under the Microsoft Public License (Ms-PL) 
 * http://www.microsoft.com/en-us/openness/licenses.aspx#MPL
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathParserTestNS
{
    public partial class VariableValue : UserControl
    {
        public VariableValue()
        {
            InitializeComponent();
        }

        public string Variable 
        { 
            get { return txtVariable.Text; }
            set { txtVariable.Text = value; }
        }

        public string Value 
        { 
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
    }
}
