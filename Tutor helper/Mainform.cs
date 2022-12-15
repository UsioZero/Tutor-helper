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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Appereance place
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //button1 -border
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            
            //button2 -border
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button1 -border
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button1 -border
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JournalForm journalForm = new JournalForm(this);
            journalForm.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            OnExit();
        }

        private void OnExit()
        {
            Close();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OnExit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewGroupForm newGroupForm = new AddNewGroupForm(this);
            newGroupForm.Show();
            Hide();
        }
    }
}
