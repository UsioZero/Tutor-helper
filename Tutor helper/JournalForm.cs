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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tutor_helper
{

    public partial class JournalForm : Form
    {
        public JournalForm(MainForm mainForm)
        {
            parent = mainForm;
            filteredStudents = new List<Student> { };
            subjects = database.Subjects;

            InitializeComponent();

            //GroupComBo
            GroupComBo.SelectedIndex = 0;

            //Appereance place
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //exit button -border
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //left button -border
            leftButtom.TabStop = false;
            leftButtom.FlatStyle = FlatStyle.Flat;
            leftButtom.FlatAppearance.BorderSize = 0;
            leftButtom.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //right -border
            rightButton.TabStop = false;
            rightButton.FlatStyle = FlatStyle.Flat;
            rightButton.FlatAppearance.BorderSize = 0;
            rightButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //button3 -border
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            UpdateFilteredStudents();
        }

        private int curPage = 0;
        private int curMaxColumn = 0;
        Database database = new Database();
        private List<Student> filteredStudents;
        private List<string> subjects;
        MainForm parent;

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
            studentsDataGrid.Columns[1].Name = "Name";

            //data
            for (int i = 2; i < curMaxColumn; i++)
            {
                studentsDataGrid.Columns[i].Name = $"{11+i}.12";
            }

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
            editButtonColumn.Image = Image.FromFile(@"..\..\pen20.png");
            int columnIndex = 0;
            if (studentsDataGrid.Columns["Add"] == null)
            {
                studentsDataGrid.Columns.Insert(columnIndex, editButtonColumn);
            }

            studentsDataGrid.Columns["Add"].Width = 30;

            studentsDataGrid.Columns[1].Width = 20;
            for (int i = 3; i <= curMaxColumn; i++)
            {
                studentsDataGrid.Columns[i].Width = 39;
                studentsDataGrid.Columns[i].DefaultCellStyle.Alignment
                    = DataGridViewContentAlignment.MiddleCenter;
            }

            //size of datagrid
            studentsDataGrid.Size = new Size(203 + 39 * (curMaxColumn - 2), studentsDataGrid.Size.Height);

            //rightbutton location
            rightButton.Location = new Point(studentsDataGrid.Location.X + studentsDataGrid.Size.Width + 6
                , rightButton.Location.Y);

            CellsFilter();

            UpdatePageLabel();
        }

        private void CellsFilter()
        {
            foreach (DataGridViewRow row in studentsDataGrid.Rows)
            {
                Student tmpStudent = filteredStudents
                    .Find(st => st.Id == Convert.ToInt32(row.Cells[1].Value));

                for (int i = 0; i < tmpStudent.Marks.Count; i++)
                {
                    //label2.Text += kMark.ToString() + ";";
                    row.Cells[3 + i].Style.BackColor = Color.Red;
                    if (tmpStudent.Marks[i].Mark >= 60)
                    {
                        row.Cells[3 + i].Style.BackColor = Color.Yellow;
                    }
                    if (tmpStudent.Marks[i].Mark >= 90)
                    {
                        row.Cells[3 + i].Style.BackColor = Color.Green;
                    }

                }
            }
        }
        private void UpdatePageLabel()
        {
            //SubjComBo
            SubjComBo.SelectedItem = subjects[curPage];
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
            parent.Show();
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
                if (e.ColumnIndex > 2)
                {
                    if (e.RowIndex == -1)
                    {
                        EditDateForm editDateForm = new EditDateForm(this);
                        editDateForm.Show();
                        Hide();
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

        private void button3_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
            Hide();
        }

        private void SubjComBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            curPage = SubjComBo.SelectedIndex;
            UpdateFilteredStudents();
        }
    }
}
