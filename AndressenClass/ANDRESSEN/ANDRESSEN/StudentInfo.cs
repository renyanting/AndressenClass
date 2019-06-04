using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESSEN
{
    public class StudentInfo
    {
        private string seniorGrade; //年级  高一
        private string className;   //班级名    2019年好学班
        private string classType;   //班级类型   春季班
        private List<string> stuInfo = new List<string>();

     

        public StudentInfo() { }


        public string SeniorGrade
        {
            get { return seniorGrade; }
            set { seniorGrade = value; }
        }

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        public string ClassType
        {
            get { return classType; }
            set { classType = value; }
        }

        public List<string> StudentsInfo
        {
            get { return stuInfo; }
            set { stuInfo = value; }
        }

       
    }
}
