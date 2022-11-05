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

        public List<StudentMark> Students { private set; get; }
        public List<string> Subjects { private set; get; }

        private void GetStudentsFromFile()
        {
            Students = new List<StudentMark>();
            Subjects = new List<string>();

            StreamReader reader = new StreamReader(studentsPath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Students.Add(new StudentMark(line));
            }
            reader.Close();

            StreamReader reader1 = new StreamReader(subjectsPath);
            string line1;
            while ((line1 = reader1.ReadLine()) != null)
            {
                Subjects.Add(line1);
            }
            reader1.Close();
        }

        public List<StudentMark> GetStudents()
        {
            return Students.OrderBy(Students => Students.Mark).ToList()
                .OrderBy(Students => Students.Subject).ToList()
                .OrderBy(Students => Students.Uuid).ToList();
        }

        public void AddMark(StudentMark newStudent)
        {
            Students.Add(newStudent);

            StreamWriter writer
                = new StreamWriter(studentsPath, append: true);
            writer.WriteLine(newStudent.ToString());
            writer.Close();
        }

        public void UpdateMark(StudentMark updated)
        {
            int index = Students.FindIndex(student => student.Uuid == updated.Uuid);

            Students[index] = updated;
            SaveStudentsToFile();
        }

        public void SaveStudentsToFile()
        {
            StreamWriter writer = new StreamWriter(studentsPath);
            foreach (StudentMark student in Students)
            {
                writer.WriteLine(student.ToString());
            }
            writer.Close();
        }
    }
}
