using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
namespace ANDRESSEN
{
    public class OperateXml
    {
        
        public  OperateXml() { }
        

        public void ReadXmlInfo(ref List<StudentInfo>  studentsInfo, string fileName)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@fileName);
            //得到根节点
            XmlNode rootNode = xmldoc.SelectSingleNode("grade");
            XmlElement xeroot = (XmlElement)rootNode;

             foreach (XmlNode node1 in rootNode.ChildNodes)
            {
                foreach (XmlNode node2 in node1.ChildNodes)
                {
                    StudentInfo stuInfo = new StudentInfo();

                    XmlElement xe1 = (XmlElement)node1;

                    //得到年级
                    stuInfo.SeniorGrade = xeroot.GetAttribute("name").ToString();

                    //得到班级名字
                    stuInfo.ClassName = xe1.GetAttribute("name").ToString();
                    XmlElement xe2 = (XmlElement)node2;
                    //得到班级类型
                    stuInfo.ClassType = xe2.GetAttribute("name").ToString();
                    //得到学生信息
                    foreach (XmlNode node3 in xe2.ChildNodes)
                    {
                        stuInfo.StudentsInfo.Add(node3.InnerText);
                    }

                    studentsInfo.Add(stuInfo);
                }
                
            }       

        }


        public void WriteXmlInfo(string grade , TreeNode nodes )
        {
            XmlTextWriter myXmlTextWriter = null;
            if ( grade == "高一年级")
                myXmlTextWriter = new XmlTextWriter(@"SENIONE.xml", Encoding.UTF8);
            else if (grade == "高二年级")
                myXmlTextWriter = new XmlTextWriter(@"SENITWO.xml", Encoding.UTF8);
            else if(grade == "高三年级")
                myXmlTextWriter = new XmlTextWriter(@"SENITHREE.xml", Encoding.UTF8);

            myXmlTextWriter.Formatting = Formatting.Indented;

            myXmlTextWriter.WriteStartDocument(false);
           

            myXmlTextWriter.WriteStartElement("grade");
            myXmlTextWriter.WriteAttributeString("name", grade);
     
         
                foreach (TreeNode cn1 in nodes.Nodes)
                {
                    myXmlTextWriter.WriteStartElement("class");
                    myXmlTextWriter.WriteAttributeString("name", cn1.Text);
                    
                    foreach (TreeNode cn2 in cn1.Nodes)
                    {
                        myXmlTextWriter.WriteStartElement("type");
                        myXmlTextWriter.WriteAttributeString("name", cn2.Text);
                        myXmlTextWriter.WriteElementString("sdname", "张三");
                        myXmlTextWriter.WriteElementString("sdgender", "男");
                        myXmlTextWriter.WriteElementString("sdphone", "111");
                        myXmlTextWriter.WriteElementString("sdschool", "高新一中");
                        myXmlTextWriter.WriteEndElement();
                    }
                    

                    myXmlTextWriter.WriteEndElement();
                }           
            

            myXmlTextWriter.WriteEndElement();

        

            myXmlTextWriter.Flush();
            myXmlTextWriter.Close();
        }

        public void ReWriteXml(int serialActiveNode,int classIndex, string grade, string newName )
        {
            XmlDocument xmldoc = new XmlDocument();
            string fileName = "";
            if (grade == "高一年级")
            {
                fileName = "SENIONE.xml";
            }
            else if (grade == "高二年级")
            {
                fileName = "SENITWO.xml";
            }
            else if (grade == "高三年级")
            {
                fileName = "SENITHREE.xml";
            }
                

            xmldoc.Load(@fileName);

            XmlNode root = xmldoc.SelectSingleNode("grade").ChildNodes[classIndex];


            ((XmlElement)root.ChildNodes[serialActiveNode]).SetAttribute("name" , newName);
            xmldoc.Save(fileName);

        }
    }
}
