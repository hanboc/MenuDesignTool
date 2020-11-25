namespace MenuDesignTool.allUserControls
{
    partial class MenuInfoUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContent = new MenuDesignTool.allUserControls.CheckEmptyCustomControl(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbNoCon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnCommunication = new System.Windows.Forms.ComboBox();
            this.cmbStandCon = new System.Windows.Forms.ComboBox();
            this.cmbUrgentStationCon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCommunication = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHostCon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMidCon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtTopClickType = new System.Windows.Forms.TextBox();
            this.lblTopClickType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.cmbNoCon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbUnCommunication);
            this.groupBox1.Controls.Add(this.cmbStandCon);
            this.groupBox1.Controls.Add(this.cmbUrgentStationCon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCommunication);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbHostCon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbMidCon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.txtTopClickType);
            this.groupBox1.Controls.Add(this.lblTopClickType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单属性";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(169, 63);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(144, 21);
            this.txtContent.TabIndex = 5;
            this.txtContent.Validated += new System.EventHandler(this.txtContent_Validated);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(354, 350);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(243, 350);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cmbNoCon
            // 
            this.cmbNoCon.FormattingEnabled = true;
            this.cmbNoCon.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbNoCon.Location = new System.Drawing.Point(243, 164);
            this.cmbNoCon.Name = "cmbNoCon";
            this.cmbNoCon.Size = new System.Drawing.Size(90, 20);
            this.cmbNoCon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "无控制权：";
            // 
            // cmbUnCommunication
            // 
            this.cmbUnCommunication.FormattingEnabled = true;
            this.cmbUnCommunication.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbUnCommunication.Location = new System.Drawing.Point(243, 305);
            this.cmbUnCommunication.Name = "cmbUnCommunication";
            this.cmbUnCommunication.Size = new System.Drawing.Size(90, 20);
            this.cmbUnCommunication.TabIndex = 3;
            // 
            // cmbStandCon
            // 
            this.cmbStandCon.FormattingEnabled = true;
            this.cmbStandCon.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbStandCon.Location = new System.Drawing.Point(243, 234);
            this.cmbStandCon.Name = "cmbStandCon";
            this.cmbStandCon.Size = new System.Drawing.Size(90, 20);
            this.cmbStandCon.TabIndex = 3;
            // 
            // cmbUrgentStationCon
            // 
            this.cmbUrgentStationCon.FormattingEnabled = true;
            this.cmbUrgentStationCon.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbUrgentStationCon.Location = new System.Drawing.Point(243, 138);
            this.cmbUrgentStationCon.Name = "cmbUrgentStationCon";
            this.cmbUrgentStationCon.Size = new System.Drawing.Size(90, 20);
            this.cmbUrgentStationCon.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "不通：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "备控：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "紧急站控：";
            // 
            // cmbCommunication
            // 
            this.cmbCommunication.FormattingEnabled = true;
            this.cmbCommunication.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbCommunication.Location = new System.Drawing.Point(243, 279);
            this.cmbCommunication.Name = "cmbCommunication";
            this.cmbCommunication.Size = new System.Drawing.Size(90, 20);
            this.cmbCommunication.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "通：";
            // 
            // cmbHostCon
            // 
            this.cmbHostCon.FormattingEnabled = true;
            this.cmbHostCon.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbHostCon.Location = new System.Drawing.Point(243, 208);
            this.cmbHostCon.Name = "cmbHostCon";
            this.cmbHostCon.Size = new System.Drawing.Size(90, 20);
            this.cmbHostCon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "主控：";
            // 
            // cmbMidCon
            // 
            this.cmbMidCon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMidCon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMidCon.FormattingEnabled = true;
            this.cmbMidCon.Items.AddRange(new object[] {
            "隐藏",
            "显示",
            "显示但不可用"});
            this.cmbMidCon.Location = new System.Drawing.Point(243, 112);
            this.cmbMidCon.Name = "cmbMidCon";
            this.cmbMidCon.Size = new System.Drawing.Size(90, 20);
            this.cmbMidCon.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(83, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "与中心服务器连接状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "中控：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(83, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "主控状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "控制模式列表：";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(83, 67);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(70, 12);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "菜单内容：";
            // 
            // txtTopClickType
            // 
            this.txtTopClickType.Location = new System.Drawing.Point(169, 26);
            this.txtTopClickType.Name = "txtTopClickType";
            this.txtTopClickType.Size = new System.Drawing.Size(144, 21);
            this.txtTopClickType.TabIndex = 1;
            this.txtTopClickType.Validated += new System.EventHandler(this.txtTopClickType_Validated);
            // 
            // lblTopClickType
            // 
            this.lblTopClickType.AutoSize = true;
            this.lblTopClickType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTopClickType.Location = new System.Drawing.Point(83, 30);
            this.lblTopClickType.Name = "lblTopClickType";
            this.lblTopClickType.Size = new System.Drawing.Size(70, 12);
            this.lblTopClickType.TabIndex = 0;
            this.lblTopClickType.Text = "操作类型：";
            // 
            // MenuInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuInfoUserControl";
            this.Size = new System.Drawing.Size(476, 379);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtTopClickType;
        private System.Windows.Forms.Label lblTopClickType;
        private System.Windows.Forms.ComboBox cmbNoCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStandCon;
        private System.Windows.Forms.ComboBox cmbUrgentStationCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHostCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMidCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUnCommunication;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCommunication;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private CheckEmptyCustomControl txtContent;
    }
}
