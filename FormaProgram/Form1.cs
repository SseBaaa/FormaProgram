using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            checkBoxAction.Checked = true;
           
           
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            if(comboBoxRun.Text == "Paint")
            {
                Process.Start("mspaint.exe");
            }
            if(comboBoxRun.Text == "Notepad")
            {
                Process.Start("notepad.exe");
            }
        }

        private void checkBoxAction_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAction.Checked)
            {
                groupBoxStart.Enabled = true;
            }
            if(!checkBoxAction.Checked)
            {
                groupBoxStart.Enabled = false;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormaText formaText = new FormaText();
            formaText.Show();
           
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavjestenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dali ste sugurni da želite zatvoriti ovu aplikaciju" , "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (result == DialogResult.No)
            {

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxName.Text = FormaText.SetValueForText1;
            textBoxDescription.Text = FormaText.SetValueForText2;
        }
    }
}
