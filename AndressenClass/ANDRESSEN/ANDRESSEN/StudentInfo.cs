using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESSEN
{
    //一个春季班对应的学生信息，所以一个xml有四个模板
    public class StudentInfo
    {
        private string seniorGrade; //年级  高一
        private string className;   //班级名    2019年好学班
        private string classType;   //班级类型   春季班
        private List<Person> students = new List<Person>();

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
       
        public List<Person> Students
        {
            get { return students; }
            set { students = value; }
        }

       
    }

    public class Person
    {
        private List<string> stuInfo = new List<string>();
        public List<string> StuInfo
        {
            get { return stuInfo; }
            set { stuInfo = value; }
        }
    }
}
