using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MenuDesignTool.allUserControls;

namespace MenuDesignTool
{
    public partial class FrmMain : Form
    {
        // 记录鼠标右键选择的一级菜单项
        ToolStripMenuItem checkMenuItem = null;
        //右键选择的子菜单项
        ToolStripMenuItem checkChildMenuItem = null;

        public FrmMain()
        {
            InitializeComponent();

            // 添加用户切换控件
            UserSwitchUserControl userSwitchUserControl = new UserSwitchUserControl();
            this.userSwitchPanel.Controls.Add(userSwitchUserControl);

        }

        private void btnMenuContol_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem newMenu = new ToolStripMenuItem("一级菜单");
            this.menuStrip2.Items.Add(newMenu);
            lblResultTip.BackColor = Color.Green;
            lblResultTip.Text = "插入菜单项";

            this.propertyGrid1.SelectedObject = newMenu;

            newMenu.MouseUp += new MouseEventHandler(MenuControlClick);
        }

        private void MenuControlClick(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Right)
            {
                checkMenuItem = (ToolStripMenuItem)sender;

                this.contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
            else
            {
                this.propertyGrid1.SelectedObject = sender;
            }
        }

        private void MenuChildControlClick(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Right)
            {
                checkChildMenuItem = (ToolStripMenuItem)sender;

                this.contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
            else
            {
                this.propertyGrid1.SelectedObject = sender;
            }
        }

        private void editTSMeu_Click(object sender, EventArgs e)
        {
            //string bindToolStripMenu = (sender as ContextMenuStrip).SourceControl.Name;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //string bindToolStripMenu = (sender as ContextMenuStrip).SourceControl.Name;
        }

        private void addChildTSMeu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem childrenMenu = new ToolStripMenuItem("子菜单");
            checkMenuItem.DropDownItems.Add(childrenMenu);

            lblResultTip.BackColor = Color.Green;
            lblResultTip.Text = $"菜单{checkMenuItem}插入子菜单项";
            propertyGrid1.SelectedObject = childrenMenu;
            childrenMenu.MouseUp += new MouseEventHandler(MenuChildControlClick);
        }

        private void deleteTSMeu_Click(object sender, EventArgs e)
        {
            //menuStrip2.Items.Remove(checkMenuItem);
            checkMenuItem.DropDownItems.Remove(checkChildMenuItem);
            lblResultTip.BackColor = Color.Red;
            //lblResultTip.Text = $"删除菜单项：{checkChildMenuItem.Text}";
        }

        #region 控件
        #region 自定义控件TreeView数据绑定
        /// <summary>
        /// ini
        /// </summary>
        private const string _INI = "ini";

        /// <summary>
        /// ini
        /// </summary>
        private const string _FILE_DIRECTORY = "menu";

        /// <summary>
        /// menuClickTypes.xml
        /// </summary>
        private const string _FILENAME = "menuClickTypes.xml";

        /// <summary>
        /// 配置文件根路径
        /// </summary>
        private string _configRootPath = "";

        /// <summary>
        /// 菜单操作类型文件的路径
        /// </summary>
        private string _menuClickTypeFile = "";

        /// <summary>
        /// 数据分类数据绑定
        /// </summary>
        private void BindDataType()
        {
            XmlDocument document = new XmlDocument();

            GetFilePath();
            document.Load(_menuClickTypeFile);

            clickTypeTreeView.Nodes.Clear();
            BindXmlToTreeView(document.DocumentElement.ChildNodes, clickTypeTreeView.Nodes);

        }

        protected void BindXmlToTreeView(XmlNodeList xmlnodes, TreeNodeCollection treeNodes)
        {
            foreach (XmlNode child in xmlnodes)
            {
                if (child.Attributes != null && child.Attributes.Count > 0)
                {
                    string treeText = child.Attributes["value"].Value;
                    TreeNode tn = new TreeNode(treeText);
                    treeNodes.Add(tn);
                    BindXmlToTreeView(child.ChildNodes, tn.Nodes);
                }
            }
        }

        /// <summary>
        /// 获取配置文件路径
        /// </summary>
        private void GetFilePath()
        {
            string configFilePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString();
            configFilePath = Directory.GetParent(configFilePath).ToString();
            _configRootPath = Path.Combine(configFilePath, _INI, _FILE_DIRECTORY);

            _menuClickTypeFile = Path.Combine(_configRootPath, _FILENAME);
        }

        #endregion


        /// <summary>
        /// 开启菜单内容输入非空验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContent_Validated(object sender, EventArgs e)
        {
            this.txtContent.BeginCheckEmpty();
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BindDataType();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
