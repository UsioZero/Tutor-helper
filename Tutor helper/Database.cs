using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tutor_helper
{

    public class Database
    {

        private static readonly string studentsPath = @"..\..\students.txt";
        private static readonly string subjectsPath = @"..\..\subjects.txt";

        public Database()
        {
            GetStudentsFromFile();
        }

        public List<Student> Students { private set; get; }
        public List<string> Subjects { private set; get; }

        private void GetStudentsFromFile()
        {
            Students = new List<Student>();
            Subjects = new List<string>();

            StreamReader reader = new StreamReader(studentsPath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Students.Add(new Student(line));
            }
            reader.Close();

            reader = new StreamReader(subjectsPath);
            string line1;
            while ((line1 = reader.ReadLine()) != null)
            {
                Subjects.Add(line1);
            }
            reader.Close();
        }

        public List<Student> GetStudents()
        {
            return Students.OrderBy(Students => Students.Id).ToList();
        }

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);

            StreamWriter writer
                = new StreamWriter(studentsPath, append: true);
            writer.WriteLine(newStudent.ToString());
            writer.Close();
        }

        public void AddMark(int studentId, StudentMark newMark)
        {
            Students.Find(st => st.Id == studentId)
                .Marks.Add(newMark);

            SaveStudentsToFile();
        }

        public void UpdateMark(int studentId, StudentMark updated)
        {
            Students.Find(st => st.Id == studentId)
                .Marks.Find(ma => ma.Id == updated.Id).Mark = updated.Mark;

            SaveStudentsToFile();
        }

        public void SaveStudentsToFile()
        {
            StreamWriter writer = new StreamWriter(studentsPath);
            foreach (Student student in Students)
            {
                writer.WriteLine(student.ToString());
            }
            writer.Close();
        }
    }
}
