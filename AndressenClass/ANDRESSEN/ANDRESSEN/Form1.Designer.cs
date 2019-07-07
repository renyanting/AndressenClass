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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_Add = new System.Windows.Forms.Button();
            this.button1_Delete = new System.Windows.Forms.Button();
            this.button1_save = new System.Windows.Forms.Button();
            this.button1_export = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewXie
            // 
            this.treeViewXie.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewXie.Location = new System.Drawing.Point(27, 27);
            this.treeViewXie.Name = "treeViewXie";
            this.treeViewXie.ShowNodeToolTips = true;
            this.treeViewXie.Size = new System.Drawing.Size(213, 358);
            this.treeViewXie.TabIndex = 0;
            this.treeViewXie.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewXie_AfterLabelEdit);
            this.treeViewXie.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewXie_NodeMouseClick);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(458, 326);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1_Add
            // 
            this.button1_Add.Location = new System.Drawing.Point(308, 362);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(75, 23);
            this.button1_Add.TabIndex = 4;
            this.button1_Add.Text = "增加列";
            this.button1_Add.UseVisualStyleBackColor = true;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click);
            // 
            // button1_Delete
            // 
            this.button1_Delete.Location = new System.Drawing.Point(423, 362);
            this.button1_Delete.Name = "button1_Delete";
            this.button1_Delete.Size = new System.Drawing.Size(75, 23);
            this.button1_Delete.TabIndex = 5;
            this.button1_Delete.Text = "删除列";
            this.button1_Delete.UseVisualStyleBackColor = true;
            this.button1_Delete.Click += new System.EventHandler(this.button1_Delete_Click);
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(536, 362);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 6;
            this.button1_save.Text = "保存";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // button1_export
            // 
            this.button1_export.Location = new System.Drawing.Point(649, 362);
            this.button1_export.Name = "button1_export";
            this.button1_export.Size = new System.Drawing.Size(75, 23);
            this.button1_export.TabIndex = 7;
            this.button1_export.Text = "导出";
            this.button1_export.UseVisualStyleBackColor = true;
            this.button1_export.Click += new System.EventHandler(this.button1_export_Click);
            // 
            // FORMXIE
            // 
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.button1_export);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.button1_Delete);
            this.Controls.Add(this.button1_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewXie);
            this.Name = "FORMXIE";
            this.Text = "xiechao";
            this.Load += new System.EventHandler(this.FORMXIE_Load);
            this.Resize += new System.EventHandler(this.FORMXIE_Resize);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Button button1_Delete;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.Button button1_export;
    }
}

