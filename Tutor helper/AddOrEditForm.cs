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
        private readonly Mainform parent;
        private readonly Student student;

        public AddOrEditForm(Mainform parentRE, Database databaseRe, Student studentRe)
        {
            InitializeComponent();
            parent = parentRE;
            database = databaseRe;
            student = studentRe;

            markNummer.Minimum = 0;
            markNummer.Maximum = 5;

            subjectComboBox.Items.AddRange(database.Subjects
                .ToArray()
            );

            nameTextBox.Text = student.Name;
            subjectComboBox.SelectedItem = student.Subject;
            markNummer.Value = student.Mark;
        }
        public AddOrEditForm(Mainform parentRE, Database databaseRe)
        {
            InitializeComponent();
            parent = parentRE;
            database = databaseRe;

            markNummer.Minimum = 0;
            markNummer.Maximum = 5;

            subjectComboBox.Items.AddRange(database.Subjects
                .ToArray()
            );
        }

        private void ClothThisPage()
        {
            parent.UpdateFilteredStudents(false);
            parent.Show();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ClothThisPage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student updatedStudent = new Student(
                uuid: student != null ? student.Uuid : database.GetStudents().Max(s => s.Uuid) + 1,
                name: nameTextBox.Text,
                subject: subjectComboBox.SelectedItem.ToString(),
                mark: Convert.ToInt32(markNummer.Value)
            );

            if (student == null)
            {
                database.AddStudent(updatedStudent);
            }
            else
            {
                database.UpdateStudent(updatedStudent);
            }

            MessageBox.Show("Data has been added!", "1234", MessageBoxButtons.OK);
        }
    }
}
