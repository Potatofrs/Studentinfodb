using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentinfo
{
    class Student
    {
        private string idnum;
        private string score;
        private string lname;
        private string fname;

        public string IDno
        {
            get { return idnum; }
            set { idnum = value; }
        }
        public string QuizScore
        {
            get { return score; }
            set { score = value; }
        }

        public string Lastname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Firstname
        {
            get { return fname; }
            set { fname = value; }
        }







    }





}
