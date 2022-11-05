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

            //Copy list to filtredStudents
            filteredStudents = new List<Student> { };
            List<Student> tmpstud = database.GetStudents();
            for (int i = 0; i < tmpstud.Count; i++)
            {
                filteredStudents.Add(new Student(tmpstud[i].ToString()));
            }

            //Clear DataGridView
            studentsDataGrid.Rows.Clear();
            studentsDataGrid.Columns.Clear();

            //find marks to selected subject and find columns number
            foreach (Student student in filteredStudents)
            {
                student.Marks = student.Marks.FindAll(ma => ma.Subject.ToString() == subjects[curPage].ToString());

                if(student.Marks.Count > curMaxColumn) curMaxColumn = student.Marks.Count;
            }

            //Add first 2 columns
            curMaxColumn += 2;
            
            //setup first 2 columns names
            studentsDataGrid.ColumnCount = curMaxColumn;
            studentsDataGrid.Columns[0].Name = "N";
            studentsDataGrid.Columns[1].Name = "Name";;

            //Creat and add rows to DataGridView
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

            //Add button column
            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.Name = "Add";
            editButtonColumn.Image = Image.FromFile(@"..\..\pen.png");
            int columnIndex = 0;
            if (studentsDataGrid.Columns["Add"] == null)
            {
                studentsDataGrid.Columns.Insert(columnIndex, editButtonColumn);
            }

            studentsDataGrid.Columns["Add"].Width = 30;

            studentsDataGrid.Columns[1].Width = 20;
            for (int i = 3; i <= curMaxColumn; i++)
            {
                studentsDataGrid.Columns[i].Width = 20;
                studentsDataGrid.Columns[i].DefaultCellStyle.Alignment
                    = DataGridViewContentAlignment.MiddleCenter;
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

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (curPage != 0)
            {
                curPage--;
                UpdateFilteredStudents();
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (curPage + 1 < subjects.Count)
            {
                curPage++;
                UpdateFilteredStudents();
            }
        }

        //Add mark
        private void AddorEditMark(int studentId)
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database, studentId, subjects[curPage]);
            editForm.Show();
            Hide();
        }
        //Edit mark
        private void AddorEditMark(int studentId, int markId)
        {
            AddOrEditForm editForm = new AddOrEditForm(this,
                database, studentId, markId);
            editForm.Show();
            Hide();
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
            if (e.ColumnIndex == studentsDataGrid.Columns["Add"].Index)
            {
                AddorEditMark(e.RowIndex + 1);
            }
            else
            {
                if ((filteredStudents.Find(st => st.Id == e.RowIndex + 1)
                    .Marks.Count >= e.ColumnIndex - 2) &&
                    (e.ColumnIndex > 2))
                {
                    AddorEditMark(e.RowIndex + 1, filteredStudents[e.RowIndex].Marks[e.ColumnIndex - 3].Id);
                }
            }
        }
    }
}
