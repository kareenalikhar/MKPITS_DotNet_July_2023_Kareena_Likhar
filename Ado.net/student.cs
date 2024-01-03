using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_sqlcon
{
    class student
    {
        public int rno {  get; set; }
        public string studname {  get; set; }
        public string gender {  get; set; }
        public string hobby {  get; set; }
        public string city {  get; set; }
        public string dob {  get; set; }

        public student(int rno, string studname, string gender, string hobby, string city, string dob)
        {
            this.rno = rno;
            this.studname = studname;
            this.gender = gender;
            this.hobby = hobby;
            this.city = city;
            this.dob = dob;
        }
    }
}
