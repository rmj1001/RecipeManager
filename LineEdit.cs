using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace connRoy_FinalProject_RecipeManager
{
    public partial class LineEdit : Form
    {
        public string? lineContent;

        public LineEdit(string? content)
        {
            InitializeComponent();

            this.lineContent = content;
            lineText.Text = this.lineContent;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Make sure user did not type in delimiter characters in line editing
            if (Recipe.ContainsDelimiter(lineText.Text))
            {
                Recipe.DelimiterError();
                return;
            }

            // Make sure content is not blank
            if (Recipe.StringIsEmpty(lineText.Text))
            {
                MessageBox.Show("You cannot save empty content.");
                return;
            }

            // Save contents of text box to line string and close window
            this.lineContent = lineText.Text;
            this.Close();
        }

        public string? Output()
        {
            return this.lineContent;
        }
    }
}
