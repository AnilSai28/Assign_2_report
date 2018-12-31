using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_properties
{
    class Student
    {
        private int studentid;
        private string studentname;
        private int studentmarks;
         
        public Student(int studentid, string studentname, int studentmarks)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.studentmarks = studentmarks;

        }
        public int pstudentid
        {
            get
            {
                return this.studentid;
            }
        }
        public string pstudentname
        {
            get
            {
                return this.studentname;
            }
            set
            {
                this.studentname = value;
            }
        }
        public int pstudentmarks
        {
            get
            {
                return this.studentmarks;
            }
            set
            {
                if(value>100||value<0)
                {
                    this.studentmarks = 0;
                }
                else
                {
                    this.studentmarks = value;
                }
               
            }
        }
    }
}
