using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOperateServiceLibrary.Enum;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace MenuDesignTool.allUserControls
{
    public partial class MenuInfoUserControl : UserControl
    {
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

        // ClickType枚举值列表
        readonly List<string> clickTypes = new List<string>();

        public MenuInfoUserControl()
        {
            InitializeComponent();
            getAllUserRole();
            BindDataType();
        }

        private void txtTopClickType_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTopClickType.Text))
            {
                MessageBox.Show("操作类型不能为空，请重新输入！");
            }
            else if (!clickTypes.Contains(txtTopClickType.Text))
            {
                MessageBox.Show("操作类型不存在，请重新输入！");
                txtTopClickType.Text = "";
            }
        }


        private void getAllUserRole()
        {
            foreach (ClickType click in Enum.GetValues(typeof(ClickType)))
            {
                clickTypes.Add(click.ToString());
            }
        }

        private void txtContent_Validated(object sender, EventArgs e)
        {
            this.txtContent.BeginCheckEmpty();
        }

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

        private void LoadXmlToTreeView(XElement rootElement, TreeNodeCollection treeNodeCollection)
        {
            foreach (XElement item in rootElement.Elements())
            {
                if (item.Elements().Count() == 0)
                {
                    treeNodeCollection.Add(item.Name.ToString()).Nodes.Add(item.Value);
                }
                else
                {
                    TreeNode node = treeNodeCollection.Add(item.Name.ToString());
                    LoadXmlToTreeView(item, node.Nodes);
                }

            }
        }

        /// <summary>
        /// 下拉树折叠后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcbDataType_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.ImageIndex == 1)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = 0;
        }
        /// <summary>
        /// 下拉树展开后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcbDataType_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.ImageIndex == 0)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = 1;
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
    }
}

