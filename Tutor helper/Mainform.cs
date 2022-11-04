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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            filteredStudents = new List<Student> { };
            InitializeComponent();
            UpdateFilteredStudents();
        }

        private int curFirstCity = 0;
        Database database = new Database();
        private List<Student> filteredStudents;

        public void UpdateFilteredStudents(bool changePosition = true)
        {
            if (changePosition)
            {
                curFirstCity = 0;
            }

            filteredStudents = database.GetStudents();

            studentsDataGrid.DataSource = filteredStudents.Skip(curFirstCity).Take(10)
                .ToList();

            UpdatePageLabel();
        }

        private void UpdatePageLabel()
        {
            int from = curFirstCity + 1;
            int to = curFirstCity + 10 < filteredStudents.Count
                ? curFirstCity + 10
                : filteredStudents.Count;
            PageLabel.Text = $"{from}-{to} of {filteredStudents.Count}";
        }

        private void CityPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OnBack();
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (curFirstCity != 0)
            {
                curFirstCity -= 10;

                studentsDataGrid.DataSource = filteredStudents.Skip(curFirstCity)
                    .Take(10).ToList();
                UpdatePageLabel();
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (curFirstCity <= filteredStudents.Count - 10)
            {
                curFirstCity += 10;
                studentsDataGrid.DataSource = filteredStudents.Skip(curFirstCity)
                    .Take(10).ToList();
                UpdatePageLabel();
            }
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            AddorEditStudent();
        }

        private void AddorEditStudent()
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database);
            editForm.Show();
            Hide();
        }
        private void AddorEditStudent(Student student)
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database, student);
            editForm.Show();
            Hide();
        }   

        private void studentsDataGrid_CellClick(object sender
    , DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Student student = filteredStudents[curFirstCity + e.RowIndex];

                AddorEditStudent(student);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddorEditStudent();
        }

        public void OnBack()
        {
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            OnBack();
        }
    }
}