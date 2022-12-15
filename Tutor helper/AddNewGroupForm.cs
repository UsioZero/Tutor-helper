using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tutor_helper
{
    public partial class AddNewGroupForm : Form
    {
        public AddNewGroupForm(MainForm parent)
        {
            InitializeComponent();

            this.parent = parent;

            //Appereance place
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //back -border
            backBo.TabStop = false;
            backBo.FlatStyle = FlatStyle.Flat;
            backBo.FlatAppearance.BorderSize = 0;
            backBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //save -border
            saveBo.TabStop = false;
            saveBo.FlatStyle = FlatStyle.Flat;
            saveBo.FlatAppearance.BorderSize = 0;
            saveBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button3 -border
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //Combobox
            comboBox1.SelectedIndex = 0;
        }

        MainForm parent;

        private void ClothThisPage()
        {
            parent.Show();
            Close();
        }

        private void backBo_Click(object sender, EventArgs e)
        {
            ClothThisPage();
        }

        private void saveBo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data has been updated!", "", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
            Hide();
        }
    }
}
