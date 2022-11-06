using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_helper
{
    public partial class HelpForm : Form
    {
        Form parent;

        public HelpForm(Form parent)
        {
            InitializeComponent();

            //Appereance place
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            label1.Text = "To open journal click 'Journal'\n" +
                "To change subject in Journal page click 'left' or 'right'\n" +
                "To change mark in Journal page click on it. To add mark click on 'pen'\n" +
                "To add/change mark in Add/Edit page click set your mark and click on save button\n" +
                "To return to previous page or close page click on exit button";

            //button1 -border
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            this.parent = parent;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }
    }
}
