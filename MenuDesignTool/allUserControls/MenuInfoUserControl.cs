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

namespace MenuDesignTool.allUserControls
{
    public partial class MenuInfoUserControl : UserControl
    {
        // ClickType枚举值列表
        readonly List<string> clickTypes = new List<string>();

        public MenuInfoUserControl()
        {
            InitializeComponent();
            getAllUserRole();
        }

        private void txtTopClickType_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTopClickType.Text))
            {
                MessageBox.Show("操作类型不能为空，请重新输入！");
            }
            else if(!clickTypes.Contains(txtTopClickType.Text))
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
    }
}
