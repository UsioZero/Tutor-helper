using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tutor_helper
{
    public class Student
    {
        public Student(int id, string name, List<StudentMark> marks)
        {
            Id = id;
            Name = name;    
            Marks = marks;
        }

        public Student(string line)
        {
            string[] words = line.Split(';');
            Id = Int32.Parse(words[0]);
            Name = words[1];
            Marks = new List<StudentMark> { };

            int count = Int32.Parse(words[2]);
            for (int i = 0; i < count; i++)
            {
                Marks.Add(new StudentMark(
                    words[3 + i * 3] + ";" + words[4 + i * 3] + ";" + words[5 + i * 3]
                    ));
            }
        }

        public Int32 Id { protected set; get; }
        public string Name { get; set; }
        public List<StudentMark> Marks { get; set;}

        public override string ToString()
        {
            string returnS = $"{Id};{Name};{Marks.Count}";
            for(int i = 0; i < Marks.Count; i++)
            {
                returnS += ";" + Marks[i].ToString();
            }

            return returnS;
        }
    }
}
