using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

//引入窗体的命名空间
using System.Windows.Forms;

namespace MenuDesignTool.allUserControls
{
    public partial class CheckEmptyCustomControl : TextBox
    {
        public CheckEmptyCustomControl()
        {
            InitializeComponent();
        }

        public CheckEmptyCustomControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        public void BeginCheckEmpty()
        {
            if (this.Text.Trim() == "")
            {
                this.errorProvider.SetError(this, "必填项不能为空！");
            }
            else
            {
                this.errorProvider.SetError(this, string.Empty);
            }
        }
    }
}