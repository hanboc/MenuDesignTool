using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuDesignTool.allUserControls;

namespace MenuDesignTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // 添加用户切换控件
            UserSwitchUserControl userSwitchUserControl = new UserSwitchUserControl();
            this.userSwitchPanel.Controls.Add(userSwitchUserControl);
            //menuStrip2.ContextMenuStrip = this.contextMenuStrip1;

            // 添加MenuInfo控件
            MenuInfoUserControl menuInfoUserControl = new MenuInfoUserControl();
            this.panelMenuInfo.Controls.Add(menuInfoUserControl);

        }

        private void btnMenuContol_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem newMenu = new ToolStripMenuItem("一级菜单");
            this.menuStrip2.Items.Add(newMenu);
            lblResultTip.BackColor = Color.Red;
            lblResultTip.Text = "插入新的菜单栏菜单";

            this.propertyGrid1.SelectedObject = newMenu;

            newMenu.MouseUp += new MouseEventHandler(MenuControlClick);
            //foreach (Control item in spContainerInside.Panel1.Controls)
            //{
            //    item.ContextMenuStrip = this.contextMenuStrip1;
            //}
        }

        private void MenuControlClick(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            //Button menuButton = (Button)sender;
            //menuButton.ContextMenuStrip = this.contextMenuStrip1;
            if (Mouse_e.Button == MouseButtons.Right)
            {

                this.contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
            //ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            //ToolStripMenuItem childrenMenu = new ToolStripMenuItem("子菜单");
            //menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { childrenMenu });
            //propertyGrid1.SelectedObject = childrenMenu;
        }

        private void editTSMeu_Click(object sender, EventArgs e)
        {
            //string bindToolStripMenu = (sender as ContextMenuStrip).SourceControl.Name;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //string bindToolStripMenu = (sender as ContextMenuStrip).SourceControl.Name;
        }

        private void deleteTSMeu_Click(object sender, EventArgs e)
        {
            //string bindToolStripMenu = (sender as ContextMenuStrip).SourceControl.Name;
        }
    }
}
