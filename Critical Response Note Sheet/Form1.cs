using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Critical_Response_Note_Sheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            int conveyChosenNumber = conveychoice.SelectedIndex;
            string conveyChosen = " (no choice picked) ";
            switch(conveyChosenNumber)
            {
                case 0:
                    conveyChosen = "know ";
                    break;
                case 1:
                    conveyChosen = "understand ";
                    break;

                case 2:
                    conveyChosen = "be able to ";
                    break;
            }
            string[] alltextboxes = {
                                        name.Text +
                                        Environment.NewLine +
                                        "In the " + medium.Text + " entitled " + title.Text + ", "
                                        + presenter.Text + " wants us to " + conveyChosen + mainMessage.Text + Environment.NewLine +
                                        "(Add starting sentence here) " + getMainMessage1.Text + " (transition here) " + explain1.Text + Environment.NewLine +
                                        "(Add starting sentence here) " + getMainMessage2.Text + " (transition here) " + explain2.Text + Environment.NewLine +
                                        "(Add starting sentence here) " + getMainMessage3.Text + " (transition here) " + explain3.Text + Environment.NewLine +
                                        connection.Text
                                    };
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.rtf";
            saveFile.Filter = "Rich Text Format (.rtf)|*.rtf";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                System.IO.File.WriteAllLines(saveFile.FileName, alltextboxes);
            }
        }
    }
}
