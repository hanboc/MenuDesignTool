namespace MenuDesignTool
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeComboBoxCustomControl1 = new MenuDesignTool.allUserControls.TreeComboBoxCustomControl(this.components);
            this.SuspendLayout();
            // 
            // treeComboBoxCustomControl1
            // 
            this.treeComboBoxCustomControl1.ImageList = null;
            this.treeComboBoxCustomControl1.Location = new System.Drawing.Point(152, 69);
            this.treeComboBoxCustomControl1.MaxDropDownItems = 15;
            this.treeComboBoxCustomControl1.Name = "treeComboBoxCustomControl1";
            this.treeComboBoxCustomControl1.SelectedNode = null;
            this.treeComboBoxCustomControl1.ShowLines = true;
            this.treeComboBoxCustomControl1.ShowNodeToolTips = false;
            this.treeComboBoxCustomControl1.ShowPlusMinus = true;
            this.treeComboBoxCustomControl1.ShowRootLines = true;
            this.treeComboBoxCustomControl1.Size = new System.Drawing.Size(201, 21);
            this.treeComboBoxCustomControl1.TabIndex = 0;
            this.treeComboBoxCustomControl1.Text = "treeComboBoxCustomControl1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeComboBoxCustomControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(578, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private allUserControls.TreeComboBoxCustomControl treeComboBoxCustomControl1;
    }
}
