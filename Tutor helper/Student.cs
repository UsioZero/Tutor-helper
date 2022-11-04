using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_helper
{
    public class Student
    {
        public Student(int uuid, string name, string subject, int mark)
        {
            Uuid = uuid;
            Name = name;
            Subject = subject;
            Mark = mark;
        }

        public Student(string line)
        {
            string[] words = line.Split(';');
            Uuid = Int32.Parse(words[0]);
            Name = words[1];
            Subject = words[2];
            Mark = Int32.Parse(words[3]);
        }

        public Int32 Uuid { protected set; get; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"{Uuid};{Name};{Subject};{Mark}";
        }
    }
}
