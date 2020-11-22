using IOperateServiceLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterLinefieldForm
{
    /// <summary>
    /// 菜单元素
    /// </summary>
    [Serializable]
    public class MenuInfo
    {
        private ClickType _topClickType = ClickType.None;
        /// <summary>
        /// 操作类型
        /// </summary>
        public ClickType TopClickType
        {
            get { return _topClickType; }
            set { _topClickType = value; }
        }

        private string _content = "未知";
        /// <summary>
        /// 菜单显示内容
        /// </summary>
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        private List<Tuple<byte, showStatus>> _controlModes = new List<Tuple<byte, showStatus>>();
        /// <summary>
        /// 控制模式列表(各种控制模式： 中控、紧急站控、无控制权)
        /// </summary>
        public List<Tuple<byte, showStatus>> ControlModes
        {
            get { return _controlModes; }
            set { _controlModes = value; }
        }
         
        private List<Tuple<byte, showStatus>> _controlPowers = new List<Tuple<byte, showStatus>>();
        /// <summary>
        /// 主控状态（主控，备控）
        /// </summary>
        public List<Tuple<byte, showStatus>> ControlPowers
        {
            get { return _controlPowers; }
            set { _controlPowers = value; }
        }

        private List<Tuple<byte, showStatus>> _connetCenterStatus = new List<Tuple<byte, showStatus>>();
        /// <summary>
        /// 与中心应服务器连接状态列表（状态：通、不通）
        /// </summary>
        public List<Tuple<byte, showStatus>> ConnetCenterStatus
        {
            get { return _connetCenterStatus; }
            set { _connetCenterStatus = value; }
        }

        List<MenuInfo> _childMenuInfos = new List<MenuInfo>();
        /// <summary>
        /// 包含的子菜单列表
        /// </summary>
        public List<MenuInfo> ChildMenuInfos
        {
            get { return _childMenuInfos; }
            set { _childMenuInfos = value; }
        }
    }
    /// <summary>
    /// 显示效果
    /// </summary>
    [Serializable]
    public enum showStatus : byte
    {
        /// <summary>
        /// 隐藏
        /// </summary>
        Hide = 0,
        /// <summary>
        /// 显示
        /// </summary>
        Show =1,
        /// <summary>
        /// 显示但不可用
        /// </summary>
        Unusable =2
    }
}
