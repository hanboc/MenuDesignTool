using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDesignTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            userSwitchComBox.SelectedIndex = 0;  // 设置用户选择下拉框默认显示为前台未登录

            //将显示设计菜单效果的窗体嵌入到主窗体内部容器的panel1中
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Dock = DockStyle.Fill;
            frmMenu.TopLevel = false;
            spContainerInside.Panel1.Controls.Add(frmMenu);
            //tableLayoutPanel1.Controls.Add(frmMenu);
            frmMenu.Show();
        }

    }
}
