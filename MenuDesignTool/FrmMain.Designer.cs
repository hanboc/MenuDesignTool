namespace MenuDesignTool
{
    partial class FrmMain
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
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.布局区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnCancle = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolBox = new System.Windows.Forms.Panel();
            this.spContainerOut = new System.Windows.Forms.SplitContainer();
            this.lblTool = new System.Windows.Forms.Label();
            this.userSwitchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userSwitchComBox = new System.Windows.Forms.ComboBox();
            this.lblUserSwitch = new System.Windows.Forms.Label();
            this.btnMenuContol = new System.Windows.Forms.Button();
            this.spContainerInside = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTool = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerOut)).BeginInit();
            this.spContainerOut.Panel1.SuspendLayout();
            this.spContainerOut.Panel2.SuspendLayout();
            this.spContainerOut.SuspendLayout();
            this.userSwitchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerInside)).BeginInit();
            this.spContainerInside.Panel2.SuspendLayout();
            this.spContainerInside.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.保存ToolStripMenuItem.Text = "保存(&S)         Ctrl+S";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.刷新ToolStripMenuItem,
            this.toolStripSeparator1,
            this.删除ToolStripMenuItem,
            this.恢复ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.撤销ToolStripMenuItem.Text = "撤销(&Z)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.toolStripMenuItem1.Text = "重做(&Y)";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 恢复ToolStripMenuItem
            // 
            this.恢复ToolStripMenuItem.Name = "恢复ToolStripMenuItem";
            this.恢复ToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.恢复ToolStripMenuItem.Text = "恢复";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.布局区域ToolStripMenuItem,
            this.角色区ToolStripMenuItem,
            this.属性区ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.视图ToolStripMenuItem.Text = "视图(&V)";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.菜单ToolStripMenuItem.Text = "菜单区域";
            // 
            // 布局区域ToolStripMenuItem
            // 
            this.布局区域ToolStripMenuItem.Name = "布局区域ToolStripMenuItem";
            this.布局区域ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.布局区域ToolStripMenuItem.Text = "布局区域";
            // 
            // 角色区ToolStripMenuItem
            // 
            this.角色区ToolStripMenuItem.Name = "角色区ToolStripMenuItem";
            this.角色区ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.角色区ToolStripMenuItem.Text = "角色选择";
            // 
            // 属性区ToolStripMenuItem
            // 
            this.属性区ToolStripMenuItem.Name = "属性区ToolStripMenuItem";
            this.属性区ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.属性区ToolStripMenuItem.Text = "属性区";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnReturn,
            this.btnReload,
            this.btnCancle,
            this.btnRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::MenuDesignTool.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "保存";
            // 
            // btnReturn
            // 
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = global::MenuDesignTool.Properties.Resources.Return;
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(23, 22);
            this.btnReturn.Text = "恢复";
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = global::MenuDesignTool.Properties.Resources.reload;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 22);
            this.btnReload.Text = "刷新";
            // 
            // btnCancle
            // 
            this.btnCancle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancle.Image = global::MenuDesignTool.Properties.Resources.Cancle;
            this.btnCancle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(23, 22);
            this.btnCancle.Text = "撤销";
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::MenuDesignTool.Properties.Resources.Redo;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "重做";
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.spContainerOut);
            this.toolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBox.Location = new System.Drawing.Point(0, 53);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(1264, 676);
            this.toolBox.TabIndex = 2;
            // 
            // spContainerOut
            // 
            this.spContainerOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainerOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerOut.Location = new System.Drawing.Point(0, 0);
            this.spContainerOut.Name = "spContainerOut";
            // 
            // spContainerOut.Panel1
            // 
            this.spContainerOut.Panel1.Controls.Add(this.panelTool);
            this.spContainerOut.Panel1.Controls.Add(this.userSwitchPanel);
            this.spContainerOut.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // spContainerOut.Panel2
            // 
            this.spContainerOut.Panel2.Controls.Add(this.spContainerInside);
            this.spContainerOut.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spContainerOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spContainerOut.Size = new System.Drawing.Size(1264, 676);
            this.spContainerOut.SplitterDistance = 159;
            this.spContainerOut.TabIndex = 0;
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(3, 9);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(44, 12);
            this.lblTool.TabIndex = 0;
            this.lblTool.Text = "工具箱";
            // 
            // userSwitchPanel
            // 
            this.userSwitchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userSwitchPanel.Controls.Add(this.userSwitchComBox);
            this.userSwitchPanel.Controls.Add(this.lblUserSwitch);
            this.userSwitchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSwitchPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.userSwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.userSwitchPanel.Name = "userSwitchPanel";
            this.userSwitchPanel.Size = new System.Drawing.Size(155, 46);
            this.userSwitchPanel.TabIndex = 0;
            // 
            // userSwitchComBox
            // 
            this.userSwitchComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSwitchComBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userSwitchComBox.FormattingEnabled = true;
            this.userSwitchComBox.Items.AddRange(new object[] {
            "前台未登录",
            "派班角色登录",
            "调度登录",
            "维护登录",
            "车务终端监视员登录",
            "调度主任登录",
            "现地值班员未登录",
            "现地值班员登录",
            "后台登未录",
            "后台登录",
            "编图员未登录",
            "编图员登录",
            "管理员登录"});
            this.userSwitchComBox.Location = new System.Drawing.Point(3, 21);
            this.userSwitchComBox.Name = "userSwitchComBox";
            this.userSwitchComBox.Size = new System.Drawing.Size(146, 20);
            this.userSwitchComBox.TabIndex = 0;
            // 
            // lblUserSwitch
            // 
            this.lblUserSwitch.AutoSize = true;
            this.lblUserSwitch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserSwitch.Location = new System.Drawing.Point(3, 6);
            this.lblUserSwitch.Name = "lblUserSwitch";
            this.lblUserSwitch.Size = new System.Drawing.Size(57, 12);
            this.lblUserSwitch.TabIndex = 1;
            this.lblUserSwitch.Text = "用户切换";
            // 
            // btnMenuContol
            // 
            this.btnMenuContol.BackColor = System.Drawing.Color.White;
            this.btnMenuContol.Location = new System.Drawing.Point(20, 30);
            this.btnMenuContol.Name = "btnMenuContol";
            this.btnMenuContol.Size = new System.Drawing.Size(95, 36);
            this.btnMenuContol.TabIndex = 1;
            this.btnMenuContol.Text = "MenuStrip";
            this.btnMenuContol.UseVisualStyleBackColor = false;
            // 
            // spContainerInside
            // 
            this.spContainerInside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spContainerInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerInside.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spContainerInside.Location = new System.Drawing.Point(0, 0);
            this.spContainerInside.Name = "spContainerInside";
            // 
            // spContainerInside.Panel1
            // 
            this.spContainerInside.Panel1.AutoScroll = true;
            // 
            // spContainerInside.Panel2
            // 
            this.spContainerInside.Panel2.Controls.Add(this.label1);
            this.spContainerInside.Panel2.Controls.Add(this.propertyGrid1);
            this.spContainerInside.Size = new System.Drawing.Size(1097, 672);
            this.spContainerInside.SplitterDistance = 770;
            this.spContainerInside.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(6, 53);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(306, 595);
            this.propertyGrid1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "属性";
            // 
            // panelTool
            // 
            this.panelTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTool.Controls.Add(this.btnMenuContol);
            this.panelTool.Controls.Add(this.lblTool);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(0, 46);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(155, 626);
            this.panelTool.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单设计工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.spContainerOut.Panel1.ResumeLayout(false);
            this.spContainerOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerOut)).EndInit();
            this.spContainerOut.ResumeLayout(false);
            this.userSwitchPanel.ResumeLayout(false);
            this.userSwitchPanel.PerformLayout();
            this.spContainerInside.Panel2.ResumeLayout(false);
            this.spContainerInside.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerInside)).EndInit();
            this.spContainerInside.ResumeLayout(false);
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 布局区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnReturn;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnCancle;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Panel toolBox;
        private System.Windows.Forms.SplitContainer spContainerOut;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Button btnMenuContol;
        private System.Windows.Forms.FlowLayoutPanel userSwitchPanel;
        private System.Windows.Forms.ComboBox userSwitchComBox;
        private System.Windows.Forms.Label lblUserSwitch;
        private System.Windows.Forms.SplitContainer spContainerInside;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel panelTool;
    }
}

