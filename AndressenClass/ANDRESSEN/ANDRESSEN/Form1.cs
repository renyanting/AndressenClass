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

        List<string> columInfo = new List<string> { "姓名", "性别", "联系电话", "学校",
            "成绩一","成绩二","成绩三" };

        float X, Y;//X表示窗体的宽度，Y表示窗体的高度

        public FORMXIE()
        {
            InitializeComponent();
            treeViewXieSet();

            LoadXmlInfo();

       
        }

        private void FORMXIE_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            X = this.Width;//赋值初始窗体宽度
            Y = this.Height;//赋值初始窗体高度
            setTag(this);

            //operate.WriteXmlInfo();
        }

        private void setTag(Control cons)
        {//遍历窗体中的控件
             foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        /// <summary>
        /// 读取xml信息
        /// </summary>
        public void LoadXmlInfo()
        {         
            operate.ReadXmlInfo(ref StuInfo_GradeOne, "SENIONE.xml");
            operate.ReadXmlInfo(ref StuInfo_GradeTwo, "SENITWO.xml");
            operate.ReadXmlInfo(ref StuInfo_GradeThr, "SENITHREE.xml");

            GetClassName(StuInfo_GradeOne);
            GetClassName(StuInfo_GradeTwo);
            GetClassName(StuInfo_GradeThr);

        }

        /// <summary>
       /// 初始化grid
       /// </summary>
       /// <param name="view"></param>
       /// <param name="colum">第一列显示内容</param>
        public void InitDataGridView(DataGridView view, List<string> colum)
        {
            DataGridViewTextBoxColumn txtClum = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(txtClum);
            
          
            for (int i = 0; i < columInfo.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();

                textboxcell.Value = colum[i];
                row.Cells.Add(textboxcell);
                // row.HeaderCell.;
                dataGridView1.AllowUserToAddRows = false;
                // dataGridView1.RowHeadersVisible = false;
                //dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.Rows.Add(row);
            }
            
           
          
        }

        /// <summary>
        /// 获取班级名
        /// </summary>
        /// <param name="StuInfo"></param>
        public void GetClassName(List<StudentInfo>  StuInfo)
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

        /// <summary>
        /// 初始化treeview
        /// </summary>
        /// <param name="text">根节点名称--年级</param>
        /// <returns></returns>
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

        /// <summary>
        /// 设置treeview
        /// </summary>
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
        }

        /// <summary>
        /// 复制新建快捷键
        /// </summary>
        private void ToolStripMenuItem_copynew_Click(object sender, EventArgs e)
        {
            nameActiveNode = this.treeViewXie.SelectedNode.Text;
            serialActiveNode = this.treeViewXie.SelectedNode.Index;
            string grade = this.treeViewXie.SelectedNode.Parent.Parent.Text;
            string classname = this.treeViewXie.SelectedNode.Parent.Text;

            TreeNode node = new TreeNode();
            node.Text = nameActiveNode + "copy1";
            node.ContextMenuStrip = this.contextMenuStrip2;

            int i = 0;
            while (true)
            {
                i++;
                if (nameActiveNode == node.Text)
                {
                    node.Text = nameActiveNode + "copy" + i;

                }
                else
                {
                    node.Text = nameActiveNode + "copy1";
                    break;
                }

            }
            this.treeViewXie.SelectedNode.Parent.Nodes.Add(node);
            //添加新班型
            StudentInfo stuData = new StudentInfo();
            stuData.SeniorGrade = grade;
            stuData.ClassName = classname;
            stuData.ClassType = node.Text;

            Person perInfo = new Person();
            perInfo.StuInfo = new List<string> { "张三", "男" , "111" , "高新一中" ,
            "22","22","22"};
            List<Person> stus = new List<Person> { perInfo , perInfo };

            stuData.Students = stus;
            if(grade == "高一年级")
                StuInfo_GradeOne.Add(stuData);
            if (grade == "高二年级")
                StuInfo_GradeTwo.Add(stuData);
            if (grade == "高三年级")
                StuInfo_GradeThr.Add(stuData);

            operate.InsertXML(grade, classname, nameActiveNode, node.Text);
        
         
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
            string grade  = this.treeViewXie.SelectedNode.Parent.Parent.Text;
           
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

        private void FORMXIE_Resize(object sender, EventArgs e)
        {
            float newX = this.Width / X;//获取当前宽度与初始宽度的比例
            float newY = this.Height / Y;//获取当前高度与初始高度的比例
            setControls(newX, newY, this);
            this.Text = "窗体宽：" + this.Width.ToString() + " 窗体高：" + this.Height.ToString();//窗体标题栏
        }
        /// <summary>
        /// 根据窗体大小调整控件大小
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="cons"></param>
        private void setControls(float newX, float newY, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组

                float a = Convert.ToSingle(mytag[0]) * newX;//根据窗体缩放比例确定控件的值，宽度//89*300
                con.Width = (int)(a);//宽度

                a = Convert.ToSingle(mytag[1]) * newY;//根据窗体缩放比例确定控件的值，高度//12*300
                con.Height = (int)(a);//高度

                a = Convert.ToSingle(mytag[2]) * newX;//根据窗体缩放比例确定控件的值，左边距离//
                con.Left = (int)(a);//左边距离

                a = Convert.ToSingle(mytag[3]) * newY;//根据窗体缩放比例确定控件的值，上边缘距离
                con.Top = (int)(a);//上边缘距离

                Single currentSize = Convert.ToSingle(mytag[4]) * newY;//根据窗体缩放比例确定控件的值，字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);//字体大小

                if (con.Controls.Count > 0)
                {
                    setControls(newX, newY, con);
                }

                //Remarks：
                //控件当前宽度：控件初始宽度=窗体当前宽度：窗体初始宽度
                //控件当前宽度=控件初始宽度*(窗体当前宽度/窗体初始宽度)
            }
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn txtClum = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(txtClum);
        }

        private void button1_Delete_Click(object sender, EventArgs e)
        {
           //foreach(DataGridViewColumn txtClum in this.dataGridView1.SelectedColumns)
           // {
                
           // }
         
           // DataGridView dgv = sender as DataGridView;
            int index = this.dataGridView1.CurrentCell.ColumnIndex;
            dataGridView1.Columns.RemoveAt(index);
        }

        private void button1_save_Click(object sender, EventArgs e)
        {

        }

        private void button1_export_Click(object sender, EventArgs e)
        {

        }

        private void treeViewXie_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nameActiveNode = e.Node.Text;
            serialActiveNode = e.Node.Index;
           
            string grade = e.Node.Parent.Parent.Text;
            string classname = e.Node.Parent.Text;

            string filename;
            if (grade == "高一年级")
                filename = "SENIONE.xml";
            else if (grade == "高二年级")
                filename = "SENITWO.xml";
            else
                filename = "SENITHREE.xml";

            List<StudentInfo> studentsInfo = new List<StudentInfo>();
            operate.ReadXmlInfo(ref studentsInfo, filename);
            //更新表名
            this.label2.Text = grade + classname + nameActiveNode;

            //获取当前节点对应的学生信息
            List<Person> stuInfo = studentsInfo[serialActiveNode].Students;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            InitDataGridView(this.dataGridView1, columInfo);
            AddDataGridViewColum(this.dataGridView1, stuInfo);

        }
        public void AddDataGridViewColum(DataGridView view, List<Person> stuInfo)
        {
            foreach (Person stu in stuInfo)
            {
                DataGridViewTextBoxColumn txtClum = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(txtClum);
                int index = txtClum.Index;

                List<string> Info = stu.StuInfo;
                for (int i = 0; i < Info.Count; i++)
                {
                    txtClum.DataGridView.Rows[i].Cells[index].Value = Info[i];
                }
            }
            


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
