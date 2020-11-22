using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDesignTool.allUserControls
{
    public partial class UserSwitchUserControl : UserControl
    {

        public UserSwitchUserControl()
        {
            InitializeComponent();
            userSwitchComBox.Items.AddRange(getAllUserRole());
            userSwitchComBox.SelectedIndex = 0;  // 设置用户选择下拉框默认显示为前台未登录

        }

        /// <summary>
        /// 获取所有登录角色
        /// </summary>
        /// <returns></returns>
        private string[] getAllUserRole()
        {
            List<string> role = new List<string>();
            foreach (UserRole userRole in Enum.GetValues(typeof(UserRole)))
            {
                role.Add(userRole.ToString());
            }
            return role.ToArray();
        }
    }
}
