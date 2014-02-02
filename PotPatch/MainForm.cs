using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PotPatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openUntranslated_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                untranslatedPath.Text = openFile.FileName;
            }
        }

        private void openTranslated_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                translatedPath.Text = openFile.FileName;
            }
        }

        private void patchAndSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(translatedPath.Text))
            {
                MessageBox.Show(this, "Translated file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(untranslatedPath.Text))
            {
                MessageBox.Show(this, "Unranslated file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = PotHelper.Combine(translatedPath.Text, untranslatedPath.Text);

            if (saveFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllLines(saveFile.FileName, lines, Encoding.UTF8);
            }
        }
    }
}
