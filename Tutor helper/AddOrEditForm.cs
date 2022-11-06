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
    public partial class AddOrEditForm : Form
    {
        private readonly Database database;
        private readonly JournalForm parent;
        private readonly Int32 studentId;
        private readonly Int32 markId = 0;

        //Add mark
        public AddOrEditForm(JournalForm parentRE, Database databaseRe, int studentIdRe, string subj)
        {
            InitializeComponent();

            //right -border
            backBo.TabStop = false;
            backBo.FlatStyle = FlatStyle.Flat;
            backBo.FlatAppearance.BorderSize = 0;
            backBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //right -border
            saveBo.TabStop = false;
            saveBo.FlatStyle = FlatStyle.Flat;
            saveBo.FlatAppearance.BorderSize = 0;
            saveBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button3 -border
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //Form Name
            this.Text = "Add";

            //Appereance place
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            parent = parentRE;
            database = databaseRe;
            studentId = studentIdRe;

            markNummer.Minimum = 0;
            markNummer.Maximum = 5;

            subjectComboBox.Items.AddRange(database.Subjects
                .ToArray()
            );

            subjectComboBox.SelectedItem = subj;

            nameTextBox.Text = database.GetStudents()
                .Find(st => st.Id == studentId).Name;
        }

        //Edit Mark
        public AddOrEditForm(JournalForm parentRE, Database databaseRe, int studentIdRe, int markIdRe)
        {
            InitializeComponent();


            //Form Name
            this.Text = "Edit";

            //Appereance place
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //right -border
            backBo.TabStop = false;
            backBo.FlatStyle = FlatStyle.Flat;
            backBo.FlatAppearance.BorderSize = 0;
            backBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //right -border
            saveBo.TabStop = false;
            saveBo.FlatStyle = FlatStyle.Flat;
            saveBo.FlatAppearance.BorderSize = 0;
            saveBo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button3 -border
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            parent = parentRE;
            database = databaseRe;
            studentId = studentIdRe;
            markId = markIdRe;

            markNummer.Minimum = 1;
            markNummer.Maximum = 5;

            markNummer.Value = database.GetStudents()
                .Find(st => st.Id == studentId)
                .Marks.Find(ma => ma.Id == markId).Mark;

            subjectComboBox.Items.AddRange(database.Subjects
                .ToArray()
            );

            subjectComboBox.SelectedItem = database.GetStudents()
                .Find(st => st.Id == studentId)
                .Marks.Find(ma => ma.Id == markId)
                .Subject;

            nameTextBox.Text = database.GetStudents()
                .Find(st => st.Id == studentId).Name;
        }

        private void ClothThisPage()
        {
            parent.UpdateFilteredStudents();
            parent.Show();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ClothThisPage();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (markId == 0)
            {
                database.AddMark(studentId, new StudentMark(
                        id: database.GetStudents().Find(st => st.Id == studentId)
                                .Marks.Count + 1,
                        subject: subjectComboBox.SelectedItem.ToString(),
                        mark: Convert.ToInt32(markNummer.Value)
                    ));

                MessageBox.Show("Data has been added!", "", MessageBoxButtons.OK);
            }
            else
            {
                database.UpdateMark(studentId, new StudentMark(
                        id: markId,
                        subject: subjectComboBox.SelectedItem.ToString(),
                        mark: Convert.ToInt32(markNummer.Value)
                    ));

                MessageBox.Show("Data has been updated!", "", MessageBoxButtons.OK);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
            Hide();
        }
    }
}
