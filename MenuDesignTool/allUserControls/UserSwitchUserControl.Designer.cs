namespace MenuDesignTool.allUserControls
{
    partial class UserSwitchUserControl
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
            this.lblUserSwitch = new System.Windows.Forms.Label();
            this.userSwitchComBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserSwitch
            // 
            this.lblUserSwitch.AutoSize = true;
            this.lblUserSwitch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserSwitch.Location = new System.Drawing.Point(3, 0);
            this.lblUserSwitch.Name = "lblUserSwitch";
            this.lblUserSwitch.Size = new System.Drawing.Size(57, 12);
            this.lblUserSwitch.TabIndex = 3;
            this.lblUserSwitch.Text = "用户切换";
            // 
            // userSwitchComBox
            // 
            this.userSwitchComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSwitchComBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userSwitchComBox.FormattingEnabled = true;
            this.userSwitchComBox.Location = new System.Drawing.Point(3, 18);
            this.userSwitchComBox.Name = "userSwitchComBox";
            this.userSwitchComBox.Size = new System.Drawing.Size(112, 20);
            this.userSwitchComBox.TabIndex = 2;
            // 
            // UserSwitchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userSwitchComBox);
            this.Controls.Add(this.lblUserSwitch);
            this.Name = "UserSwitchUserControl";
            this.Size = new System.Drawing.Size(121, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserSwitch;
        private System.Windows.Forms.ComboBox userSwitchComBox;
    }
}
