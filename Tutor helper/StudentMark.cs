using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_helper
{
    public class StudentMark
    {
        public StudentMark( int uuid, string name, int markid, string subject, int mark)
        {
            Uuid = uuid;
            Name = name;
            Markid = markid;
            Subject = subject;
            Mark = mark;
        }

        public StudentMark(string line)
        {
            string[] words = line.Split(';');
            Uuid = Int32.Parse(words[0]);
            Name = words[1];
            Markid = Int32.Parse(words[2]);
            Subject = words[3];
            Mark = Int32.Parse(words[4]);
        }

        public Int32 Uuid { protected set; get; }
        public string Name { get; set; }
        public Int32 Markid { protected set; get; }
        public string Subject { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"{Uuid};{Name};{Markid};{Subject};{Mark}";
        }
    }
}
