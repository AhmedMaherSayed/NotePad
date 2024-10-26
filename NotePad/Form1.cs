using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Note : Form
    {
        string path ="";
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {

        }

        private void rtb_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path == "")
            {
                if(saveFD.ShowDialog() == DialogResult.OK)
                {
                    rtb_txt.SaveFile(saveFD.FileName);
                    this.Close();
                }
            }
            else
            {
                rtb_txt.SaveFile(path);
                this.Close();
            }
            


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFD.ShowDialog() == DialogResult.OK)
            path = openFD.FileName;
            rtb_txt.LoadFile(openFD.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                rtb_txt.SaveFile(saveFD.FileName);
                this.Close();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note n  = new Note();   
            n.ShowDialog();
        }

        //private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (rtb_txt.Text != "")
        //    {
                
        //        if(MessageBox.Show("Save Current Work", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
        //        {
        //            saveToolStripMenuItem_Click(default(object),default(EventArgs));
                    
        //        }

        //    }
            
            
        //}

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_txt.Text != "")
            {

                if (MessageBox.Show("Save Current Work", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(default(object), default(EventArgs));
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("printed successfully","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontD.ShowDialog() == DialogResult.OK)
            {
                if(rtb_txt.SelectedText != "")
                    rtb_txt.SelectionFont = fontD.Font;
                else
                    rtb_txt.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_txt.SelectedText != "")
                    rtb_txt.SelectionColor = colorD.Color;
                else
                    rtb_txt.ForeColor = colorD.Color;
            }
        }

        private void Note_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeToolStripMenuItem_Click(default(object), default(EventArgs));
        }
    }
}
