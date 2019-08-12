using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save file to the hard drive
            //file is saved to the location selected in the file save dialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName); //saves text file
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = ""; //load dialog box with no default file name
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName); //loads file from drive into rich text box
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //shows message from exception object;
                }
            }
        }

        private void TxtOld_DoubleClick(object sender, EventArgs e)
        {
            if (txtOld.Text.Trim().Length > 0) //make sure box isn't empty
            {
                int start = richTextBox1.Find(txtOld.Text); //search for start position of the old text in the text box
                richTextBox1.Select(start, txtOld.Text.Length); // select found text in rich text box

                richTextBox1.SelectionBackColor = Color.Yellow; //changes selected background color to yellow
            }
        }

        private void TxtNew_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
