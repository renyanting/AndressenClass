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
                    //得到学生人数
                    foreach (XmlNode node3 in xe2.ChildNodes)
                    {
                        XmlElement xe3 = (XmlElement)node3;
                        Person person = new Person();
                        foreach (XmlNode node4 in xe3.ChildNodes)
                        {
                            person.StuInfo.Add(node4.InnerText);
                            
                        }
                        stuInfo.Students.Add(person);
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

                        myXmlTextWriter.WriteStartElement("student");
                        myXmlTextWriter.WriteElementString("name", "张三");
                        myXmlTextWriter.WriteElementString("gender", "男");
                        myXmlTextWriter.WriteElementString("phonenum", "111");
                        myXmlTextWriter.WriteElementString("school", "高新一中");
                        myXmlTextWriter.WriteElementString("core1", "22");
                        myXmlTextWriter.WriteElementString("core2", "99");
                        myXmlTextWriter.WriteElementString("core3", "55");
                        myXmlTextWriter.WriteEndElement();

                        myXmlTextWriter.WriteStartElement("student");
                        myXmlTextWriter.WriteElementString("name", "李四");
                        myXmlTextWriter.WriteElementString("gender", "男");
                        myXmlTextWriter.WriteElementString("phonenum", "101");
                        myXmlTextWriter.WriteElementString("school", "高新一中");
                        myXmlTextWriter.WriteElementString("core1", "22");
                        myXmlTextWriter.WriteElementString("core2", "99");
                        myXmlTextWriter.WriteElementString("core3", "55");
                        myXmlTextWriter.WriteEndElement();

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

        public bool InsertXML(string grade, string classname,  string typeName, string nodeName)
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

            XmlNode rootNode = xmldoc.SelectSingleNode("grade");

            XmlNode node1 = xmldoc.DocumentElement.SelectSingleNode("grade/class[@name = 'classname']/type");

            XmlNode node2 = node1.Clone();
         
            xmldoc.InsertAfter(node1, node2);

            xmldoc.Save(fileName);
            return true;
        }
    }





}
