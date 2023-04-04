using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormNotepad
{
    public partial class MainNotepadForm : Form
    {
        public MainNotepadForm()
        {
            InitializeComponent();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainNoteBox_TextChanged(object sender, EventArgs e)
        {
            if (MainNoteBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                regularToolStripMenuItem.Enabled = true;
                boldToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
                strikeThoughToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                regularToolStripMenuItem.Enabled = false;
                boldToolStripMenuItem.Enabled = false;
                italicToolStripMenuItem.Enabled = false;
                underlineToolStripMenuItem.Enabled = false;
                strikeThoughToolStripMenuItem.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any questions, you may be using ChatGPT \n \n Thanks for read.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
            selectAllToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectAll();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectionFont = new Font(MainNoteBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectionFont = new Font(MainNoteBox.Font, FontStyle.Italic);
        }

        private void strikeThoughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectionFont = new Font(MainNoteBox.Font, FontStyle.Strikeout);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectionFont = new Font(MainNoteBox.Font, FontStyle.Underline);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoteBox.SelectionFont = new Font(MainNoteBox.Font, FontStyle.Regular);
        }
    }
}
