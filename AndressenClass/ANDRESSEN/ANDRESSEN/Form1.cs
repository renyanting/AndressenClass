using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANDRESSEN
{
    public partial class FORMXIE : Form
    {
        //鼠标选中节点的名字
        private string nameActiveNode;
        //鼠标选中节点的序号
        private int serialActiveNode;
     
        //xml学生信息
        public static List<StudentInfo> StuInfo_GradeOne = new List<StudentInfo>();
        public static List<StudentInfo> StuInfo_GradeTwo = new List<StudentInfo>();
        public static List<StudentInfo> StuInfo_GradeThr= new List<StudentInfo>();
        //xml班级名称
        public static List<string> hxNameGOne = new List<string>(); //高一好学班名
        public static List<string> hxNameGTwo = new List<string>() ;//高二好学班名
        public static List<string> hxNameGThr = new List<string>() ;//高三好学班名
        public static List<string> jjNameGOne = new List<string>() ;//高一精进班名
        public static List<string> jjNameGTwo = new List<string>(); //高二精进班名
        public static List<string> jjNameGThr = new List<string>() ;//高三精进班名

        List<StudentInfo> studentsInfo = new List<StudentInfo>();

        OperateXml operate = new OperateXml();
        public FORMXIE()
        {
            InitializeComponent();
            treeViewXieSet();

            LoadXmlInfo();
        }

        private void FORMXIE_Load(object sender, EventArgs e)
        {

           
           
            //operate.WriteXmlInfo();
        }
        public void LoadXmlInfo()
        {         
            operate.ReadXmlInfo(ref StuInfo_GradeOne, "SENIONE.xml");
            operate.ReadXmlInfo(ref StuInfo_GradeTwo, "SENITWO.xml");
            operate.ReadXmlInfo(ref StuInfo_GradeThr, "SENITHREE.xml");

            SetClassName(StuInfo_GradeOne);
            SetClassName(StuInfo_GradeTwo);
            SetClassName(StuInfo_GradeThr);

        }

        public void SetClassName(List<StudentInfo>  StuInfo)
        {
            //hxNameGOne.Clear();
            //hxNameGTwo.Clear();
            //hxNameGThr.Clear();
            //jjNameGOne.Clear();
            //jjNameGTwo.Clear();
            //jjNameGThr.Clear();

            foreach (StudentInfo sdi in StuInfo)
            {
                if (sdi.SeniorGrade == "高一年级" && sdi.ClassName == "2019年好学班")
                {
                    hxNameGOne.Add(sdi.ClassType);
                }
                else if (sdi.SeniorGrade == "高一年级" && sdi.ClassName == "2019年精进班")
                {
                    jjNameGOne.Add(sdi.ClassType);
                }
                else if (sdi.SeniorGrade == "高二年级" && sdi.ClassName == "2019年好学班")
                {
                    hxNameGTwo.Add(sdi.ClassType);
                }
                else if (sdi.SeniorGrade == "高二年级" && sdi.ClassName == "2019年精进班")
                {
                    jjNameGTwo.Add(sdi.ClassType);
                }
                else if (sdi.SeniorGrade == "高三年级" && sdi.ClassName == "2019年好学班")
                {
                   hxNameGThr.Add(sdi.ClassType);
                }
                else if (sdi.SeniorGrade == "高三年级" && sdi.ClassName == "2019年精进班")
                {
                    jjNameGThr.Add(sdi.ClassType);
                }
            }

        }


        public TreeNode treeView_Grade(string text)
        {
            TreeNode node1 = new TreeNode(Text = text);
            TreeNode node1_1 = new TreeNode(Text = "2019年好学班");
            TreeNode node1_2 = new TreeNode(Text = "2019年精进班");

            node1.Nodes.Add(node1_1);
            node1.Nodes.Add(node1_2);
            TreeNode node1_1_1 = new TreeNode(Text = "春季班");//null;
            TreeNode node1_1_2 = new TreeNode(Text = "暑假班");//null;
            TreeNode node1_2_1 = new TreeNode(Text = "春季班");//null;
            TreeNode node1_2_2 = new TreeNode(Text = "暑假班");// null;
  

            TreeNode[] childnode1_1 = new TreeNode[] { node1_1_1, node1_1_2 };
            TreeNode[] childnode1_2 = new TreeNode[] { node1_2_1, node1_2_2 };
            node1_1.Nodes.AddRange(childnode1_1);
            node1_2.Nodes.AddRange(childnode1_2);

            //添加右键快捷菜单
            node1_1_1.ContextMenuStrip = this.contextMenuStrip2;
            node1_1_2.ContextMenuStrip = this.contextMenuStrip2;
            node1_2_1.ContextMenuStrip = this.contextMenuStrip2;
            node1_2_2.ContextMenuStrip = this.contextMenuStrip2;

            operate.WriteXmlInfo(text, node1);

            return node1;
        }


        public void treeViewXieSet()
        {
            treeViewXie.Nodes.Clear();
         
            TreeNode node1 = treeView_Grade("高一年级");
            TreeNode node2 = treeView_Grade("高二年级");
            TreeNode node3 = treeView_Grade("高三年级");

            TreeNode[] nodes = new TreeNode[] { node1, node2, node3 };
           
            this.treeViewXie.Nodes.AddRange(nodes);         
            this.treeViewXie.SelectedNode = node1;
            this.treeViewXie.ExpandAll();

            //
            //operate.WriteXmlInfo("高二年级", node2);
            //operate.WriteXmlInfo("高三年级", node3);

        }

        private void ToolStripMenuItem_copynew_Click(object sender, EventArgs e)
        {
            nameActiveNode = this.treeViewXie.SelectedNode.Text;
            serialActiveNode = this.treeViewXie.SelectedNode.Index;

            TreeNode node = new TreeNode();
            node.Text = nameActiveNode + "copy1";
            node.ContextMenuStrip = this.contextMenuStrip2;

            //int i = 0;
            //while(true)
            //{
            //    i++;
            //    if( nameActiveNode == node.Text )
            //    {
            //        node.Text = nameActiveNode + "copy" + i;

            //    }
            //    else
            //    {
            //        node.Text = nameActiveNode + "copy1"; 
            //        break;
            //    }

            //}


            this.treeViewXie.SelectedNode.Parent.Nodes.Add(node);
        }

        private void ToolStripMenuItem_rename_Click(object sender, EventArgs e)
        {
            //窗体的LabelEdir为false，因此每次要BeginEdit时都要先自LabelEdit为true
            treeViewXie.LabelEdit = true;
            treeViewXie.SelectedNode.BeginEdit();
        }

        private void treeViewXie_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string nameChange = e.Label;
            treeViewXie.LabelEdit = false;
            nameActiveNode = this.treeViewXie.SelectedNode.Text;
            serialActiveNode = this.treeViewXie.SelectedNode.Index;
            string grade = this.treeViewXie.SelectedNode.Parent.Parent.Text;
            string classname = this.treeViewXie.SelectedNode.Parent.Text;

            if(CheckSameName(grade, classname, nameChange))
            {
                treeViewXieSet();
                return;
            }
          
            if (grade == "高一年级" && classname == "2019年好学班")
            {
                StuInfo_GradeOne[serialActiveNode].ClassType = nameChange;
                hxNameGOne[serialActiveNode] = nameChange;
                operate.ReWriteXml(serialActiveNode, 0,  grade, nameChange);
            }
            else if (grade == "高一年级" && classname == "2019年精进班")
            {

                jjNameGOne[serialActiveNode] = nameChange;
                StuInfo_GradeOne[serialActiveNode + hxNameGOne.Count].ClassType = nameChange;
                
                operate.ReWriteXml(serialActiveNode, 1, grade, nameChange);
            }
            else if (grade == "高二年级" && classname == "2019年好学班")
            {
                hxNameGTwo[serialActiveNode] = nameChange;
                StuInfo_GradeTwo[serialActiveNode].ClassType = nameChange;
              
                operate.ReWriteXml(serialActiveNode, 0, grade, nameChange);

            }
            else if (grade == "高二年级" && classname == "2019年精进班")
            {
               
                jjNameGTwo[serialActiveNode] = nameChange;
                StuInfo_GradeTwo[serialActiveNode + hxNameGTwo.Count].ClassType = nameChange;
               
                operate.ReWriteXml(serialActiveNode, 1, grade, nameChange);
            }
            else if (grade == "高三年级" && classname == "2019年好学班")
            {
                hxNameGThr[serialActiveNode] = nameChange;
                StuInfo_GradeThr[serialActiveNode].ClassType = nameChange;
              
                operate.ReWriteXml(serialActiveNode, 0, grade, nameChange);
            }
            else if (grade == "高三年级" && classname == "2019年精进班")
            {
               
                jjNameGThr[serialActiveNode] = nameChange;
                StuInfo_GradeThr[serialActiveNode + hxNameGThr.Count].ClassType = nameChange;
              
                operate.ReWriteXml(serialActiveNode, 1, grade, nameChange);
            }

        }

        private bool CheckSameName(string grade, string classname, string nameChange)
        {
            bool isSame = true;
            if (grade == "高一年级" && classname == "2019年好学班")
            {
                isSame = hxNameGOne.Contains(nameChange);
            }
            else if (grade == "高一年级" && classname == "2019年精进班")
            {
                isSame = jjNameGOne.Contains(nameChange);
            }
            else if (grade == "高二年级" && classname == "2019年好学班")
            {
                isSame = hxNameGTwo.Contains(nameChange);
            }
            else if (grade == "高二年级" && classname == "2019年精进班")
            {
                isSame = jjNameGTwo.Contains(nameChange);
            }
            else if (grade == "高三年级" && classname == "2019年好学班")
            {
                isSame = hxNameGThr.Contains(nameChange);
            }
            else if (grade == "高三年级" && classname == "2019年精进班")
            {
                isSame = jjNameGThr.Contains(nameChange);
            }
            return isSame;
        }





        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeViewXie.SelectedNode;
         
            string grade = this.treeViewXie.SelectedNode.Parent.Parent.Text;
            string clagradessname = this.treeViewXie.SelectedNode.Parent.Text;
            node.Remove();
            TreeNode root = new TreeNode();
            if (grade == "高一年级")
                root = this.treeViewXie.Nodes[0];
            if (grade == "高二年级")
                root = this.treeViewXie.Nodes[1];
            if (grade == "高三年级")
                root = this.treeViewXie.Nodes[2];

            operate.WriteXmlInfo(grade, root);


            LoadXmlInfo();



        }
    }
}
