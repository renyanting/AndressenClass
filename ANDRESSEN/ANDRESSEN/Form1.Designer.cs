namespace ANDRESSEN
{
    partial class FORMXIE
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewXie = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_copynew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewXie
            // 
            this.treeViewXie.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewXie.Location = new System.Drawing.Point(27, 12);
            this.treeViewXie.Name = "treeViewXie";
            this.treeViewXie.ShowNodeToolTips = true;
            this.treeViewXie.Size = new System.Drawing.Size(213, 373);
            this.treeViewXie.TabIndex = 0;
            this.treeViewXie.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewXie_AfterLabelEdit);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_copynew,
            this.ToolStripMenuItem_rename,
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 70);
            // 
            // ToolStripMenuItem_copynew
            // 
            this.ToolStripMenuItem_copynew.Name = "ToolStripMenuItem_copynew";
            this.ToolStripMenuItem_copynew.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_copynew.Text = "复制新建";
            this.ToolStripMenuItem_copynew.Click += new System.EventHandler(this.ToolStripMenuItem_copynew_Click);
            // 
            // ToolStripMenuItem_rename
            // 
            this.ToolStripMenuItem_rename.Name = "ToolStripMenuItem_rename";
            this.ToolStripMenuItem_rename.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_rename.Text = "重命名";
            this.ToolStripMenuItem_rename.Click += new System.EventHandler(this.ToolStripMenuItem_rename_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "高一年级2019年好学班春季班";
            // 
            // FORMXIE
            // 
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewXie);
            this.Name = "FORMXIE";
            this.Text = "xiechao";
            this.Load += new System.EventHandler(this.FORMXIE_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewXie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copynew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_rename;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.Label label2;
    }
}

