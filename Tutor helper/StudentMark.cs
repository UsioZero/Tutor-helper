using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_helper
{
    public class StudentMark
    {
        public StudentMark( int id, string subject, int mark)
        {
            Id = id;
            Subject = subject;
            Mark = mark;
        }

        public StudentMark(string line)
        {
            string[] words = line.Split(';');
            Id = Int32.Parse(words[0]);
            Subject = words[1];
            Mark = Int32.Parse(words[2]);
        }

        public Int32 Id { protected set; get; }
        public string Subject { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"{Id};{Subject};{Mark}";
        }
    }
}
