using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaProgram
{
    
    public partial class FormaText : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        
        public FormaText()
        {
            InitializeComponent();
            
    }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBoxProgramName.Text;
            SetValueForText2 = textBoxProgramdesc.Text;
            



    }
    }
}
