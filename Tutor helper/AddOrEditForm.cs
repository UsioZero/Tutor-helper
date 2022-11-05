﻿using System;
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
        private readonly Int32 studentId;
        private readonly Int32 markId = 0;

        //Add mark
        public AddOrEditForm(Mainform parentRE, Database databaseRe, int studentIdRe, string subj)
        {
            InitializeComponent();
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
        public AddOrEditForm(Mainform parentRE, Database databaseRe, int studentIdRe, int markIdRe)
        {
            InitializeComponent();
            parent = parentRE;
            database = databaseRe;
            studentId = studentIdRe;
            markId = markIdRe;

            markNummer.Minimum = 0;
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

        private void backButton_Click(object sender, EventArgs e)
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
    }
}
