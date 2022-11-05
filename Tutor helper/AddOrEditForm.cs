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
        private readonly StudentMark mark;

        public AddOrEditForm(Mainform parentRE, Database databaseRe, Student studentRe, StudentMark markRe)
        {
            InitializeComponent();
            parent = parentRE;
            database = databaseRe;
            student = studentRe;
            mark = markRe;

            markNummer.Minimum = 0;
            markNummer.Maximum = 5;

            //subjectComboBox.Items.AddRange(database.Subjects
            //    .ToArray()
            //);

            //nameTextBox.Text = student.Name;
            //subjectComboBox.SelectedItem = student.Subject;
            //markNummer.Value = student.Mark;
        }
        public AddOrEditForm(Mainform parentRE, Database databaseRe)
        {
            //InitializeComponent();
            //parent = parentRE;
            //database = databaseRe;

            //markNummer.Minimum = 0;
            //markNummer.Maximum = 5;

            //subjectComboBox.Items.AddRange(database.Subjects
            //    .ToArray()
            //);
        }

        private void ClothThisPage()
        {
            parent.UpdateFilteredStudents();
            parent.Show();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ClothThisPage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //StudentMark updatedStudent = new StudentMark(
            //    uuid: "",
            //    name: nameTextBox.Text,
            //    markid: student != null ? student.Uuid : (database.GetStudents().Max(s => s.Uuid) + 1),
            //    subject: subjectComboBox.SelectedItem.ToString(),
            //    mark: Convert.ToInt32(markNummer.Value)
            //);

            //if (student == null)
            //{
            //    database.AddMark(updatedStudent);
            //}
            //else
            //{
            //    database.UpdateMark(updatedStudent);
            //}

            //MessageBox.Show("Data has been added!", "", MessageBoxButtons.OK);
        }
    }
}
