using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tutor_helper
{
    internal class Student
    {
        public Student(int uuid, string name, int markid, string subject, int mark)
        {
            Uuid = uuid;
            Name = name;
            Markid = markid;
            Subject = subject;
            Mark = mark;
        }


    }
}
