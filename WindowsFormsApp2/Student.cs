using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        public int idd { get; set; }
        public string namee { get; set; }
        public int sc11 { get; set; }
        public int sc22 { get; set; }
        public int sc33 { get; set; }
        public Student(int id, string name, int sc1, int sc2, int sc3)
        {
            id = idd;
            name = namee;
            sc1 = sc11;
            sc2 = sc22;
            sc3 = sc33;

        }
        public int GetSummaVcexOchkov()
        {
            return sc11 + sc22 + sc33;
        }
    }
}
