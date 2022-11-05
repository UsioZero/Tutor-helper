using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            subjects = database.Subjects;

            InitializeComponent();
            UpdateFilteredStudents();

        }

        private int curPage = 0;
        private int curMaxColumn = 0;
        Database database = new Database();
        private List<Student> filteredStudents;
        private List<string> subjects;

        public void UpdateFilteredStudents()
        {
            curMaxColumn = 0;

            filteredStudents = new List<Student> { };
            List<Student> tmpstud = database.GetStudents();
            for (int i = 0; i < tmpstud.Count; i++)
            {
                filteredStudents.Add(new Student(tmpstud[i].ToString()));
            }

            studentsDataGrid.Rows.Clear();
            studentsDataGrid.Columns.Clear();

            foreach (Student student in filteredStudents)
            {
                student.Marks = student.Marks.FindAll(ma => ma.Subject.ToString() == subjects[curPage].ToString());

                if(student.Marks.Count > curMaxColumn) curMaxColumn = student.Marks.Count;
            }

            curMaxColumn += 2;

            studentsDataGrid.ColumnCount = curMaxColumn;
            studentsDataGrid.Columns[0].Name = "N";
            studentsDataGrid.Columns[1].Name = "Name";;

            //int roInd = 0;
            foreach (Student student in filteredStudents)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(studentsDataGrid);

                dataGridViewRow.Cells[0].Value = student.Id;
                dataGridViewRow.Cells[1].Value = student.Name;
                int rindex = 2;
                foreach(StudentMark mark in student.Marks)
                {
                    dataGridViewRow.Cells[rindex].Value = mark.Mark;
                    rindex++;
                }

                studentsDataGrid.Rows.Add(dataGridViewRow);
            }

            //studentsDataGrid.DataSource = filteredStudents;

            //Edit button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "edit_column";
            editButtonColumn.Text = "Edit";
            int columnIndex = 0;
            if (studentsDataGrid.Columns["edit_column"] == null)
            {
                studentsDataGrid.Columns.Insert(columnIndex, editButtonColumn);
            }

            UpdatePageLabel();
        }

        private void UpdatePageLabel()
        {
            PageLabel.Text = subjects[curPage];
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
            if (curPage != 0)
            {
                curPage--;
                UpdateFilteredStudents();
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (curPage + 1 < subjects.Count)
            {
                curPage++;
                UpdateFilteredStudents();
            }
        }

        private void AddorEditStudent()
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database);
            editForm.Show();
            Hide();
        }
        private void AddorEditStudent(StudentMark student)
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database, student);
            editForm.Show();
            Hide();
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

        //Mark edit
        private void studentsDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == studentsDataGrid.Columns["edit_column"].Index)
            //{
            //    StudentMark studentMark = filteredStudents[curFirstCity + e.RowIndex];

            //    AddorEditStudent(studentMark);
            //}
        }
    }
}
