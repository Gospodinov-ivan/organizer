using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class StudentInfo
    {
        public string surname { get; set; }
        public double roundedMark { get; set; }
        public int noAttistation { get; set; }
        public StudentInfo(string surname, double mark, int noAttistation)
        {
            roundedMark = mark;
            this.noAttistation = noAttistation;
            this.surname = surname; 
        }
    }
}
